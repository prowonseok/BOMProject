using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOM.VO;

namespace BOM.BUS.BOM
{
    public partial class FrmBomInfo : Form
    {
        DAO.BomDAO bDao;
        DataTable dt;
        DataTable dtClone; //DataTable dt에 Materials Table을 입력 받아 복사하기 위한 DataTable
        /// <summary>
        /// 생성자
        /// </summary>
        public FrmBomInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 폼이 Load 될 경우 실행됨
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBomInfo_Load(object sender, EventArgs e)
        {
            Display();
        }

        /// <summary>
        /// GridView의 데이터소스를 불러옴
        /// </summary>
        private void Display()
        {
            bDao = new DAO.BomDAO();

            //GridView의 데이터소스를 불러옴
            dt = bDao.SelectBom();
            dgvBom.DataSource = CloneDataTable(dt, dtClone);

            //GridView의 버튼컬럼 추가
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn.HeaderText = "BOM 등록";
            btn.Name = "Button";
            btn.Text = "BOM 등록";
            btn.UseColumnTextForButtonValue = true;
            dgvBom.Columns.Add(btn);

            btn2.HeaderText = "BOM 조회";
            btn2.Name = "조회";
            btn2.Text = "조회";
            btn2.UseColumnTextForButtonValue = true;
            dgvBom.Columns.Add(btn2);

            //필요 없는 컬럼 삭제
            dgvBom.Columns.Remove("Mat_Type_No");
            dgvBom.Columns.Remove("Mat_Manufactur");
            dgvBom.Columns.Remove("Mat_Cost");
            dgvBom.Columns.Remove("Mat_Ea");
            dgvBom.Columns.Remove("Off_No");

            //Int형 데이터를 가진 컬럼은 오른쪽 정렬
            dgvBom.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBom.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //컬럼별 크기 설정
            dgvBom.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvBom.Columns[0].Width = 80;

            //컬럼명 설정
            dgvBom.Columns[0].HeaderText = "자재 번호";
            dgvBom.Columns[1].HeaderText = "자재명";
            dgvBom.Columns[2].HeaderText = "자재 단계";
        }

        /// <summary>
        /// DataTable Clone 및 Mat_Level 형변환을 위한 메서드
        /// </summary>
        /// <param name="dt">기존 DataTable</param>
        /// <param name="dtClone">형변환 시킬 DataTable</param>
        internal DataTable CloneDataTable(DataTable dt, DataTable dtClone)
        {
            dtClone = dt.Clone();  //dt의 구조를 dtClone에 Clone()해줌

            dtClone.Columns["Mat_Level"].DataType = typeof(String); //Mat_Level 컬럼의 타입을 변경(값이 있을 경우 type 변경이 되지 않음)

            foreach (DataRow item in dt.Rows)
            {
                dtClone.ImportRow(item);
            }

            foreach (DataRow item in dtClone.Rows)
            {
                switch (item["Mat_Level"].ToString())
                {
                    case "0":
                        item["Mat_Level"] = "원재료";
                        break;
                    case "1":
                        item["Mat_Level"] = "반제품";
                        break;
                    case "2":
                        item["Mat_Level"] = "완제품";
                        break;
                    default:
                        break;
                }
            }
            return dtClone;
        }

        /// <summary>
        /// 그리드뷰의 버튼을 클릭 할 경우 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">클릭한 버튼의 위치</param>
        private void dgvBom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int levelNum = 0;
            //매개변수 값을 위한 Level값 변경
            switch (dgvBom.Rows[e.RowIndex].Cells[2].Value.ToString())
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
            //BOM등록 클릭 시 
            if (e.ColumnIndex.ToString() == "3")
            {
                //Level의 값이 0일 경우
                if (dgvBom.Rows[e.RowIndex].Cells[2].Value.ToString() == "원재료")
                {
                    MessageBox.Show("원재료는 부모자재로 BOM등록을 할 수 없습니다.");
                }
                else
                {
                    //BOM등록 페이지에 선택한 항목들의 값을 매개변수로 보냄
                    FrmBomAdd fba = new FrmBomAdd(new MaterialsVO

                    {
                        Mat_No = Int32.Parse(dgvBom.Rows[e.RowIndex].Cells[0].Value.ToString()),
                        Mat_Name = dgvBom.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        Mat_Level = levelNum
                    });
                    fba.ShowDialog();
                }

            }//BOM조회 클릭 시
            else if (e.ColumnIndex.ToString() == "4")
            {
                //BOM조회 페이지에 선택한 항목들의 값을 매개변수로 보냄
                FrmBomDetailInfo fbdi = new FrmBomDetailInfo(new MaterialsVO
                {
                    Mat_No = Int32.Parse(dgvBom.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    Mat_Name = dgvBom.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Mat_Level = levelNum
                });
                fbdi.ShowDialog();
            }
        }

        /// <summary>
        /// BOM등록 페이지로 이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBomAdd_Click(object sender, EventArgs e)
        {
            FrmBomAdd fba = new FrmBomAdd();
            fba.ShowDialog();
        }

        /// <summary>
        /// BOM조회 페이지로 이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBomInfo_Click(object sender, EventArgs e)
        {
            FrmBomDetailInfo fbdi = new FrmBomDetailInfo();
            fbdi.ShowDialog();
        }

        /// <summary>
        /// 소요량 예측 페이지로 이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMatEstimating_Click(object sender, EventArgs e)
        {
            FrmBomMatEstimating fme = new FrmBomMatEstimating();
            fme.ShowDialog();
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
            }
            //검색어를 입력하지 않았을 경우
            else if (string.IsNullOrEmpty(txtSearch.Text)) {
                MessageBox.Show("검색어를 입력해주세요");
            }
            else
            { //입력이 올바른 경우
                int searchType = 0;  //그리드뷰의 column 번호를 저장하는 변수
                bool isFirst = true; //검색 클릭 후 첫번째와 그 이후를 나누는 변수

                if (cbbType.Text == "자재명")
                {
                    searchType = 1;
                }
                else if (cbbType.Text == "자재 번호")
                {
                    searchType = 0;
                }
                else if (cbbType.Text == "자재 단계")
                {
                    searchType = 2;
                }
                foreach (DataGridViewRow item in dgvBom.Rows)
                {
                    //DB의 모든 Rows를 돌면서 검색어가 입력 되면 해당 타입(Column)의 값이 검색어가 포함되는지 비교
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

            }
        }

        /// <summary>
        /// 검색 시 선택 항목을 최상단으로 올려주는 메서드
        /// </summary>
        /// <param name="item">그리드뷰의 선택 항목</param>
        private void SearchMat(DataGridViewRow item)
        {
            dgvBom.FirstDisplayedScrollingRowIndex = item.Index;
            item.Selected = true;
        }

        /// <summary>
        /// 생산 예측 페이지로 이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProEstimating_Click(object sender, EventArgs e)
        {
            FrmBomProEstimating fbpe = new FrmBomProEstimating();
            fbpe.ShowDialog();
        }
        
    }
}
