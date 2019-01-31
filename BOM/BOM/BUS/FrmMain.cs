using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOM.BUS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnBOM_Click(object sender, EventArgs e)
        {
            BOM.FrmBOM fbom = new BOM.FrmBOM();
            fbom.ShowDialog();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Managements.FrmManageMain fmanagemain = new Managements.FrmManageMain();
            fmanagemain.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Sales.FrmSalesMain fsalesmain = new Sales.FrmSalesMain();
            fsalesmain.ShowDialog();
        }
    }
}
