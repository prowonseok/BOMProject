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
    public partial class FrmOrderMain : Form
    {
        OfferOrderDAO ood = new OfferOrderDAO();
        public FrmOrderMain()
        {
            InitializeComponent();
        }

        private void FrmOrderMain_Load(object sender, EventArgs e)
        {
            dgvOrderList.DataSource = ood.SelectOrder();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
        }
    }
}
