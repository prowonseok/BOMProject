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
    public partial class FrmBomSearchMat : Form
    {
        bool isFirst =true;
        DAO.BomDAO bDao;

        public FrmBomSearchMat()
        {
            InitializeComponent();
        }

        private void FrmBomSearchMat_Load(object sender, EventArgs e)
        {
            bDao = new DAO.BomDAO();
            dgvInfo.DataSource = bDao.SelectBom();
            DisplayGridview();

        }

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmBomDetailInfo fbdi = (FrmBomDetailInfo)Owner;
            fbdi.MatNo = Int32.Parse(dgvInfo.SelectedRows[0].Cells[0].Value.ToString());      //품목 번호
            fbdi.MatName = dgvInfo.SelectedRows[0].Cells[1].Value.ToString();                 //품목 명
            fbdi.CanOrAdd = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmBomDetailInfo fba = (FrmBomDetailInfo)Owner;
            fba.CanOrAdd = false;
            this.Close();
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

            }
        }
        private void SearchMat(DataGridViewRow item)
        {
            dgvInfo.FirstDisplayedScrollingRowIndex = item.Index;
            item.Selected = true;
        }
    }
}
