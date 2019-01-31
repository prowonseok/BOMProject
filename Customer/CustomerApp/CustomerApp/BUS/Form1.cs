using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerApp.BUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FrmLogin loginForm = new FrmLogin(); // 로그인 폼
        private FrmJoin JoinForm = new FrmJoin(); // 회원가입 폼

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen(); // 모니터 중앙

            // 리소스 경로 설정
            string path = Application.StartupPath;
            path = path.Substring(0, path.Length - 9) + "Resources\\"; // 상수 처리 할 것 (App.config -> AppSetting에서)

            // 폼 디자인
            Text = "Goodee PC";
            BackColor = Color.White;
            panTop.BackColor = Color.LightGray;

            // 간단한 버튼 디자인
            btnProducts.TabStop = false;
            btnBuy.TabStop = false;
            btnAS.TabStop = false;

            btnLogin.FlatStyle = FlatStyle.Flat;
            btnJoin.FlatStyle = FlatStyle.Flat;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnAS.FlatStyle = FlatStyle.Flat;

            btnLogin.FlatAppearance.BorderSize = 0;
            btnJoin.FlatAppearance.BorderSize = 0;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnBuy.FlatAppearance.BorderSize = 0;
            btnAS.FlatAppearance.BorderSize = 0;

            btnProducts.Image = Image.FromFile(path + "computer.png");
            btnProducts.ImageAlign = ContentAlignment.TopCenter;
            btnProducts.TextAlign = ContentAlignment.BottomCenter;

            btnBuy.Image = Image.FromFile(path + "buy.png");
            btnBuy.ImageAlign = ContentAlignment.TopCenter;
            btnBuy.TextAlign = ContentAlignment.BottomCenter;

            btnAS.Image = Image.FromFile(path + "AS.png");
            btnAS.ImageAlign = ContentAlignment.TopCenter;
            btnAS.TextAlign = ContentAlignment.BottomCenter;

            btnProducts.BackColor = Color.LightGray;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginForm.ShowDialog();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            JoinForm.ShowDialog();
        }
    }
}
