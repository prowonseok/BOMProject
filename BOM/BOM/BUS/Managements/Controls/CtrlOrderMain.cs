using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOM.DAO;

namespace BOM.BUS.Managements.Controls
{
    public partial class CtrlOrderMain : UserControl
    {
        OfferOrderDAO ood = new OfferOrderDAO();
        int orderNo;
        public CtrlOrderMain()
        {
            InitializeComponent();
        }

        private void CtrlOrderMain_Load(object sender, EventArgs e)
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

        public void btnOrder_Click(object sender, EventArgs e)
        {
            FrmOrder fod = new FrmOrder(orderNo);
            fod.ShowDialog();
        }
    }
}