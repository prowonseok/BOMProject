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
        public FrmBomDetailInfo(Materials materials)
        {
            this.materials = materials;
            InitializeComponent();
            
        }

        private void FrmBomDetailInfo_Load(object sender, EventArgs e)
        {
            dgvBom.DataSource = null;
            if (!string.IsNullOrEmpty(materials.Mat_No.ToString()))//txtMatNo가 비어있으면
            {
                this.txtMatNo.Text = materials.Mat_No.ToString();
                this.txtMatName.Text = materials.Mat_Name;
                rdoExplosion_CheckedChanged(null, null); 
            }
            dgvBom.AutoResizeColumns();
            
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatNo.Text))
            {
                MessageBox.Show("품목을 선택해주세요");
            }
            else
            {

            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            FrmBomSearchMat mbsm = new FrmBomSearchMat();
            mbsm.Owner = this;
            mbsm.ShowDialog();
            if (canOrAdd)
            {
                this.txtMatNo.Text = matNo.ToString();
                this.txtMatName.Text = matName;
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
                    ColumnsTranslate();
                }
            }
        }

        private void ColumnsTranslate()
        {
            if (dgvBom.Columns.Count >= 1)
            {
                dgvBom.Columns[0].HeaderText = "자재번호";
                dgvBom.Columns[1].HeaderText = "타입 번호";
                dgvBom.Columns[2].HeaderText = "제조사";
                dgvBom.Columns[3].HeaderText = "자재 이름";
                dgvBom.Columns[4].HeaderText = "가격";
                dgvBom.Columns[5].HeaderText = "자재 레벨";
                dgvBom.Columns[6].HeaderText = "수량";
                dgvBom.Columns[7].HeaderText = "협력사 번호";
            }
        }

        private void rdoImplosion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoImplosion.Checked) //역전개시 
            {
                if (!string.IsNullOrEmpty(txtMatNo.Text))
                {
                    bDao = new DAO.BomDAO();
                    dgvBom.DataSource = bDao.SelectBom4(Int32.Parse(txtMatNo.Text), "Bom_Bom_Implosion_Procedure");
                    ColumnsTranslate();
                }
            }
        }
    }
}
