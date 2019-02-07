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
