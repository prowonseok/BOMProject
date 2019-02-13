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
    public partial class FrmBomAllMatInfo : Form
    {
        bool isFirst=true;
        DAO.BomDAO bDao;
        int mat_Level=9999;//mat_Level의 값이 없을 때
        int mat_No;
        public FrmBomAllMatInfo(int mat_Level, int mat_No):this()
        {
            this.mat_Level = mat_Level;
            this.mat_No = mat_No;
        }
        public FrmBomAllMatInfo()
        {
            InitializeComponent();
        }

        private void FrmBomAllMatInfo_Load(object sender, EventArgs e)
        {
            if (mat_Level==9999)//모품목을 찾을 때
            {
                //모품목은 Level 0값은 뜨지 않도록 설정
                bDao = new DAO.BomDAO();
                dgvAllMat.DataSource = bDao.SelectBom2();
                DisplayGridview();

            }
            else //자품목을 찾을 때
            {
                //자품목은 모품목보다 Level값이 같거나 작은 값만 뜨도록 설정, 같은 품목은 안뜨도록
                bDao = new DAO.BomDAO();
                dgvAllMat.DataSource = bDao.SelectBom3(mat_Level, mat_No);
                DisplayGridview();
            }
        }

        private void DisplayGridview()
        {
            dgvAllMat.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAllMat.Columns.RemoveAt(7);
            dgvAllMat.Columns.RemoveAt(6);
            dgvAllMat.Columns.RemoveAt(4);
            dgvAllMat.Columns.RemoveAt(2);
            dgvAllMat.Columns.RemoveAt(1);

            dgvAllMat.Columns[0].HeaderText = "자재 번호";
            dgvAllMat.Columns[1].HeaderText = "자재명";
            dgvAllMat.Columns[2].HeaderText = "자재 레벨";

            dgvAllMat.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAllMat.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmBomAdd fba = (FrmBomAdd)Owner;
            fba.MatNo = Int32.Parse(dgvAllMat.SelectedRows[0].Cells[0].Value.ToString());      //품목 번호
            fba.MatName = dgvAllMat.SelectedRows[0].Cells[1].Value.ToString();                 //품목 명
            fba.MatLevel = Int32.Parse(dgvAllMat.SelectedRows[0].Cells[2].Value.ToString());   //품목 레벨
            fba.CanOrAdd = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmBomAdd fba = (FrmBomAdd)Owner;
            fba.CanOrAdd = false;
            this.Close();
        }
        private void SearchMat(DataGridViewRow item)
        {
            dgvAllMat.FirstDisplayedScrollingRowIndex = item.Index;
            item.Selected = true;
        }
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
                foreach (DataGridViewRow item in dgvAllMat.Rows)
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

            }
        }
    }
}
