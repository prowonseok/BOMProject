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
    public partial class FrmBomDetailInfo : Form
    {
        DAO.BomDAO bDao;
        private int updateNum;
        private int matNo;
        private string matName;
        private bool canOrAdd; //Cancel인지 Add인지

        public int MatNo { get => matNo; set => matNo = value; }
        public string MatName { get => matName; set => matName = value; }
        public bool CanOrAdd { get => canOrAdd; set => canOrAdd = value; }
        public int UpdateNum { get => updateNum; set => updateNum = value; }

        private Materials materials;

        public FrmBomDetailInfo() {
            InitializeComponent();
        }
        public FrmBomDetailInfo(Materials materials):this()
        {
            this.materials =materials;
        }

        private void FrmBomDetailInfo_Load(object sender, EventArgs e)
        {
            dgvBom.DataSource = null;
            try
            {
                if (!string.IsNullOrEmpty(materials.Mat_No.ToString()))//materials.Mat_No가 비어있지 않으면
                {
                    this.txtMatNo.Text = materials.Mat_No.ToString();
                    this.txtMatName.Text = materials.Mat_Name;
                }
            }
            catch (NullReferenceException)
            {
            }
            dgvBom.AutoResizeColumns();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmBomSearchMat mbsm = new FrmBomSearchMat();
            mbsm.Owner = this;
            mbsm.ShowDialog();
            if (canOrAdd)
            {
                this.txtMatNo.Text = matNo.ToString();
                this.txtMatName.Text = matName.ToString();
            }
            dgvBom.DataSource = null;
        }

        private void rdoExplosion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoExplosion.Checked) //정전개시 
            {
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                if (!string.IsNullOrEmpty(txtMatNo.Text))
                {
                    bDao = new DAO.BomDAO();
                    dgvBom.DataSource = bDao.SelectBom4(Int32.Parse(txtMatNo.Text), "Bom_Bom_Explosion_Procedure");
                    DisplayGridview(true);
                }
            }
        }

        private void rdoImplosion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoImplosion.Checked) //역전개시 
            {
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                if (!string.IsNullOrEmpty(txtMatNo.Text))
                {
                    bDao = new DAO.BomDAO();
                    dgvBom.DataSource = bDao.SelectBom4(Int32.Parse(txtMatNo.Text), "Bom_Bom_Implosion_Procedure");
                    DisplayGridview(false);
                }
            }
        }
        private void DisplayGridview(bool type)
        {
            if (type)
            {   //정전개시
                if (dgvBom.Columns.Count >= 1)
                {
                    dgvBom.Columns[0].HeaderText = "자재번호";
                    dgvBom.Columns[1].HeaderText = "자재명";
                    dgvBom.Columns[2].HeaderText = "가격(원)";
                    dgvBom.Columns[2].DefaultCellStyle.Format = "###,###,###";
                    dgvBom.Columns[3].HeaderText = "자재 레벨";
                    dgvBom.Columns[4].HeaderText = "자재 개수";

                    dgvBom.AutoResizeColumns();

                    dgvBom.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvBom.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvBom.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvBom.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvBom.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                //역전개시
                if (dgvBom.Columns.Count >= 1)
                {
                    dgvBom.Columns.RemoveAt(7);
                    dgvBom.Columns.RemoveAt(6);
                    dgvBom.Columns.RemoveAt(2);
                    dgvBom.Columns.RemoveAt(1);


                    dgvBom.Columns[0].HeaderText = "자재번호";
                    dgvBom.Columns[1].HeaderText = "자재명";
                    dgvBom.Columns[2].HeaderText = "가격(원)";
                    dgvBom.Columns[2].DefaultCellStyle.Format = "###,###,###";
                    dgvBom.Columns[3].HeaderText = "자재 레벨";
                    dgvBom.AutoResizeColumns();

                    dgvBom.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvBom.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvBom.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dgvBom.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dgvBom.SelectedRows[0].Cells[1].Value.ToString();
                FrmBomUpdate fbu = new FrmBomUpdate(Int32.Parse(txtMatNo.Text), 
                    new Materials {
                    Mat_No = Int32.Parse(dgvBom.SelectedRows[0].Cells[0].Value.ToString()),
                    Mat_Name= dgvBom.SelectedRows[0].Cells[1].Value.ToString()
                }, Int32.Parse(dgvBom.SelectedRows[0].Cells[4].Value.ToString()));
                fbu.Owner = this;
                fbu.ShowDialog();

                rdoExplosion_CheckedChanged(null,null);
            }
            catch (Exception)
            {
                MessageBox.Show("수정 할 데이터가 지정되지 않았습니다.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dgvBom.SelectedRows[0].Cells[1].Value.ToString();
                var result = MessageBox.Show("정말 삭제하시겠습니까? ", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bDao = new DAO.BomDAO();
                    if (bDao.DeleteBom(Int32.Parse(txtMatNo.Text), Int32.Parse(dgvBom.SelectedRows[0].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("삭제되었습니다.");
                        rdoExplosion_CheckedChanged(null, null);
                    }
                    else
                    {
                        MessageBox.Show("삭제 실패 하였습니다.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("삭제할 데이터가 지정되지 않았습니다.");
            }

        }
    }
}
