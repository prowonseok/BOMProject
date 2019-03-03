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
    public partial class FrmASDetails : Form
    {
        private DataGridViewRow dataGridViewRow;

        public FrmASDetails(DataGridViewRow dataGridViewRow)
        {
            InitializeComponent();
            this.dataGridViewRow = dataGridViewRow;
        }

        private void FrmASDetails_Load(object sender, EventArgs e)
        {
            tbASNo.Text = dataGridViewRow.Cells[0].Value.ToString();
            tbOrderNo.Text = dataGridViewRow.Cells[1].Value.ToString();
            tbCusName.Text = dataGridViewRow.Cells[2].Value.ToString();
            tbProdName.Text = dataGridViewRow.Cells[3].Value.ToString();
            tbContent.Text = dataGridViewRow.Cells[4].Value.ToString();
            tbCost.Text = dataGridViewRow.Cells[5].Value.ToString();
            tbStartDate.Text = dataGridViewRow.Cells[6].Value.ToString();
            tbEndDate.Text = dataGridViewRow.Cells[7].Value.ToString();
            tbEmployee.Text = dataGridViewRow.Cells[8].Value.ToString();
        }

        private void btnASFix_Click(object sender, EventArgs e)
        {
            FrmASProcess fas = new FrmASProcess(int.Parse(tbASNo.Text));
            fas.FormClosed += new FormClosedEventHandler(formclosedmethod);
            fas.ShowDialog();
        }

        private void formclosedmethod(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
