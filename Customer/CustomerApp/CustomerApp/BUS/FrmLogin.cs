using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerApp.DAO;
using CustomerApp.VO;

namespace CustomerApp.BUS
{
    public partial class FrmLogin : Form
    {
        DialogResult result;
        List<CustomerVO> cusList;

        private CustomerVO customer;

        public CustomerVO Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        private bool cusIDExist;

        public bool CusIDExist
        {
            get { return cusIDExist; }
            set { cusIDExist = value; }
        }

        private bool cusPWExist;

        public bool CusPWExist
        {
            get { return cusPWExist; }
            set { cusPWExist = value; }
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            Text = "Goodee PC 로그인";

            txtPW.UseSystemPasswordChar = true;

            var customerDAO = new CustomersDAO();
            cusList = customerDAO.SelectAll();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            new FrmJoin().ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cusIDExist = false;
            cusPWExist = false;
            
            foreach (var customer in cusList)
            {
                if (customer.Id == txtID.Text)
                {
                    cusIDExist = true;
                    if (customer.Pw == txtPW.Text)
                    {
                        cusPWExist = true;
                        this.customer = customer;
                        Close();
                        break;
                    }
                }
            }

            if (!cusIDExist)
            {
                result = MessageBox.Show("등록되지 않은 아이디입니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Text = string.Empty;
                txtPW.Text = string.Empty;
                txtID.Focus();
            }
            else if (cusIDExist && !cusPWExist)
            {
                result = MessageBox.Show("비밀번호를 잘못 입력하셨습니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPW.Text = string.Empty;
                txtPW.Focus();
            }
        }

        private void txtPW_KeyUp(object sender, KeyEventArgs e)
        {
            LoginEnterKey(e);
        }

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            LoginEnterKey(e);
        }

        private void LoginEnterKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (result == DialogResult.OK)
                {
                    result = DialogResult.No;
                    return;
                }
                else btnLogin_Click(null, null);
            }
        }

        private void btnFindID_Click(object sender, EventArgs e)
        {
            new FrmSearchIDPW(cusList, btnFindID.Text).ShowDialog();
        }

        private void btnFindPW_Click(object sender, EventArgs e)
        {
            new FrmSearchIDPW(cusList, btnFindPW.Text).ShowDialog();
        }
    }
}
