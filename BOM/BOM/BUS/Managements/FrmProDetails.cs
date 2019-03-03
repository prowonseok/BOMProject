using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOM.BUS.Managements
{
    public partial class FrmProDetails : Form
    {
        private DataGridViewRow dataGridViewRow;

        public FrmProDetails(DataGridViewRow dataGridViewRow)
        {
            InitializeComponent();
            this.dataGridViewRow = dataGridViewRow;
        }

        private void FrmProDetails_Load(object sender, EventArgs e)
        {
            tbProNo.Text = dataGridViewRow.Cells[0].Value.ToString();
            tbMatNo.Text = dataGridViewRow.Cells[1].Value.ToString();
            tbPrice.Text = dataGridViewRow.Cells[2].Value.ToString();
            tbName.Text = dataGridViewRow.Cells[3].Value.ToString();
            tbSpec.Text = dataGridViewRow.Cells[4].Value.ToString();
            tbChangeDate.Text = dataGridViewRow.Cells[6].Value.ToString();

            MemoryStream ms = new MemoryStream((byte[])dataGridViewRow.Cells[5].Value);
            Image img = Image.FromStream(ms);
            pbImage.Image = img;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}