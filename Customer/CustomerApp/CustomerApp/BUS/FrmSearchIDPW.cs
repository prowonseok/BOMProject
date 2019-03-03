using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using CustomerApp.VO;

namespace CustomerApp.BUS
{
    public partial class FrmSearchIDPW : Form
    {
        private double timeCount = 180;
        private DateTime time = new DateTime();

        private CustomerVO customer;
        private List<CustomerVO> cusList;
        private Random rand;
        private string certiNum;
        private string txt;

        public FrmSearchIDPW(List<CustomerVO> cusList, string txt)
        {
            InitializeComponent();
            this.cusList = cusList;
            this.txt = txt;
        }

        private void FrmSearchID_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            Text = "Goodee PC " + txt;
            btnSearchIDPW.Text = txt;
            btnSearchIDPW.AutoSize = true;
            btnSearchIDPW.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearchIDPW.Enabled = false;
            txtCertiNum.ReadOnly = true;
            timer.Interval = 1000;
            txtCertiNum.MaxLength = 6;
        }

        private void GetBtnEnable()
        {
            if (!string.IsNullOrEmpty(txtName.Text) && txtPhone.Text.Length == 13) btnSubmit.Enabled = true;
            else btnSubmit.Enabled = false;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            GetBtnEnable();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            GetBtnEnable();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SendEmail();
        }

        private void btnSubmit_EnabledChanged(object sender, EventArgs e)
        {
            rand = new Random();
            certiNum = rand.Next(100000, 999999).ToString();

            btnSubmit.Text = "인증메일 전송";
        }

        private void SendEmail()
        {
            MailAddress fromAddr = new MailAddress("indichi@naver.com", "Goodee PC", Encoding.UTF8);
            MailAddress toAddr = null;
            customer = GetCus();
            if (customer != null)
            {
                toAddr = new MailAddress(customer.Email, customer.Name, Encoding.UTF8);
                timer.Enabled = true;
                timer.Start();
                btnSubmit.Text = "다시발송";
                lblState.Text = "인증번호 6자리가 메일로 발송되었습니다.";
                txtCertiNum.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("등록되지 않은 회원입니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Text = string.Empty;
                txtPhone.Text = string.Empty;
                txtName.Focus();
                return;
            }

            SmtpClient smtp = new SmtpClient("smtp.naver.com", 587);
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential("indichi", "wjdwlsdn2048");

            MailMessage msg = new MailMessage(fromAddr, toAddr);
            msg.Subject = "Goodee PC 회원 아이디 찾기 인증번호";
            msg.Body = "Goodee PC 회원 아이디 찾기 인증번호입니다.\r\n인증 번호 : " + certiNum;
            msg.BodyEncoding = Encoding.UTF8;
            msg.SubjectEncoding = Encoding.UTF8;

            smtp.Send(msg);
        }

        private CustomerVO GetCus()
        {
            foreach (var customer in cusList)
            {
                if (txtName.Text == customer.Name && txtPhone.Text == customer.Phone) return customer;
            }
            return null;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeCount > 0)
            {
                timeCount--;
                lblTimer.Text = time.AddSeconds(timeCount).ToString("mm:ss");
            }
            else
            {
                timer.Stop();
                timer.Enabled = false;
                lblTimer.Text = "시간 초과\r\n메일을 다시 전송해주세요.";
                txtCertiNum.Text = string.Empty;
                txtCertiNum.ReadOnly = true;
                btnSearchIDPW.Enabled = false;
                lblTimer.ForeColor = Color.Red;
            }
        }

        private void txtCertiNum_TextChanged(object sender, EventArgs e)
        {
            if (txtCertiNum.TextLength == 6)
            {
                btnSearchIDPW.Enabled = true;
            }
            else btnSearchIDPW.Enabled = false;
        }

        private void btnSearchIDPW_Click(object sender, EventArgs e)
        {
            if (txtCertiNum.Text == certiNum)
            {
                if (txt == "아이디 찾기")
                {
                    MessageBox.Show("회원님의 아이디는 " + customer.Id + " 입니다.", "아이디 찾기", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else if(txt == "패스워드 찾기")
                {
                    MessageBox.Show("회원님의 비밀번호는 " + customer.Pw + " 입니다.", "아이디 찾기", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
            }
            else
            {
                MessageBox.Show("올바르지 않은 인증번호입니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCertiNum.Text = string.Empty;
                txtCertiNum.Focus();
            }
        }
    }
}
