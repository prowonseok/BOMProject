using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOM
{
    public partial class FrmBOM : Form
    {
        public FrmBOM()
        {
            InitializeComponent();
        }

        private void btnBom_Click(object sender, EventArgs e)
        {
            FrmBomAdd fba = new FrmBomAdd();
            fba.ShowDialog();
        }

        private void btnBomInfo_Click(object sender, EventArgs e)
        {
            FrmBomInfo fbi = new FrmBomInfo();
            fbi.ShowDialog();
        }
    }
}
