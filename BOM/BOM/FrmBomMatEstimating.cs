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
    public partial class FrmBomMatEstimating : Form
    {
        public FrmBomMatEstimating()
        {
            InitializeComponent();
        }

        private void btnSearchPro_Click(object sender, EventArgs e)
        {
            FrmBomSearchPro fbsp = new FrmBomSearchPro();
            fbsp.ShowDialog();
        }
    }
}
