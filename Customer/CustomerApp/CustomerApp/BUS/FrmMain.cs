using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using CustomerApp.VO;
using CustomerApp.DAO;
using System.Runtime.InteropServices;

namespace CustomerApp.BUS
{
    public partial class FrmMain : Form
    {
        public static bool loginState = false;

        private static string path = string.Empty;
        
        private ProductsDAO productsDAO = new ProductsDAO();
        private OrderDAO orderDAO = new OrderDAO();
        private CartDAO cartDAO = new CartDAO();
        private AsDAO asDAO = new AsDAO();
        
        private OrderVO orderVO;
        private CustomerVO customer;
        
        private List<ProductVO> proList;
        private List<CartVO> cartList = new List<CartVO>();
        private List<OrderVO> cartOrders = new List<OrderVO>();
        private List<OrderVO> orderRecords = new List<OrderVO>();
        private List<OrderVO> asOrderList = new List<OrderVO>();
        private List<AsVO> asList = new List<AsVO>();
        private List<OrderVO> billOrders = new List<OrderVO>();
        
        private FrmLogin loginForm;
        private ListViewItem selectItem;

        public FrmMain()
        {
            InitializeComponent();
            proList = productsDAO.SelectAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
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
            SetListView();
        }

        /// <summary>
        /// 해당 컨트롤 Visible을 True로 설정하는 Method
        /// </summary>
        /// <param name="controls">설정하고 싶은 컨트롤</param>
        private void CtrlVisiTrue(params Control[] controls)
        {
            for (int i = 0; i < controls.Length; i++)
            {
                controls[i].Visible = true;
            }
        }

        /// <summary>
        /// PanBottom 패널의 Visible을 False로 설정하는 Method
        /// </summary>
        private void PanBottomCtrlVisiFalse()
        {
            for (int i = 0; i < panBottom.Controls.Count; i++)
            {
                panBottom.Controls[i].Visible = false;
            }
        }

        /// <summary>
        /// ListView 기본 설정
        /// </summary>
        private void SetListView()
        {
            lstView.Items.Clear();
            GetProducts();
            GetSubItems();
            ListViewToolTip();
        }

        /// <summary>
        /// ListViewItem (Product)의 서브 아이템을 가져오는 Method
        /// </summary>
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

        /// <summary>
        /// ListView ToolTip 설정 Method
        /// </summary>
        private void ListViewToolTip()
        {
            lstView.ShowItemToolTips = true;
            for (int i = 0; i < lstView.Items.Count; i++)
            {
                lstView.Items[i].ToolTipText = lstView.Items[i].ImageKey + "\r\n자세히 보시려면 클릭하세요.";
            }
        }

        /// <summary>
        /// 버튼 이미지 설정 Method
        /// </summary>
        /// <param name="btn">설정하려는 버튼</param>
        /// <param name="imgPath">리소스에 저장 된 이미지 이름.형식</param>
        private void SetBtnImage(Button btn, string imgPath)
        {
            btn.Image = Image.FromFile(path + imgPath);
            btn.ImageAlign = ContentAlignment.TopCenter;
            btn.TextAlign = ContentAlignment.BottomCenter;
        }

        /// <summary>
        /// 원하는 버튼 디자인 세팅 Method
        /// </summary>
        /// <param name="btn">세팅하고 싶은 버튼</param>
        private void SetBtnDesign(params Button[] btn)
        {
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i].FlatStyle = FlatStyle.Flat;
                btn[i].FlatAppearance.BorderSize = 0;
                btn[i].TabStop = false;
            }
        }

        /// <summary>
        /// 클릭 시 버튼 색 바꾸기 Method
        /// </summary>
        /// <param name="btn">클릭되는 버튼은 0번 째 순서에 입력</param>
        private void SetBtnColor(params Button[] btn)
        {
            btn[0].BackColor = Color.LightGray;
            for (int i = 1; i < btn.Length; i++)
            {
                btn[i].BackColor = Color.White;
            }
        }

        /// <summary>
        /// 기존 버튼 자리에 새로운 버튼 생성 Method
        /// </summary>
        /// <param name="oldBtn">기존 버튼</param>
        /// <param name="txt">새로운 버튼의 텍스트</param>
        /// <returns>새로운 버튼</returns>
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

        /// <summary>
        /// 상품을 ListView에 이미지와 함께 추가하는 Method
        /// </summary>
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

        /// <summary>
        /// 상품의 스펙을 보여주는 컨트롤 세팅 Method
        /// </summary>
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

        /// <summary>
        /// 장바구니 데이터 그리드 뷰에 기본 세팅 Method
        /// </summary>
        private void SetGviewCart()
        {
            gbxCart.Dock = DockStyle.Fill;
            gviewCart.BackgroundColor = Color.White;
            gviewCart.MultiSelect = false;
        }

        /// <summary>
        /// 주문 객체를 반환하는 Method
        /// </summary>
        /// <returns>주문 객체</returns>
        private OrderVO GetOrderVo()
        {
            OrderVO order = new OrderVO()
            {
                CusNo = customer.No,
                OrderDate = DateTime.Now,
                EA = int.Parse(nuProAmount.Value.ToString()),
                ProNo = proList[cbxBuyCusPro.SelectedIndex].No,
                Price = proList[cbxBuyCusPro.SelectedIndex].Price * int.Parse(nuProAmount.Value.ToString()),
                ProName = proList[cbxBuyCusPro.SelectedIndex].Name
            };

            return order;
        }

        /// <summary>
        /// 장바구니 그리드 뷰 삭제 row 반환 Method
        /// </summary>
        /// <param name="indexNum"></param>
        /// <returns>삭제 row index</returns>
        private void RemoveCart(int indexNum)
        {
            foreach (DataGridViewRow checkRow in gviewCart.Rows)
            {
                if (Convert.ToBoolean(checkRow.Cells["cbx"].Value))
                {
                    cartList.RemoveAt(checkRow.Index - indexNum);
                    indexNum++;
                }
            }
        }

        /// <summary>
        /// 장바구니 그리드 뷰 목록 불러와서 cartList에 저장 및 디스플레이 세팅 Method
        /// </summary>
        private void GviewCartDataSource()
        {
            cartList.Clear();
            SetGviewCart();
            cartList = cartDAO.Select(customer.No);
            rdoSaveNo.Checked = false;
            rdoSaveNo.Checked = true;
        }

        private void GviewCartColSet()
        {
            if (cartList.Count != 0)
            {
                gviewCart.DataSource = null;
                gviewCart.DataSource = cartList;

                if (gviewCart.Columns.Count == 9) GetCbxCol(gviewCart, "cbx", "목록 선택");

                gviewCart.Columns.Remove("CusNo");
                gviewCart.Columns.Remove("ProNo");
                gviewCart.Columns.Remove("CartNo");

                gviewCart.Columns["CusName"].DisplayIndex = 2;
                gviewCart.Columns["ProName"].DisplayIndex = 3;

                gviewCart.Columns["CusName"].HeaderText = "고객명";
                gviewCart.Columns["ProName"].HeaderText = "상품명";
                gviewCart.Columns["SaveNo"].HeaderText = "저장번호";
                gviewCart.Columns["SaveEA"].HeaderText = "상품수량";
                gviewCart.Columns["TotalPrice"].HeaderText = "총 가격";
                gviewCart.Columns["CartDate"].HeaderText = "저장날짜";

                gviewCart.Columns["TotalPrice"].DefaultCellStyle.Format = "c";
                gviewCart.Columns["SaveEA"].DefaultCellStyle.Format = "### 개";
                gviewCart.Columns["CartDate"].DefaultCellStyle.Format = "d";

                gviewCart.Columns["CartDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gviewCart.Columns["ProName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                gviewCart.DataSource = null;
                if (gviewCart.Columns.Count != 0) gviewCart.Columns.Remove("cbx");
                MessageBox.Show("장바구니에 상품이 없습니다!", "장바구니", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 장바구니 목록 DB, 그리드 뷰에서 삭제 Method
        /// </summary>
        private void DeleteCart()
        {
            bool chkExist = false;
            foreach (DataGridViewRow checkRow in gviewCart.Rows)
            {
                if (Convert.ToBoolean(checkRow.Cells["cbx"].Value))
                {
                    chkExist = true;
                    cartDAO.SetSaveNo(customer.No, cartList[checkRow.Index].CartNo);
                    cartDAO.Delete(customer.No, cartList[checkRow.Index].CartNo);
                }
            }
            if (!chkExist) MessageBox.Show("선택 된 물품이 없습니다!", "장바구니", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                RemoveCart(0);
                GviewCartDataSource();
            }
        }

        /// <summary>
        /// 구매 내역 row 설정 Method
        /// </summary>
        private void GviewBuyRecordSet()
        {
            orderRecords.Clear();
            orderRecords = orderDAO.SelectOrderByCusID(customer.No);
            gViewBuy.BackgroundColor = Color.White;
            rdoOrderNo.Checked = false;
            rdoOrderNo.Checked = true;
        }

        private void GviewBuyColSet()
        {
            if (orderRecords.Count != 0)
            {
                gViewBuy.DataSource = null;
                gViewBuy.DataSource = orderRecords;

                gViewBuy.Columns.Remove("OrderNo");
                gViewBuy.Columns.Remove("EmpNo");
                gViewBuy.Columns.Remove("CusNo");
                gViewBuy.Columns.Remove("ProNo");

                if (gViewBuy.Columns.Count == 7) GetCbxCol(gViewBuy, "cbx", "목록 선택");

                gViewBuy.Columns["EA"].DisplayIndex = 2;

                gViewBuy.Columns["Order_OrderNo"].HeaderText = "주문번호";
                gViewBuy.Columns["ProName"].HeaderText = "상품명";
                gViewBuy.Columns["EA"].HeaderText = "상품수량";
                gViewBuy.Columns["Price"].HeaderText = "총 가격";
                gViewBuy.Columns["OrderDate"].HeaderText = "주문날짜";
                gViewBuy.Columns["OrderCom"].HeaderText = "거래현황";
                gViewBuy.Columns["EmpName"].HeaderText = "담당자";

                gViewBuy.Columns["Price"].DefaultCellStyle.Format = "c";
                gViewBuy.Columns["EA"].DefaultCellStyle.Format = "### 개";
                gViewBuy.Columns["OrderDate"].DefaultCellStyle.Format = "d";

                gViewBuy.Columns["ProName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gViewBuy.Columns["OrderDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gViewBuy.Columns["OrderCom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                gViewBuy.DataSource = null;
                if (gViewBuy.Columns.Count != 0) gViewBuy.Columns.Remove("cbx");
                MessageBox.Show("구매내역이 없습니다!", "장바구니", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// gView에 체크박스 컬럼 추가
        /// </summary>
        /// <param name="gView">그리드 뷰</param>
        /// <param name="name">컬럼명</param>
        /// <param name="headerTxt">컬럼 헤더텍스트</param>
        private void GetCbxCol(DataGridView gView, string name, string headerTxt)
        {
            DataGridViewCheckBoxColumn cbxCol = new DataGridViewCheckBoxColumn();
            cbxCol.Name = name;
            cbxCol.HeaderText = headerTxt;
            gView.Columns.Add(cbxCol);
            gView.Columns[name].DisplayIndex = 0;
        }

        /// <summary>
        /// AS 그리드 뷰 기본 세팅
        /// </summary>
        private void SetGviewAS()
        {
            gViewAS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gViewAS.ScrollBars = ScrollBars.Vertical;

            asList.Clear();
            asList = asDAO.SelectAllAS(customer.No);
            gViewAS.DataSource = null;
            gViewAS.DataSource = asList;
            GviewAScolSet();
            rdoAsDate.Checked = true;
        }

        /// <summary>
        /// AS 그리드 뷰의 컬럼 세팅
        /// </summary>
        private void GviewAScolSet()
        {
            gViewAS.Columns["CusNo"].Visible = false;
            gViewAS.Columns["ASNo"].Visible = false;
            gViewAS.Columns["EmpNo"].Visible = false;
            gViewAS.Columns["ProNo"].Visible = false;

            gViewAS.Columns["OrderNo"].HeaderText = "주문번호";
            gViewAS.Columns["ASContent"].HeaderText = "고장내용";
            gViewAS.Columns["AsPrice"].HeaderText = "A/S 가격";
            gViewAS.Columns["AsStartDate"].HeaderText = "A/S 신청날짜";
            gViewAS.Columns["AsEndDate"].HeaderText = "A/S 종료날짜";
            gViewAS.Columns["ProName"].HeaderText = "상품이름";
            gViewAS.Columns["CusName"].HeaderText = "고객이름";
            gViewAS.Columns["EmpName"].HeaderText = "담당자";

            gViewAS.Columns["AsStartDate"].DefaultCellStyle.Format = "d";
            gViewAS.Columns["AsEndDate"].DefaultCellStyle.Format = "d";
            gViewAS.Columns["AsPrice"].DefaultCellStyle.Format = "c";

            gViewAS.Columns["CusName"].DisplayIndex = 0;
            gViewAS.Columns["ProName"].DisplayIndex = 2;

            gViewAS.Columns["AsStartDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gViewAS.Columns["AsEndDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gViewAS.Columns["ProName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gViewAS.Columns["ASContent"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// AS 신청 버튼 Enable 조건에 맞게 활성, 비활성
        /// </summary>
        private void BtnSubmitEnable()
        {
            if (!string.IsNullOrEmpty(txtCusID.Text) && cbxASCusPro.SelectedItem != null && cbxOrderNo.SelectedItem != null && txtASContent.TextLength > 9) btnSubmit.Enabled = true;
            else btnSubmit.Enabled = false;
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
                asOrderList.Clear();
                asOrderList = asDAO.SelectBuyPro(customer.No);
                PanBottomCtrlVisiFalse();
                gbxAS.Dock = DockStyle.Fill;
                CtrlVisiTrue(gbxAS);
                txtASContent.MaxLength = 300;
                txtASContent.Text = string.Empty;
                lblContentSize.Text = "글자제한\r\n(" + txtASContent.TextLength + " / 300)";
                btnSubmit.Enabled = false;

                SetBtnColor(btnAS, btnProducts, btnBuy, btnCart, btnBuyRecord);

                txtCusID.ReadOnly = true;

                txtCusID.Text = loginForm.Customer.Id;
                gViewAS.Width = panBottom.Width;
                gViewAS.BackgroundColor = Color.White;

                txtCusID.Text = customer.Id;
                cbxASCusPro.Items.Clear();
                cbxOrderNo.Text = string.Empty;
                foreach (OrderVO item in asOrderList)
                {
                    cbxASCusPro.Items.Add(item.ProName);
                }
                if (cbxASCusPro.Items.Count != 0) cbxASCusPro.Text = "선택하세요";
                else cbxASCusPro.Text = "구매내역 없음";
                cbxOrderNo.Enabled = false;

                SetGviewAS();
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
                cartList = cartDAO.Select(customer.No);
                SetBtnColor(btnCart, btnProducts, btnBuy, btnAS, btnBuyRecord);
                PanBottomCtrlVisiFalse();
                CtrlVisiTrue(gbxCart);
                gviewCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                GviewCartDataSource();
            }
            else MessageBox.Show("로그인 후 이용하실수 있습니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuyRecord_Click(object sender, EventArgs e)
        {
            if (loginState)
            {
                SetBtnColor(btnBuyRecord, btnProducts, btnBuy, btnAS, btnCart);
                PanBottomCtrlVisiFalse();
                gbxBuyRecord.Dock = DockStyle.Top;
                gViewBuy.Height = panBottom.Height - 100;
                CtrlVisiTrue(gbxBuyRecord);
                GviewBuyRecordSet();
            }
            else MessageBox.Show("로그인 후 이용하실수 있습니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            try
            {
                orderVO = GetOrderVo();
                if (orderVO.EA <= productsDAO.GetProCount(orderVO.ProNo))
                {
                    orderDAO.InsertSingleOrder(orderVO, customer.No);
                    MessageBox.Show("구매신청 완료!", "구매하기", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBuy_Click(null, null);
                }
                else
                {
                    MessageBox.Show(orderVO.ProName + "의 재고가 부족합니다.", "구매하기", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                MessageBox.Show("장바구니에 저장되었습니다!", "장바구니", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CartVO cartVO = new CartVO()
                {
                    CusNo = customer.No,
                    SaveNo = cartDAO.GetSaveNo(customer.No),
                    ProNo = proList[cbxBuyCusPro.SelectedIndex].No,
                    SaveEA = int.Parse(nuProAmount.Value.ToString()),
                    TotalPrice = proList[cbxBuyCusPro.SelectedIndex].Price * int.Parse(nuProAmount.Value.ToString()),
                    CartDate = DateTime.Now
                };
                cartDAO.Insert(cartVO);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCartBuy_Click(object sender, EventArgs e)
        {
            try
            {
                bool chkExist = false;
                string enPro = string.Empty;
                cartOrders.Clear();
                foreach (DataGridViewRow row in gviewCart.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["cbx"].Value))
                    {
                        if (cartList[row.Index].SaveEA <= productsDAO.GetProCount(cartList[row.Index].ProNo))
                        {
                            chkExist = true;
                            OrderVO order = new OrderVO()
                            {
                                CusNo = cartList[row.Index].CusNo,
                                ProNo = cartList[row.Index].ProNo,
                                OrderDate = DateTime.Now,
                                Price = cartList[row.Index].TotalPrice,
                                EA = cartList[row.Index].SaveEA,
                                EmpNo = 1 // 랜덤함수로 직원수만큼 돌려서 배정 예정 -> 당장 샘플 1밖에 없음
                            };
                            cartOrders.Add(order);
                        }
                        else if (cartList[row.Index].SaveEA > productsDAO.GetProCount(cartList[row.Index].ProNo))
                        {
                            enPro += cartList[row.Index].ProName + ", ";
                        }
                    }
                }
                if (!string.IsNullOrEmpty(enPro))
                {
                    MessageBox.Show(enPro.Substring(0, enPro.Length - 2) + "의 재고가 부족합니다.", "장바구니", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var result = MessageBox.Show("선택하신 물품을 구매하시겠습니까 ? ", "장바구니", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK && chkExist)
                    {
                        orderDAO.InsertCartOrder(cartOrders, customer.No);
                        MessageBox.Show("구매 신청 완료!", "장바구니", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DeleteCart();
                    }
                    else if (result == DialogResult.Cancel) return;
                    else MessageBox.Show("선택 된 물품이 없습니다!", "장바구니", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("선택하신 물품을 삭제하시겠습니까?", "장바구니", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                DeleteCart();
            }
            else return;
        }

        private void btnBuyCancel_Click(object sender, EventArgs e)
        {
            bool chkExist = false;
            foreach (DataGridViewRow row in gViewBuy.Rows)
            {
                if (Convert.ToBoolean(row.Cells["cbx"].Value))
                {
                    if (row.Cells["OrderCom"].Value.ToString() == "거래 중")
                    {
                        chkExist = true;
                        orderDAO.CancelOrder(orderRecords[row.Index].OrderNo);
                    }
                    else
                    {
                        MessageBox.Show("거래 중인 상품만 취소 할 수 있습니다!", "구매내역", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            if (!chkExist) MessageBox.Show("선택 된 물품이 없습니다!", "구매내역", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("구매 취소 완료!", "구매내역", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GviewBuyRecordSet();
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            bool chkExist = false;
            saveFileDig.Filter = "*.xls|*.xls";
            saveFileDig.FileName = DateTime.Now.ToShortDateString() + "영수증.xls";

            billOrders.Clear();
            foreach (DataGridViewRow row in gViewBuy.Rows)
            {
                if (Convert.ToBoolean(row.Cells["cbx"].Value))
                {
                    if (row.Cells["OrderCom"].Value.ToString() == "거래 완료")
                    {
                        chkExist = true;
                        OrderVO billOrder = new OrderVO()
                        {
                            OrderDate = DateTime.Parse(row.Cells["OrderDate"].Value.ToString()),
                            ProName = row.Cells["ProName"].Value.ToString(),
                            EA = int.Parse(row.Cells["EA"].Value.ToString()),
                            Price = int.Parse(row.Cells["Price"].Value.ToString())
                        };
                        billOrders.Add(billOrder);
                    }
                    else
                    {
                        MessageBox.Show("거래 완료인 상품만 영수증을 발행할 수 있습니다!", "구매내역", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (chkExist)
            {
                var result = saveFileDig.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application(); // Excel 응용 프로그램 객체
                    if (excelApp == null) MessageBox.Show("Excel 응용 프로그램을 찾을 수 없거나, 설치되지 않았습니다.");

                    Microsoft.Office.Interop.Excel.Workbook workBook; // 통합문서 객체
                    Microsoft.Office.Interop.Excel.Worksheet workSheet; // 워크시트 객체

                    object missing = System.Reflection.Missing.Value;

                    workBook = excelApp.Workbooks.Open(path + "Excelbill.xlsx", missing, false, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);
                    workSheet = workBook.Worksheets.Item[1];


                    int k = 0;
                    for (int i = 9; i < billOrders.Count + 9; i++)
                    {
                        workSheet.Cells[i, "A"] = billOrders[k].OrderDate.ToString("yyyy-MM-dd");
                        workSheet.Cells[i, "C"] = billOrders[k].ProName.ToString();
                        workSheet.Cells[i, "H"] = billOrders[k].EA.ToString();
                        workSheet.Cells[i, "J"] = billOrders[k].Price.ToString();
                        k++;
                    }
                    // ...
                    try
                    {
                        workBook.SaveAs(saveFileDig.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, null, null, null, null, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlLocalSessionChanges, missing, missing, missing, missing);
                    }
                    catch (Exception)
                    {
                        return;
                    }

                    excelApp.Quit(); // 엑셀 프로그램 종료

                    Marshal.ReleaseComObject(workSheet);
                    Marshal.ReleaseComObject(workBook);
                    Marshal.ReleaseComObject(excelApp);

                    MessageBox.Show("영수증이 바탕화면에 저장되었습니다!", "구매내역", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBuyRecord_Click(null, null);
                }
                else return;
            }
            else MessageBox.Show("선택 된 물품이 없습니다!", "구매내역", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtASContent_TextChanged(object sender, EventArgs e)
        {
            lblContentSize.Text = "글자제한\r\n(" + txtASContent.TextLength + " / 300자)";
            BtnSubmitEnable();
        }

        private void cbxASCusPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxASCusPro.Items.Count != 0)
            {
                cbxOrderNo.Items.Clear();
                foreach (int item in asDAO.SelectBuyOrderNo(customer.No, asOrderList[cbxASCusPro.SelectedIndex].ProNo))
                {
                    cbxOrderNo.Items.Add(item + " 번");
                }
                cbxOrderNo.Enabled = true;
            }
            else cbxOrderNo.Enabled = false;
            cbxOrderNo.Text = "선택하세요";
            BtnSubmitEnable();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int orderNo = int.Parse(cbxOrderNo.SelectedItem.ToString().Substring(0, cbxOrderNo.SelectedItem.ToString().IndexOf(' ')));
            AsVO asVO = new AsVO()
            {
                CusNo = customer.No,
                OrderNo = orderNo,
                ProNo = asOrderList[cbxASCusPro.SelectedIndex].ProNo,
                AsContent = txtASContent.Text,
                AsStartDate = DateTime.Now,
                EmpNo = 1,
            };
            asDAO.Insert(asVO);
            MessageBox.Show("A/S 신청이 완료되었습니다.", "A/S", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAS_Click(null, null);
        }

        private void cbxOrderNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnSubmitEnable();
        }

        private void txtCusID_TextChanged(object sender, EventArgs e)
        {
            BtnSubmitEnable();
        }

        private void rdoOrderNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOrderNo.Checked)
            {
                orderRecords.Sort((a, b) => a.Order_OrderNo > b.Order_OrderNo ? 1 : -1);
                gViewBuy.DataSource = null;
                gViewBuy.DataSource = orderRecords;
                GviewBuyColSet();
            }   
        }

        private void rdoDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDate.Checked)
            {
                orderRecords.Sort((a, b) => a.OrderDate < b.OrderDate ? 1 : -1);
                gViewBuy.DataSource = null;
                gViewBuy.DataSource = orderRecords;
                GviewBuyColSet();
            }
        }

        private void rdoCom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCom.Checked)
            {
                orderRecords.Sort((a, b) => a.OrderCom.CompareTo(b.OrderCom));
                gViewBuy.DataSource = null;
                gViewBuy.DataSource = orderRecords;
                GviewBuyColSet();
            }
        }

        private void rdoAsDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAsOrderNo.Checked)
            {
                asList.Sort((a, b) => a.OrderNo > b.OrderNo ? 1 : -1);
                gViewAS.DataSource = null;
                gViewAS.DataSource = asList;
                GviewAScolSet();
            }
        }

        private void rdoAsOrderNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDate.Checked)
            {
                asList.Sort((a, b) => a.AsStartDate > b.AsStartDate ? 1 : -1);
                gViewAS.DataSource = null;
                gViewAS.DataSource = asList;
                GviewAScolSet();
            }
        }

        private void rdoSaveNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSaveNo.Checked)
            {
                cartList.Sort((a, b) => a.SaveNo > b.SaveNo ? 1 : -1);
                gviewCart.DataSource = null;
                gviewCart.DataSource = cartList;
                GviewCartColSet();
            }
        }

        private void rdoCartPriceDown_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCartPriceDown.Checked)
            {
                cartList.Sort((a, b) => a.TotalPrice > b.TotalPrice ? 1 : -1);
                gviewCart.DataSource = null;
                gviewCart.DataSource = cartList;
                GviewCartColSet();
            }
        }

        private void rdoCartPriceUp_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCartPriceUp.Checked)
            {
                cartList.Sort((a, b) => a.TotalPrice < b.TotalPrice ? 1 : -1);
                gviewCart.DataSource = null;
                gviewCart.DataSource = cartList;
                GviewCartColSet();
            }
        }
    }
}