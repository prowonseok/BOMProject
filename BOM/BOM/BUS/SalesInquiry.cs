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
    public partial class SalesInquiry : Form
    {
        public SalesInquiry()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtMember.Visible = false;
            comboProduct.Visible = false;
            if (rdoDate.Checked == true)
            {
                dtp1.Visible = dtp2.Visible = lbl1.Visible = true;
            }
            else
            {
                dtp1.Visible = dtp2.Visible = lbl1.Visible = false;
            }            
        }

        private void rdoMember_CheckedChanged(object sender, EventArgs e)
        {
            dtp1.Visible = dtp2.Visible = lbl1.Visible = false;
            comboProduct.Visible = false;
            if (rdoMember.Checked == true)
            {
                txtMember.Visible = true;
            }
            else
            {
                txtMember.Visible = false;
            }
        }

        private void rdoProduct_CheckedChanged(object sender, EventArgs e)
        {
            txtMember.Visible = false;
            dtp1.Visible = dtp2.Visible = lbl1.Visible = false;
            if (rdoProduct.Checked == true)
            {
                comboProduct.Visible = true;
            }
            else
            {
                comboProduct.Visible = false;
            }
        }
    }
}
