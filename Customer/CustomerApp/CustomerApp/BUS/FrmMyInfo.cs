using System;
using System.Windows.Forms;
using CustomerApp.VO;

namespace CustomerApp.BUS
{
    public partial class FrmMyInfo : Form
    {
        private CustomerVO customer;
        private FrmJoin joinForm;

        public FrmMyInfo(CustomerVO customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void FrmMyPage_Load(object sender, EventArgs e)
        {
            Text = "Goodee PC 내 정보";
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CenterToScreen();
            MaximizeBox = false;

            txtAddr.ReadOnly = true;
            txtEmailID.ReadOnly = true;
            txtID.ReadOnly = true;
            txtName.ReadOnly = true;
            txtPhone.ReadOnly = true;

            txtAddr.Text = customer.Addr;
            txtEmailID.Text = customer.Email;
            txtID.Text = customer.Id;
            txtName.Text = customer.Name;
            txtPhone.Text = customer.Phone;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            joinForm = new FrmJoin(customer);
            var result = joinForm.ShowDialog();
            if (result == DialogResult.Cancel && joinForm.Customer != null)
            {
                customer = joinForm.Customer;
                OnLoad(null);
            }
            else return;
        }
    }
}
