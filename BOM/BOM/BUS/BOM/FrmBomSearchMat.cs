using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOM.BUS.BOM;
using BOM.VO;

namespace BOM
{
    /// <summary>
    /// BOM조회에서 품목찾기시 뜨는 Form
    /// </summary>
    public partial class FrmBomSearchMat : Form
    {
        bool isFirst =true;
        DAO.BomDAO bDao;
        DataTable dt;
        DataTable dtClone;
        FrmBomInfoControl fbi;

        /// <summary>
        /// 생성자
        /// </summary>
        public FrmBomSearchMat()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form이 Load될 때 발생하는 이벤트,
        /// Materials Table 모든 데이터를 그리드뷰에 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBomSearchMat_Load(object sender, EventArgs e)
        {
            bDao = new DAO.BomDAO();
            fbi = new FrmBomInfoControl();
            dt = bDao.SelectBom();
            dgvInfo.DataSource = fbi.CloneDataTable(dt, dtClone);
            DisplayGridview();
            dgvInfo.Font= new Font("맑은고딕", 9);
        }

        /// <summary>
        /// 그리드뷰 설정 메서드
        /// </summary>
        private void DisplayGridview()
        {
            dgvInfo.Columns.RemoveAt(6);
            dgvInfo.Columns.RemoveAt(1);
            dgvInfo.Columns.RemoveAt(1);
            dgvInfo.Columns.RemoveAt(4);
            dgvInfo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvInfo.Columns[0].HeaderText = "자재 번호";
            dgvInfo.Columns[1].HeaderText = "자재명";
            dgvInfo.Columns[2].HeaderText = "가격(원)";
            dgvInfo.Columns[2].DefaultCellStyle.Format = "###,###,###";
            dgvInfo.Columns[3].HeaderText = "자재 레벨";

            dgvInfo.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvInfo.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvInfo.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        /// <summary>
        /// 등록 버튼 클릭 이벤트,
        /// BOM조회 Form으로 등록할 품목에 대한 정보와 등록인지 취소인지 여부를 나타내는 bool타입 변수 CanOrAdd를 전송
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmBomDetailInfo fbdi = (FrmBomDetailInfo)Owner;
            fbdi.MatNo = Int32.Parse(dgvInfo.SelectedRows[0].Cells[0].Value.ToString());      //품목 번호
            fbdi.MatName = dgvInfo.SelectedRows[0].Cells[1].Value.ToString();                 //품목 명
            fbdi.CanOrAdd = true;
            this.Close();
        }

        /// <summary>
        /// 취소 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmBomDetailInfo fba = (FrmBomDetailInfo)Owner;
            fba.CanOrAdd = false;
            this.Close();
        }

        /// <summary>
        /// 검색 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbType.Text))
            {
                MessageBox.Show("검색 타입을 지정해주세요");
            }
            else
            {
                int searchType = 0;
                if (cbbType.Text == "자재명")
                {
                    searchType = 1;
                }
                else if (cbbType.Text == "자재 번호")
                {
                    searchType = 0;
                }
                else if (cbbType.Text == "자재 타입")
                {
                    searchType = 2;
                }
                isFirst = true;
                foreach (DataGridViewRow item in dgvInfo.Rows)
                {
                    if (item.Cells[searchType].Value.ToString().Contains(txtSearch.Text))
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
                MessageBox.Show("검색결과가 없습니다.");

            }
        }

        /// <summary>
        /// 검색 시 선택 항목을 최상단으로 올려주는 메서드
        /// </summary>
        /// <param name="item"></param>
        private void SearchMat(DataGridViewRow item)
        {
            dgvInfo.FirstDisplayedScrollingRowIndex = item.Index;
            item.Selected = true;
        }
    }
}
