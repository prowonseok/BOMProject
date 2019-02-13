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
        private int matNo;
        private string matName;
        private bool canOrAdd; //Cancel인지 Add인지

        public int MatNo { get => matNo; set => matNo = value; }
        public string MatName { get => matName; set => matName = value; }
        public bool CanOrAdd { get => canOrAdd; set => canOrAdd = value; }

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
                if (!string.IsNullOrEmpty(txtMatNo.Text))
                {
                    bDao = new DAO.BomDAO();
                    dgvBom.DataSource = bDao.SelectBom4(Int32.Parse(txtMatNo.Text), "Bom_Bom_Explosion_Procedure");
                    DisplayGridview();
                }
            }
        }

        private void DisplayGridview()
        {
            if (dgvBom.Columns.Count >= 1)
            {
                dgvBom.Columns.RemoveAt(1);
                dgvBom.Columns.RemoveAt(1);
                dgvBom.Columns.RemoveAt(4);
                dgvBom.Columns.RemoveAt(4);
                dgvBom.Columns[0].HeaderText = "자재번호";
                dgvBom.Columns[1].HeaderText = "자재 이름";
                dgvBom.Columns[2].HeaderText = "가격(원)";
                dgvBom.Columns[2].DefaultCellStyle.Format = "###,###,###";
                dgvBom.Columns[3].HeaderText = "자재 레벨";
            }
            
            dgvBom.AutoResizeColumns();
            dgvBom.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvBom.Columns[3].HeaderText = "자재 레벨";

            dgvBom.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBom.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBom.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void rdoImplosion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoImplosion.Checked) //역전개시 
            {
                if (!string.IsNullOrEmpty(txtMatNo.Text))
                {
                    bDao = new DAO.BomDAO();
                    dgvBom.DataSource = bDao.SelectBom4(Int32.Parse(txtMatNo.Text), "Bom_Bom_Implosion_Procedure");
                    DisplayGridview();
                }
            }
        }
    }
}
