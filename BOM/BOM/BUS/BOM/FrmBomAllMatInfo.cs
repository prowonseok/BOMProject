using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOM.VO;

namespace BOM.BUS.BOM
{
    /// <summary>
    /// BOM등록을 위해 Materials Table에서 모든 데이터를 출력해서 등록하는 Form
    /// </summary>
    public partial class FrmBomAllMatInfo : Form
    { 
        DAO.BomDAO bDao;
        DataTable dt;
        DataTable dtClone; //DataTable의 형변환을 위한 CloneTable
        FrmBomInfoControl fbi;

        int mat_Level=9999;//Form이 매개변수 없이 실행되었을 때(부모 자재 지정시) 초기값을 지정
        int mat_No;

        /// <summary>
        /// 자식 자재 등록을 위해 매개변수로 부모 자재의 정보를 받아온 생성자
        /// </summary>
        /// <param name="mat_Level">부모자재의 Level</param>
        /// <param name="mat_No">부모자재의 자재 번호</param>
        public FrmBomAllMatInfo(int mat_Level, int mat_No):this()
        {
            this.mat_Level = mat_Level;
            this.mat_No = mat_No;
        }

        /// <summary>
        /// 부모 자재 등록을 위한 생성자
        /// </summary>
        public FrmBomAllMatInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form이 Load될 때 발생하는 이벤트
        /// 부모 자재 등록 시는 원자재가 아닌 값만 뜨도록 설정
        /// 자식 자재 등록 시는 부모 자재와 동일하지 않은 자재만 뜨고, 부모자재보다 레벨이 높은 값은 뜨지 않도록 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBomAllMatInfo_Load(object sender, EventArgs e)
        {
            dgvAllMat.Font = new Font("맑은고딕", 9);
            fbi = new FrmBomInfoControl();
            //부모 자재를 등록할 때
            if (mat_Level==9999)
            {
                //부모 자재는 Mat_Level의 값이 0이 아닌 값만 뜨도록 설정
                bDao = new DAO.BomDAO();
                dt = bDao.SelectBom(true);
                dgvAllMat.DataSource = fbi.CloneDataTable(dt,dtClone);
                DisplayGridview();
            }
            else //자식 자재를 등록할 때
            {
                //자식 자재는 부모 자재보다 Level값이 같거나 작은 값만 뜨며, 자신은 안뜨도록 설정
                //자식 자재는 완제품은 출력되지 않도록 설정
                bDao = new DAO.BomDAO();
                dt = bDao.SelectBom(mat_Level, mat_No);
                dgvAllMat.DataSource =fbi.CloneDataTable(dt, dtClone);
                DisplayGridview();
            }
        }

        /// <summary>
        /// 출력한 그리드뷰에 대해 설정하는 메서드
        /// </summary>
        private void DisplayGridview()
        {
            dgvAllMat.Columns.RemoveAt(7);
            dgvAllMat.Columns.RemoveAt(6);
            dgvAllMat.Columns.RemoveAt(4);
            dgvAllMat.Columns.RemoveAt(1);

            dgvAllMat.Columns[0].HeaderText = "자재 번호";
            dgvAllMat.Columns[1].HeaderText = "제조사";
            dgvAllMat.Columns[2].HeaderText = "자재명";
            dgvAllMat.Columns[3].HeaderText = "자재 단계";

            dgvAllMat.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvAllMat.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// 등록 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int levelNum = 0;
            //주인 Form인 FrmBomAdd의 프로퍼티에 값을 저장하며 등록을 뜻하는 CanOrAdd의 값을 True로 저장
            FrmBomAdd fba = (FrmBomAdd)Owner;
            fba.MatNo = Int32.Parse(dgvAllMat.SelectedRows[0].Cells[0].Value.ToString());                   //품목 번호
            fba.MatName = dgvAllMat.SelectedRows[0].Cells[2].Value.ToString();                              //품목 명
            switch (dgvAllMat.SelectedRows[0].Cells[3].Value.ToString())
            {
                case "원재료":
                    levelNum = 0;
                    break;
                case "반제품":
                    levelNum = 1;
                    break;
                case "완제품":
                    levelNum = 2;
                    break;
                default:
                    break;
            }
            fba.MatLevel = levelNum;                                                                        //품목 레벨
            fba.CanOrAdd = true;
            this.Close();
        }

        /// <summary>
        /// 취소 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //주인 Form인 FrmBomAdd의 프로퍼티 CanOrAdd의 값을 False로 저장
            FrmBomAdd fba = (FrmBomAdd)Owner;
            fba.CanOrAdd = false;
            this.Close();
        }

        /// <summary>
        ///검색 시 선택 항목을 최상단으로 올려주는 메서드
        /// </summary>
        /// <param name="item"></param>
        private void SearchMat(DataGridViewRow item)
        {
            dgvAllMat.FirstDisplayedScrollingRowIndex = item.Index;
            item.Selected = true;
        }

        /// <summary>
        /// 검색 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //검색 타입(콤보박스)가 지정되지 않았을 경우
            if (string.IsNullOrEmpty(cbbType.Text))
            {
                MessageBox.Show("검색 타입을 지정해주세요");
            }//검색어를 입력하지 않았을 경우
            else if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("검색어를 입력해주세요");
            }
            else
            {
                //입력이 올바른 경우
                int searchType = 0;   //그리드뷰의 column 번호를 저장하는 변수
                bool isFirst = true;  //검색 클릭 후 첫번째와 그 이후를 나누는 변수
                if (cbbType.Text == "자재 번호")  //"자재 번호"
                {
                    searchType = 0;
                }
                else if (cbbType.Text == "제조사") //"제조사"
                {
                    searchType = 1;
                }
                else if (cbbType.Text == "자재명") //"자재명"
                {
                    searchType = 2;
                }
                else if (cbbType.Text== "자재 타입")  //"자재 타입"
                {
                    searchType = 3;
                }
                isFirst = true; 
                foreach (DataGridViewRow item in dgvAllMat.Rows)
                {
                    try
                    {
                        //GridView의 모든 Rows를 돌면서 검색어가 입력 되면 해당 타입(Column)의 값이 검색어가 포함되는지 비교
                        //대소문자가 다르거나 띄어쓰기가 달라도 검색 가능
                        if (item.Cells[searchType].Value.ToString().ToLower().Replace(" ","").Contains(txtSearch.Text.ToLower().Trim().Replace(" ","")))
                        {
                            if (isFirst)
                            {
                                SearchMat(item);
                                isFirst = false;
                            }
                            else
                            {
                                var result = MessageBox.Show("계속 검색하시겠습니까?", "", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    SearchMat(item);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                }

            }
        }
    }
}
