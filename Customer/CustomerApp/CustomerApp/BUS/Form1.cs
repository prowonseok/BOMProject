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
        string path = string.Empty;
        
        public static bool loginState = false;
        ProductsDAO productsDAO = new ProductsDAO();
        List<ProductVO> proList; // 실시간 특성상 로드 이벤트에 두는게 좋을 것 같음
        FrmLogin loginForm;

        public Form1()
        {
            InitializeComponent();
            proList = productsDAO.SelectAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            // 리소스 경로 설정
            path = Application.StartupPath;
            path = path.Substring(0, path.Length - int.Parse(ConfigurationManager.AppSettings["pathConst"])) + "Resources\\";
            
            // 폼 디자인
            Text = "Goodee PC";
            BackColor = Color.White;
            panTop.BackColor = Color.LightGray;

            // 간단한 버튼 디자인
            SetBtnDesign(btnLogin, btnJoin, btnProducts, btnBuy, btnAS);

            if (!string.IsNullOrEmpty(path))
            {
                SetBtnImage(btnProducts, "computer.png");
                SetBtnImage(btnBuy, "buy.png");
                SetBtnImage(btnAS, "AS.png"); 
            }

            btnProducts.BackColor = Color.LightGray;
            
            SetListView();
        }

        private void SetListView()
        {
            lstView.Items.Clear();
            GetProducts();
            GetSubItems();
            ListViewToolTip();
        }

        private void GetSubItems()
        {
            for (int i = 0; i < lstView.Items.Count; i++)
            {
                ListViewItem.ListViewSubItem[] items = new ListViewItem.ListViewSubItem[proList[i].MatList.Count];
                for (int k = 0; k < proList[i].MatList.Count; k++)
                {
                    items[k] = new ListViewItem.ListViewSubItem(lstView.Items[i], proList[i].MatList[k]);
                }
                if (items != null) lstView.Items[i].SubItems.AddRange(items);
            }
        }

        private void ListViewToolTip()
        {
            lstView.ShowItemToolTips = true;
            for (int i = 0; i < lstView.Items.Count; i++)
            {
                lstView.Items[i].ToolTipText = lstView.Items[i].ImageKey + "\r\n자세히 보시려면 클릭하세요.";
            }
        }

        private void SetBtnImage(Button btn, string imgPath)
        {
            
            btn.Image = Image.FromFile(path + imgPath);
            btn.ImageAlign = ContentAlignment.TopCenter;
            btn.TextAlign = ContentAlignment.BottomCenter;
        }

        private void SetBtnDesign(params Button[] btn)
        {
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i].FlatStyle = FlatStyle.Flat;
                btn[i].FlatAppearance.BorderSize = 0;
                btn[i].TabStop = false;
            }
        }

        private void SetBtnColor(params Button[] btn)
        {
            btn[0].BackColor = Color.LightGray;
            for (int i = 1; i < btn.Length; i++)
            {
                btn[i].BackColor = Color.White; 
            }
        }

        private Button CreateBtn(Button oldBtn, string txt)
        {
            Button newBtn = new Button();
            newBtn.Location = oldBtn.Location;
            newBtn.FlatStyle = FlatStyle.Flat;
            newBtn.FlatAppearance.BorderSize = 0;
            newBtn.Visible = true;
            newBtn.Text = txt;

            panTop.Controls.Add(newBtn);
            return newBtn;
        }

        private void GetProducts()
        {
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
            loginForm = new FrmLogin();
            loginForm.ShowDialog();

            if (loginForm.CusIDExist && loginForm.CusPWExist)
            {
                btnLogin.Visible = false;
                btnJoin.Visible = false;

                Button btnMyPage = CreateBtn(btnLogin, "마이페이지");
                Button btnLogOut = CreateBtn(btnJoin, "로그아웃");

                btnMyPage.Click += BtnMyPage_Click;
                btnLogOut.Click += BtnLogOut_Click;

                Label lblCusName = new Label();
                lblCusName.Width = 500;
                lblCusName.Text = loginForm.Customer.Name + "님 환영합니다.";
                lblCusName.Location = new Point(btnLogin.Location.X - (lblCusName.Text.Length + 150), 17);                
                panTop.Controls.Add(lblCusName);

                loginState = true;
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("로그아웃 하시면 프로그램이 종료됩니다. \r\n로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.Cancel) Application.Exit();
            else return;
        }

        private void BtnMyPage_Click(object sender, EventArgs e)
        {
            new FrmMyPage(loginForm.Customer).ShowDialog();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            new FrmJoin().ShowDialog();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (loginState) // 로그인 된 상태
            {
                lstView.Visible = false;
                SetBtnColor(btnBuy, btnProducts, btnAS);
            }
            else
            {
                MessageBox.Show("로그인 후 이용하실수 있습니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAS_Click(object sender, EventArgs e)
        {
            if (loginState) // 로그인 된 상태
            {
                lstView.Visible = false;
                SetBtnColor(btnAS, btnProducts, btnBuy);
            }
            else
            {
                MessageBox.Show("로그인 후 이용하실수 있습니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            SetBtnColor(btnProducts, btnBuy, btnAS);
            lstView.Visible = true;
            OnLoad(null);
        }

        private void lstView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblTest.Text = string.Empty;
                ListViewItem selectItem = lstView.GetItemAt(e.X, e.Y); // 마우스 위치에서 아이템 클릭하면 해당 아이템 가져오기
                for (int i = 1; i < selectItem.SubItems.Count; i++)
                {
                    lblTest.Text += selectItem.SubItems[i].Text + "\r\n";
                }
            }
        }
    }
}
