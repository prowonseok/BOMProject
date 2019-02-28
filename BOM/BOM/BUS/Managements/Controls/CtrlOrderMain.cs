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

        public void CtrlOrderMain_Load(object sender, EventArgs e)
        {
            DgvBuilder();
        }

        private void DgvBuilder()
        {
            DataTable dt = ood.SelectOrderList();
            dgvMain.DataSource = null;
            dgvMain.DataSource = dt;
            dgvMain.AllowUserToAddRows = false;
            try
            {
                orderNo = int.Parse(dt.Rows[dt.Rows.Count - 1]["주문번호"].ToString());
            }
            catch (Exception)
            {
                orderNo = 0;
            }
            foreach (var item in Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.Button")
                {
                    ((Button)item).BackColor = Color.Silver;
                    ((Button)item).ForeColor = Color.White;
                }
            }
            dgvMain.Font = new Font("맑은고딕", 9, FontStyle.Bold);
        }

        public void btnOrder_Click(object sender, EventArgs e)
        {
            FrmOrder fod = new FrmOrder(orderNo);
            fod.FormClosed += new FormClosedEventHandler(formclosedmethod);
            fod.ShowDialog();
        }

        private void formclosedmethod(object sender, FormClosedEventArgs e)
        {
            DgvBuilder();
        }
    }
}