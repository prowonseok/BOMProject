using BOM.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOM.BUS.Managements
{
    public partial class FrmTypeAdd : Form
    {
        MatDAO mDAO = new MatDAO();
        public FrmTypeAdd()
        {
            InitializeComponent();
        }

        private void FrmTypeAdd_Load(object sender, EventArgs e)
        {
            tbTypeNo.ImeMode = ImeMode.Alpha;
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            try
            {
                mDAO.InsertMatType(tbTypeNo.Text, tbTypeCate.Text);
                MessageBox.Show("등록 성공");
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("다음의 사유로 등록 실패\n" + exc.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbTypeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (int.TryParse(e.ToString(), out int num) && char.GetUnicodeCategory(Convert.ToChar(e))!=System.Globalization.UnicodeCategory.OtherLetter)
            {
                e.Handled = true;
            }
            else
            {
                
            }
        }
    }
}
