using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOM
{
    public partial class FrmPasswordSetting : Form
    {
        public FrmPasswordSetting()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (tbPrevPassword.Text == ConfigurationManager.AppSettings["appPassword"])
            {
                if (tbNewPassword.Text == tbNewPasswordChk.Text)
                {
                    config.AppSettings.Settings["appPassword"].Value = tbNewPassword.Text;
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    MessageBox.Show("변경 완료");
                    Close();
                }
                else
                {
                    MessageBox.Show("새 비밀 번호가 서로 일치하지 않습니다", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("기존 비밀번호가 일치하지 않습니다", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
