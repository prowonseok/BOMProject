using BOM.BUS.Managements;
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
        Test t;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnBOM_Click(object sender, EventArgs e)
        {
            t = new Test();
            panel1.Controls.Add(t);

            //FrmBomInfo fbi = new FrmBomInfo();
            //fbi.ShowDialog();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            FrmManageMain fmanagemain = new FrmManageMain();
            fmanagemain.ShowDialog();
        }
    }
}
