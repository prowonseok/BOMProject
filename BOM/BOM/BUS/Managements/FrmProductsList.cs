using BOM.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOM.BUS.Managements
{
    public partial class FrmProductsList : Form
    {
        ProductsDAO pdao = new ProductsDAO();

        public FrmProductsList()
        {
            InitializeComponent();
        }

        private void btnToProducts_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProductsList_Load(object sender, EventArgs e)
        {
            dgvProductsList.DataSource = pdao.SelectProduct();
            dgvProductsList.AllowUserToAddRows = false;
        }

        private void dgvProductsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmProDetails fpd = new FrmProDetails(dgvProductsList.SelectedRows[0]);
            fpd.ShowDialog();
        }
    }
}
