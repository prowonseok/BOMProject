using CustomerApp.DAO;
using CustomerApp.VO;
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

namespace CustomerApp.BUS
{
    public partial class FrmJoin : Form
    {
        private FrmAddr addrForm;
        CustomersDAO cusDAO = new CustomersDAO();
        List<string> cusIDList = new List<string>();
        private string engPattern = "^[0-9A-Za-z]{6,25}$";
        private string pwPattern = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,12}$";
        private string emailPattern = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9]){1,}?";
        private string[] emailSite = new string[] { "naver.com", "daum.net", "nate.com", "gmail.com", "hotmail.com", "yahoo.com", "korea.com", "netian.com", "직접 입력" };

        private bool boolName = false;
        private bool boolId = false;
        private bool boolPw = false;
        private bool boolChkPw = false;
        private bool boolEmail = false;
        private bool boolPhone = false;

        private bool existID = false;

        public FrmJoin()
        {
            InitializeComponent();
        }

        private void FrmJoin_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            Text = "Goodee PC 회원가입";

            btnSubmit.Enabled = false;
            btnChkID.Enabled = false;

            txtPW.UseSystemPasswordChar = true;
            txtChkPW.UseSystemPasswordChar = true;

            txtAddr.ReadOnly = true;
            txtEmailSite.ReadOnly = true;

            cbxEmail.Items.AddRange(emailSite);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }


        private void btnAddr_Click(object sender, EventArgs e)
        {
            addrForm = new FrmAddr();
            addrForm.ShowDialog();
            txtAddr.Text = addrForm.ChoiceAddr;
            txtAddrDetail.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CustomerVO customer = new CustomerVO()
            {
                ID = txtID.Text,
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Addr = txtAddr.Text + " " + txtAddrDetail.Text,
                Pw = txtPW.Text,
                Email = txtEmailID.Text + lblAt.Text + txtEmailSite.Text
            };
            cusDAO.InsertCus(customer);
            MessageBox.Show("회원가입이 정상적으로 완료되었습니다.\r\nGoodee PC 회원이 되신걸 축하합니다!", "회원 가입 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Dispose();
            Close();
        }

        private void cbxEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEmail.SelectedIndex != 8)
            {
                txtEmailSite.Text = cbxEmail.SelectedItem.ToString();
                txtEmailSite.ReadOnly = true;
            }
            else
            {
                txtEmailSite.Text = string.Empty;
                txtEmailSite.ReadOnly = false;
            }
        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {
            // 비밀번호 유효성 검사
            if (string.IsNullOrEmpty(txtPW.Text))
            {
                lblPWState.Text = string.Empty;
            }
            else if (!Regex.IsMatch(txtPW.Text, pwPattern, RegexOptions.CultureInvariant))
            {
                lblPWState.Text = "비밀번호 사용 불가능";
                lblPWState.ForeColor = Color.Red;
                boolPw = false;
            }
            else
            {
                lblPWState.Text = "비밀번호 사용 가능";
                lblPWState.ForeColor = Color.Blue;
                boolPw = true;
            }

            if (txtPW.Text != txtChkPW.Text)
            {
                lblChkPWState.Text = string.Empty;
                txtChkPW.Text = string.Empty;
            }

            GetSubmitEnable();
        }

        private void txtChkPW_TextChanged(object sender, EventArgs e)
        {
            // 비밀번호 확인 유효성 검사
            if (string.IsNullOrEmpty(txtChkPW.Text))
            {
                lblChkPWState.Text = string.Empty;
            }
            else if (txtPW.Text != txtChkPW.Text)
            {
                lblChkPWState.Text = "비밀번호와 일치하지 않음";
                lblChkPWState.ForeColor = Color.Red;
                boolChkPw = false;
            }
            else
            {
                lblChkPWState.Text = "비밀번호와 일치함";
                lblChkPWState.ForeColor = Color.Blue;
                boolChkPw = true;
            }

            GetSubmitEnable();
        }

        private void txtEmailSite_TextChanged(object sender, EventArgs e)
        {
            // 이메일 유효성 검사
            GetEmailState();
            GetSubmitEnable();
        }

        private void GetSubmitEnable()
        {
            if (boolName && boolId && boolPw && boolChkPw && boolEmail && boolPhone && !string.IsNullOrEmpty(txtAddr.Text)) btnSubmit.Enabled = true;
            else btnSubmit.Enabled = false;
        }

        private void txtAddr_TextChanged(object sender, EventArgs e)
        {
            GetSubmitEnable();
        }

        private void txtPhone_MaskChanged(object sender, EventArgs e)
        {
            GetSubmitEnable();
        }

        private void txtPW_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                SpaceMsg(txtPW);
            }
        }

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                SpaceMsg(txtID);
            }
        }

        private void SpaceMsg(TextBox textBox)
        {
            MessageBox.Show("공백은 사용 불가능합니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                lblPhoneState.Text = string.Empty;
                boolPhone = false;
            }
            else if (txtPhone.Text.Length != 13)
            {
                lblPhoneState.Text = "올바르지 않은 핸드폰 번호";
                lblPhoneState.ForeColor = Color.Red;
                boolPhone = false;
            }
            else
            {
                lblPhoneState.Text = "올바른 핸드폰 번호";
                lblPhoneState.ForeColor = Color.Blue;
                boolPhone = true;
            }
            GetSubmitEnable();
        }

        private void GetEmailState()
        {
            string email = txtEmailID.Text + lblAt.Text + txtEmailSite.Text;
            if (string.IsNullOrEmpty(txtEmailID.Text) || string.IsNullOrEmpty(txtEmailSite.Text) || !Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase))
            {
                lblEmailState.Text = "올바르지 않은 E-mail 주소";
                lblEmailState.ForeColor = Color.Red;
                boolEmail = false;
            }
            else
            {
                lblEmailState.Text = "올바른 E-mail 주소";
                lblEmailState.ForeColor = Color.Blue;
                boolEmail = true;
            }
        }

        private void GetIDState()
        {
            cusIDList.Clear();
            cusIDList = cusDAO.SelectAllCusID();
            foreach (var cusID in cusIDList)
            {
                if (cusID == txtID.Text)
                {
                    existID = true;
                    break;
                }
            }

            if (existID) MessageBox.Show("ID 사용 불가", "ID 중복 검사", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("ID 사용 가능", "ID 중복 검사", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblIDState.ForeColor = Color.Blue;
                lblIDState.Text = "사용 가능한 ID입니다.";
                boolId = true;
            }
        }

        private void txtEmailID_TextChanged(object sender, EventArgs e)
        {
            GetEmailState();
        }

        private void btnChkID_Click(object sender, EventArgs e)
        {
            GetIDState();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 1 && txtName.Text.Length < 11)
            {
                boolName = true;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtID.Text, engPattern))
            {
                lblIDState.ForeColor = Color.Red;
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    lblIDState.Text = "사용하실 ID를 입력해주세요.";
                    btnChkID.Enabled = false;
                }
                else
                {
                    lblIDState.Text = "올바르지 않은 ID입니다.";
                    btnChkID.Enabled = false;
                }
            }
            else
            {
                lblIDState.ForeColor = Color.Red;
                lblIDState.Text = "ID 중복 검사를 해주세요.";
                btnChkID.Enabled = true;
            }
        }
    }
}
