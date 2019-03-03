using BOM.DAO;
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
    public partial class FrmASConfirmList : Form
    {
        ASDAO asdao = new ASDAO();
        DataTable dt;
        public FrmASConfirmList()
        {
            InitializeComponent();
        }

        private void FrmASConfirmList_Load(object sender, EventArgs e)
        {
            dt = asdao.ASDetailsSelect();
            dgvASDetailsList.DataSource = dt;
            dgvASDetailsList.Columns[2].Width = 256;

            dgvASDetailsList.Font = new Font("맑은고딕", 9, FontStyle.Bold);

            dgvASDetailsList.AllowUserToAddRows = false;
        }
    }
}
