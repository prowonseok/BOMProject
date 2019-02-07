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

namespace BOM
{
    public partial class FrmBomInfo : Form
    {
        DAO.BomDAO bDao;

        public FrmBomInfo()
        {
            InitializeComponent();
        }

        private void FrmBomInfo_Load(object sender, EventArgs e)
        {
            Display(); 

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

            //컬럼 크기 자동 정렬
            dgvBom.AutoResizeColumns();

            //Int형 데이터를 가진 컬럼은 오른쪽 정렬
            dgvBom.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBom.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvBom.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvBom.Columns[0].Width = 80;

            dgvBom.Columns[0].HeaderText = "자재번호";
            dgvBom.Columns[1].HeaderText = "자재명";
            dgvBom.Columns[2].HeaderText = "자재 레벨";

        }

        private void Display()
        {
            bDao = new DAO.BomDAO();

            dgvBom.DataSource = bDao.SelectBom();
        }

        private void dgvBom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //e.RowIndex + 1 = 제품 번호, e.ColumnIndex = 컬럼 번호
            //BOM 등록일 클릭 시 
            if (e.ColumnIndex.ToString()=="3")
            {
                //Level의 값이 0일 경우
                if (dgvBom.Rows[e.RowIndex].Cells[2].Value.ToString()=="0")
                {
                    MessageBox.Show("최하위 자재는 BOM등록을 할 수 없습니다.");
                }
                else 
                {
                    FrmBomAdd fba = new FrmBomAdd(new Materials {
                        Mat_No =Int32.Parse(dgvBom.Rows[e.RowIndex].Cells[0].Value.ToString()),
                        Mat_Name =dgvBom.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        Mat_Level =Int32.Parse(dgvBom.Rows[e.RowIndex].Cells[2].Value.ToString())
                    });
                    fba.ShowDialog();
                }
                
            }//BOM 조회 클릭 시
            else if(e.ColumnIndex.ToString()=="4")
            {
                FrmBomDetailInfo fbdi = new FrmBomDetailInfo(new Materials
                {
                    Mat_No = Int32.Parse(dgvBom.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    Mat_Name = dgvBom.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Mat_Level = Int32.Parse(dgvBom.Rows[e.RowIndex].Cells[2].Value.ToString())
                });
                fbdi.ShowDialog();
            }
        }

        private void btnBomAdd_Click(object sender, EventArgs e)
        {
            FrmBomAdd fba = new FrmBomAdd();
            fba.ShowDialog();
        }

        private void btnBomInfo_Click(object sender, EventArgs e)
        {
            FrmBomDetailInfo fbdi = new FrmBomDetailInfo();
            fbdi.ShowDialog();
        }

        private void btnMatEstimating_Click(object sender, EventArgs e)
        {
            FrmBomMatEstimating fme = new FrmBomMatEstimating();
            fme.ShowDialog();
        }
    }
}
