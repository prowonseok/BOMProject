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
        private static string path = string.Empty;

        public static bool loginState = false;

        ProductsDAO productsDAO = new ProductsDAO();
        OrderDAO orderDAO = new OrderDAO();

        OrderVO orderVO;
        CustomerVO customer;

        List<ProductVO> proList; // 실시간 특성상 로드 이벤트에 두는게 좋을 것 같음
        List<OrderVO> Cart = new List<OrderVO>();
        List<OrderVO> cartOrders = new List<OrderVO>();

        FrmLogin loginForm;
        ListViewItem selectItem;

        public Form1()
        {
            InitializeComponent();
            proList = productsDAO.SelectAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            panBottom.Controls.AddRange(new Control[] { spCont, gbxBuy, gbxAS, gbxCart, gbxBuyRecord });
            spCont.Panel2.Controls.Add(gbxBuy);

            spCont.BorderStyle = BorderStyle.FixedSingle;
            // 리소스 경로 설정
            path = Application.StartupPath;
            path = path.Substring(0, path.Length - int.Parse(ConfigurationManager.AppSettings["pathConst"])) + "Resources\\";
            // 폼 디자인
            Text = "Goodee PC";
            BackColor = Color.White;
            panTop.BackColor = Color.LightGray;

            // 간단한 버튼 디자인
            SetBtnDesign(btnLogin, btnJoin, btnProducts, btnBuy, btnAS, btnCart, btnBuyRecord);

            if (!string.IsNullOrEmpty(path))
            {
                SetBtnImage(btnProducts, "computer.png");
                SetBtnImage(btnBuy, "buy.png");
                SetBtnImage(btnAS, "AS.png");
                SetBtnImage(btnCart, "cart.png");
                SetBtnImage(btnBuyRecord, "bill.png");
            }
            btnProducts.BackColor = Color.LightGray;

            PanBottomCtrlVisiFalse();
            CtrlVisiTrue(spCont);

            SetGviewCart();
            SetListView();
        }

        private void CtrlVisiTrue(params Control[] controls)
        {
            for (int i = 0; i < controls.Length; i++)
            {
                controls[i].Visible = true;
            }
        }

        private void PanBottomCtrlVisiFalse()
        {
            for (int i = 0; i < panBottom.Controls.Count; i++)
            {
                panBottom.Controls[i].Visible = false;
            }
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

                imgList.ImageSize = new Size(230, 230);
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

                Button btnMyPage = CreateBtn(btnLogin, "내 정보");
                Button btnLogOut = CreateBtn(btnJoin, "로그아웃");

                btnMyPage.Click += BtnMyPage_Click;
                btnLogOut.Click += BtnLogOut_Click;

                Label lblCusName = new Label();
                lblCusName.Width = 500;
                lblCusName.Text = loginForm.Customer.Name + "님 환영합니다.";
                lblCusName.Location = new Point(btnLogin.Location.X - (lblCusName.Text.Length + 150), 17);
                panTop.Controls.Add(lblCusName);

                customer = loginForm.Customer;
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
            new FrmMyInfo(customer).ShowDialog();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            new FrmJoin().ShowDialog();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (loginState) // 로그인 된 상태
            {
                PanBottomCtrlVisiFalse();
                gbxBuy.Dock = DockStyle.Fill;
                CtrlVisiTrue(spCont, gbxBuy);

                nuProAmount.Value = 0;
                lblSpec.Text = string.Empty;
                txtTotalPrice.Text = string.Empty;

                lblSpecTitle.Visible = false;
                txtProSpec.Visible = false;

                txtProSpec.ReadOnly = true;
                txtBuySpec.ReadOnly = true;
                txtCusID.ReadOnly = true;
                txtTotalPrice.ReadOnly = true;

                txtBuySpec.BackColor = Color.White;

                SetBtnColor(btnBuy, btnProducts, btnAS, btnCart, btnBuyRecord);
                SetBtnDesign(btnAddCart, btnBuyNow);
                SetBtnImage(btnAddCart, "cart.png");
                SetBtnImage(btnBuyNow, "buyNow.png");

                cbxBuyCusPro.Items.Clear();
                cbxBuyCusPro.Text = "선택하세요.";
                foreach (var product in proList)
                {
                    cbxBuyCusPro.Items.Add(product.Name);
                }
            }
            else MessageBox.Show("로그인 후 이용하실수 있습니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAS_Click(object sender, EventArgs e)
        {
            if (loginState) // 로그인 된 상태
            {
                PanBottomCtrlVisiFalse();
                gbxAS.Dock = DockStyle.Fill;
                CtrlVisiTrue(gbxAS);

                SetBtnColor(btnAS, btnProducts, btnBuy, btnCart, btnBuyRecord);

                txtCusID.ReadOnly = true;
                txtCusProDate.ReadOnly = true;

                txtCusID.Text = loginForm.Customer.Id;
                gViewAS.Width = panBottom.Width;
                gViewAS.BackgroundColor = Color.White;
            }
            else MessageBox.Show("로그인 후 이용하실수 있습니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            SetBtnColor(btnProducts, btnBuy, btnAS, btnCart, btnBuyRecord);
            PanBottomCtrlVisiFalse();
            CtrlVisiTrue(lblSpecTitle, spCont.Panel2.Controls["txtProSpec"]);
            OnLoad(null);
        }

        private void lstView_MouseClick(object sender, MouseEventArgs e)
        {
            selectItem = lstView.GetItemAt(e.X, e.Y); // 마우스 위치에서 아이템 클릭하면 해당 아이템 가져오기
            if (e.Button == MouseButtons.Left)
            {
                GetSpecLabel();
                lblSpecTitle.Text = "PC 구성\r\n\r\n     " + proList[selectItem.Index].Name;
            }

            if (cbxBuyCusPro.Items.Count != 0) cbxBuyCusPro.SelectedItem = cbxBuyCusPro.Items[selectItem.Index];
        }

        private void GetSpecLabel()
        {
            lblSpec.Text = string.Empty;
            for (int i = 1; i < selectItem.SubItems.Count; i++)
            {
                if (i % 2 != 0) lblSpec.Text += "* " + selectItem.SubItems[i].Text + " : ";
                else lblSpec.Text += selectItem.SubItems[i].Text + "\r\n\r\n";
            }
            txtTotalPrice.Text = string.Format("{0:c}", proList[selectItem.Index].Price * nuProAmount.Value);
            nuProAmount.Value = 1;
        }

        private void cbxBuyCusPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectItem = lstView.Items[cbxBuyCusPro.SelectedIndex];
            GetSpecLabel();
        }

        private void nuProAmount_ValueChanged(object sender, EventArgs e)
        {
            if (nuProAmount.Value <= 0)
            {
                btnAddCart.Enabled = false;
                btnBuyNow.Enabled = false;
                txtTotalPrice.Text = string.Empty;
            }
            else
            {
                btnAddCart.Enabled = true;
                btnBuyNow.Enabled = true;
                if (selectItem != null)
                {
                    txtTotalPrice.Text = string.Format("{0:c}", proList[selectItem.Index].Price * nuProAmount.Value); 
                }
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (loginState)
            {
                SetBtnColor(btnCart, btnProducts, btnBuy, btnAS, btnBuyRecord);
                PanBottomCtrlVisiFalse();
                CtrlVisiTrue(gbxCart);
                gviewCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                if (Cart.Count != 0)
                {
                    gviewCart.Columns[0].Visible = true;
                    gviewCart.DataSource = null;
                    gviewCart.DataSource = Cart;
                }
                else
                {
                    gviewCart.DataSource = null;
                    gviewCart.Columns[0].Visible = false;
                    MessageBox.Show("장바구니에 상품이 없습니다!", "장바구니", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("로그인 후 이용하실수 있습니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SetGviewCart()
        {
            gbxCart.Dock = DockStyle.Fill;
            gviewCart.BackgroundColor = Color.White;
            gviewCart.MultiSelect = false;
            DataGridViewCheckBoxColumn cbxCol = new DataGridViewCheckBoxColumn();
            cbxCol.Name = "cbx";
            cbxCol.HeaderText = "목록 선택";
            gviewCart.Columns.Add(cbxCol);
        }

        private void btnBuyRecord_Click(object sender, EventArgs e)
        {
            if (loginState)
            {
                SetBtnColor(btnBuyRecord, btnProducts, btnBuy, btnAS, btnCart);
                PanBottomCtrlVisiFalse();
                gbxBuyRecord.Dock = DockStyle.Bottom;
                gViewBuy.Height = panBottom.Height - 100;
                CtrlVisiTrue(gbxBuyRecord);
                gViewBuy.DataSource = orderDAO.SelectOrderByCusID(customer.No, 1);
            }
            else MessageBox.Show("로그인 후 이용하실수 있습니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            try
            {
                orderVO = GetOrderVo();
                orderVO.Order_OrderNo = 1;
                orderDAO.InsertSingleOrder(orderVO, customer.No);
                MessageBox.Show("구매신청 완료!", "구매하기", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBuy_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            try
            {
                Cart.Add(GetOrderVo());
                gviewCart.DataSource = Cart;
                MessageBox.Show("장바구니에 저장되었습니다!", "장바구니", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private OrderVO GetOrderVo()
        {
            OrderVO order = new OrderVO()
            {
                CusNo = customer.No,
                OrderDate = DateTime.Now,
                EA = int.Parse(nuProAmount.Value.ToString()),
                ProNo = proList[cbxBuyCusPro.SelectedIndex].No,
                Price = proList[cbxBuyCusPro.SelectedIndex].Price * int.Parse(nuProAmount.Value.ToString()),
            };

            return order;
        }

        private void btnCartBuy_Click(object sender, EventArgs e)
        {
            try
            {
                cartOrders.Clear();
                foreach (DataGridViewRow row in gviewCart.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["cbx"].Value))
                    {
                        OrderVO order = new OrderVO()
                        {
                            CusNo = int.Parse(row.Cells[9].Value.ToString()),
                            ProNo = int.Parse(row.Cells[10].Value.ToString()),
                            OrderDate = DateTime.Parse(row.Cells[4].Value.ToString()),
                            Price = int.Parse(row.Cells[5].Value.ToString()),
                            EA = int.Parse(row.Cells[6].Value.ToString()),
                            EmpNo = 1 // 랜덤함수로 직원수만큼 돌려서 배정 예정 -> 당장 샘플 1밖에 없음 /*int.Parse(row.Cells[8].Value.ToString())*/
                        };
                        cartOrders.Add(order);
                    }
                }
                orderDAO.InsertCartOrder(cartOrders, customer.No);
                MessageBox.Show("구매 신청 완료!", "장바구니", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int indexNum = 0;
                indexNum = RemoveCart(indexNum);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int RemoveCart(int indexNum)
        {
            foreach (DataGridViewRow checkRow in gviewCart.Rows)
            {
                if (Convert.ToBoolean(checkRow.Cells["cbx"].Value))
                {
                    Cart.RemoveAt(checkRow.Index - indexNum);
                    indexNum++;
                }
            }
            if (Cart.Count != 0)
            {
                gviewCart.DataSource = null;
                gviewCart.DataSource = Cart;
            }
            else
            {
                gviewCart.DataSource = null;
                gviewCart.Columns[0].Visible = false;
                MessageBox.Show("장바구니에 상품이 없습니다!", "장바구니", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return indexNum;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int indexNum = 0;
            indexNum = RemoveCart(indexNum);
        }
    }
}
