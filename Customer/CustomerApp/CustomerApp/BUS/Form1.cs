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
using CustomerApp.VO;
using CustomerApp.DAO;

namespace CustomerApp.BUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen(); // 모니터 중앙

            // 리소스 경로 설정
            string path = Application.StartupPath;
            path = path.Substring(0, path.Length - int.Parse(ConfigurationManager.AppSettings["pathConst"])) + "Resources\\";

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
            GetProducts();
        }

        private void GetProducts()
        {
            var productsDAO = new ProductsDAO();
            List<ProductVO> proList = productsDAO.SelectAllPro();
            lstView.View = View.LargeIcon;

            ImageList imgList = new ImageList();
            lstView.LargeImageList = imgList;

            for (int i = 0; i < proList.Count; i++)
            {
                string proName = proList[i].Name;

                imgList.ImageSize = new Size(256, 256);
                imgList.ColorDepth = ColorDepth.Depth32Bit;
                imgList.Images.Add(proName, proList[i].Image);
                var li = new ListViewItem(proName + "\r\n " + string.Format("{0:c}", proList[i].Price));
                li.ImageKey = proName;
                lstView.Items.Add(li);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin loginForm = new FrmLogin();
            loginForm.ShowDialog();

            if (loginForm.CusIDExist && loginForm.CusPWExist)
            {
                btnLogin.Visible = false;
                btnJoin.Visible = false;

                var btnMyPage = new Button();
                var btnLogOut = new Button();
                var lblCusName = new Label();

                lblCusName.Width = 500;
                lblCusName.Text = loginForm.Customer.Name + "님 환영합니다.";
                lblCusName.Location = new Point(btnLogin.Location.X - (lblCusName.Text.Length + 150), 17);

                btnMyPage.Location = btnLogin.Location;
                btnMyPage.FlatStyle = FlatStyle.Flat;
                btnMyPage.FlatAppearance.BorderSize = 0;
                btnMyPage.Visible = true;
                btnMyPage.Text = "마이페이지";
                btnMyPage.Click += BtnMyPage_Click;

                btnLogOut.Location = btnJoin.Location;
                btnLogOut.FlatStyle = FlatStyle.Flat;
                btnLogOut.FlatAppearance.BorderSize = 0;
                btnLogOut.Visible = true;
                btnLogOut.Text = "로그아웃";
                btnLogOut.Click += BtnLogOut_Click;

                panTop.Controls.Add(btnMyPage);
                panTop.Controls.Add(btnLogOut);
                panTop.Controls.Add(lblCusName);
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            // 리소스 해제 해야함
            //new Form1().Show();
            //Close();
            //Dispose(true);
            //GC.ReRegisterForFinalize(this);
        }

        private void BtnMyPage_Click(object sender, EventArgs e)
        {
            new FrmMyPage().ShowDialog();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            new FrmJoin().ShowDialog();
        }
    }
}
