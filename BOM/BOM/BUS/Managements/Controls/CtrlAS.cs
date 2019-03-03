using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOM.VO;
using BOM.DAO;

namespace BOM.BUS.Managements
{
    public partial class CtrlAS : UserControl
    {
        ASDAO asdao = new ASDAO();
        DataTable dt;
        public CtrlAS()
        {
            InitializeComponent();
        }

        private void CtrlAS_Load(object sender, EventArgs e)
        {
            DgvBuilder();
        }

        private void DgvBuilder()
        {
            dt = asdao.SelectAS();
            dgvASList.DataSource = dt;
            dgvASList.Font = new Font("맑은고딕", 9, FontStyle.Bold);
            dgvASList.AllowUserToAddRows = false;
        }

        private void dgvASList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmASDetails fad = new FrmASDetails(dgvASList.SelectedRows[0]);
            fad.FormClosed += new FormClosedEventHandler(formclosedmethod);
            fad.ShowDialog();
            asdao.SetASDate(int.Parse(dgvASList.SelectedRows[0].Cells[0].Value.ToString()));

        }

        private void formclosedmethod(object sender, FormClosedEventArgs e)
        {
            DgvBuilder();
        }

        private void btnASList_Click(object sender, EventArgs e)
        {
            FrmASConfirmList facl = new FrmASConfirmList();
            facl.ShowDialog();
        }
    }
}