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
    public partial class FrmBomInfo : Form
    {
        public FrmBomInfo()
        {
            InitializeComponent();
        }

        private void FrmBomInfo_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "BOM 등록";
            btn.Name = "Button";
            btn.Text = "BOM 등록";
            btn.UseColumnTextForButtonValue = true;
            dgvBom.Columns.Add(btn);
        }
    }
}
