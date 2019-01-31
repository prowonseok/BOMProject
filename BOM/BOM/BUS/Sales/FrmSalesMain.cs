using BOM.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOM.BUS.Sales
{
    public partial class FrmSalesMain : Form
    {
        public FrmSalesMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            SalesInquiry si = new SalesInquiry();
            si.Show();
        }

        private void btnChingePrice_Click(object sender, EventArgs e)
        {
            ChaingePrice cp = new ChaingePrice();
            cp.Show();
        }
    }
}
