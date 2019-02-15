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
    public partial class FrmBomSearchPro : Form
    {
        DAO.BomDAO bDao;
        Products products;
        public FrmBomSearchPro()
        {
            InitializeComponent();
        }

        private void FrmBomSearchPro_Load(object sender, EventArgs e)
        {
            bDao = new DAO.BomDAO();
            dgvProInfo.DataSource = bDao.SelectPro();
            dgvProInfo.Columns.Remove("Pro_Spec");
            dgvProInfo.Columns.Remove("Pro_Img_No");
            dgvProInfo.Columns.Remove("Pro_ChangepriceDate");

            dgvProInfo.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvProInfo.Columns[0].HeaderText = "제품 번호";
            dgvProInfo.Columns[1].HeaderText = "자재 번호";
            dgvProInfo.Columns[2].HeaderText = "제품 가격";
            dgvProInfo.Columns[2].DefaultCellStyle.Format = "###,###,###";
            dgvProInfo.Columns[3].HeaderText = "제품 명";

            dgvProInfo.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProInfo.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            products = new Products();
            //0: pNo, 1:mNo, 3:pName
            products.Pro_No = Int32.Parse(dgvProInfo.SelectedRows[0].Cells[0].Value.ToString());
            products.Mat_No = Int32.Parse(dgvProInfo.SelectedRows[0].Cells[1].Value.ToString());
            products.Pro_Name = dgvProInfo.SelectedRows[0].Cells[3].Value.ToString();
            FrmBomMatEstimating fbme = (FrmBomMatEstimating)Owner;
            fbme.Products = this.products;
            fbme.CanOrAdd = true;
            this.Close();
        }
    }
}
