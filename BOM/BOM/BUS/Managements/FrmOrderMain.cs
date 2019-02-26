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
        int orderNo;
        public FrmOrderMain()
        {
            InitializeComponent();
        }

        private void FrmOrderMain_Load(object sender, EventArgs e)
        {
            DataTable dt = ood.SelectOrderList();
            dgvMain.DataSource = dt;
            try
            {
                orderNo = int.Parse(dt.Rows[dt.Rows.Count - 1]["주문번호"].ToString());
            }
            catch (Exception)
            {
                orderNo = 0;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FrmOrder fod = new FrmOrder(orderNo);
            fod.ShowDialog();
        }
    }
}
