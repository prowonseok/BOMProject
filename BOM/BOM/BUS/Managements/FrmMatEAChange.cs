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
    public partial class FrmMatEAChange : Form
    {
        private int matNo;
        private MatDAO mdao = new MatDAO();
        
        public FrmMatEAChange(int matNo)
        {
            InitializeComponent();
            this.matNo = matNo;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            mdao.MatEAUpdate(matNo, int.Parse(nudMatEA.Value.ToString()));
            Close();
        }
    }
}
