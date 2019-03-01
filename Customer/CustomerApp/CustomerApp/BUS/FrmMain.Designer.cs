namespace CustomerApp.BUS
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnAS = new System.Windows.Forms.Button();
            this.panTop = new System.Windows.Forms.Panel();
            this.lblLog = new System.Windows.Forms.Label();
            this.panBottom = new System.Windows.Forms.Panel();
            this.spCont = new System.Windows.Forms.SplitContainer();
            this.gbxBuyRecord = new System.Windows.Forms.GroupBox();
            this.gbxSort = new System.Windows.Forms.GroupBox();
            this.rdoCom = new System.Windows.Forms.RadioButton();
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.rdoOrderNo = new System.Windows.Forms.RadioButton();
            this.btnBuyCancel = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.gViewBuy = new System.Windows.Forms.DataGridView();
            this.gbxCart = new System.Windows.Forms.GroupBox();
            this.gbxCartSort = new System.Windows.Forms.GroupBox();
            this.rdoCartPriceDown = new System.Windows.Forms.RadioButton();
            this.rdoCartPriceUp = new System.Windows.Forms.RadioButton();
            this.rdoSaveNo = new System.Windows.Forms.RadioButton();
            this.btnCartBuy = new System.Windows.Forms.Button();
            this.gviewCart = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxBuy = new System.Windows.Forms.GroupBox();
            this.lblBuyProSpec = new System.Windows.Forms.Label();
            this.txtBuySpec = new System.Windows.Forms.TextBox();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nuProAmount = new System.Windows.Forms.NumericUpDown();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxBuyCusPro = new System.Windows.Forms.ComboBox();
            this.btnBuyNow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstView = new System.Windows.Forms.ListView();
            this.lblSpecTitle = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.txtProSpec = new System.Windows.Forms.RichTextBox();
            this.gbxAS = new System.Windows.Forms.GroupBox();
            this.gbxAsSort = new System.Windows.Forms.GroupBox();
            this.rdoAsOrderNo = new System.Windows.Forms.RadioButton();
            this.rdoAsDate = new System.Windows.Forms.RadioButton();
            this.lblCondition = new System.Windows.Forms.Label();
            this.cbxOrderNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContentSize = new System.Windows.Forms.Label();
            this.lblASApply = new System.Windows.Forms.Label();
            this.lblASRecord = new System.Windows.Forms.Label();
            this.gViewAS = new System.Windows.Forms.DataGridView();
            this.txtASContent = new System.Windows.Forms.TextBox();
            this.cbxASCusPro = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCusPro = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.lblASContent = new System.Windows.Forms.Label();
            this.lblCusID = new System.Windows.Forms.Label();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnBuyRecord = new System.Windows.Forms.Button();
            this.saveFileDig = new System.Windows.Forms.SaveFileDialog();
            this.panTop.SuspendLayout();
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spCont)).BeginInit();
            this.spCont.Panel1.SuspendLayout();
            this.spCont.Panel2.SuspendLayout();
            this.spCont.SuspendLayout();
            this.gbxBuyRecord.SuspendLayout();
            this.gbxSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gViewBuy)).BeginInit();
            this.gbxCart.SuspendLayout();
            this.gbxCartSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gviewCart)).BeginInit();
            this.gbxBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuProAmount)).BeginInit();
            this.gbxAS.SuspendLayout();
            this.gbxAsSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gViewAS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(1062, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(1156, 12);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 23);
            this.btnJoin.TabIndex = 1;
            this.btnJoin.Text = "회원가입";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 29);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Goodee PC";
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(12, 50);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(65, 73);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "상품보기";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(105, 50);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(65, 73);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "구매하기";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnAS
            // 
            this.btnAS.Location = new System.Drawing.Point(198, 50);
            this.btnAS.Name = "btnAS";
            this.btnAS.Size = new System.Drawing.Size(65, 73);
            this.btnAS.TabIndex = 2;
            this.btnAS.Text = "A/S 문의";
            this.btnAS.UseVisualStyleBackColor = true;
            this.btnAS.Click += new System.EventHandler(this.btnAS_Click);
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.lblLog);
            this.panTop.Controls.Add(this.lblTitle);
            this.panTop.Controls.Add(this.btnLogin);
            this.panTop.Controls.Add(this.btnJoin);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1244, 44);
            this.panTop.TabIndex = 3;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLog.Location = new System.Drawing.Point(1140, 13);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(13, 21);
            this.lblLog.TabIndex = 3;
            this.lblLog.Text = "l";
            // 
            // panBottom
            // 
            this.panBottom.Controls.Add(this.spCont);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 129);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(1244, 569);
            this.panBottom.TabIndex = 4;
            // 
            // spCont
            // 
            this.spCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spCont.IsSplitterFixed = true;
            this.spCont.Location = new System.Drawing.Point(0, 0);
            this.spCont.Name = "spCont";
            // 
            // spCont.Panel1
            // 
            this.spCont.Panel1.Controls.Add(this.gbxAS);
            this.spCont.Panel1.Controls.Add(this.gbxBuyRecord);
            this.spCont.Panel1.Controls.Add(this.gbxCart);
            this.spCont.Panel1.Controls.Add(this.gbxBuy);
            this.spCont.Panel1.Controls.Add(this.lstView);
            // 
            // spCont.Panel2
            // 
            this.spCont.Panel2.Controls.Add(this.lblSpecTitle);
            this.spCont.Panel2.Controls.Add(this.lblSpec);
            this.spCont.Panel2.Controls.Add(this.txtProSpec);
            this.spCont.Size = new System.Drawing.Size(1244, 569);
            this.spCont.SplitterDistance = 875;
            this.spCont.TabIndex = 0;
            // 
            // gbxBuyRecord
            // 
            this.gbxBuyRecord.Controls.Add(this.gbxSort);
            this.gbxBuyRecord.Controls.Add(this.btnBuyCancel);
            this.gbxBuyRecord.Controls.Add(this.btnBill);
            this.gbxBuyRecord.Controls.Add(this.gViewBuy);
            this.gbxBuyRecord.Location = new System.Drawing.Point(5, 373);
            this.gbxBuyRecord.Name = "gbxBuyRecord";
            this.gbxBuyRecord.Size = new System.Drawing.Size(1241, 597);
            this.gbxBuyRecord.TabIndex = 16;
            this.gbxBuyRecord.TabStop = false;
            // 
            // gbxSort
            // 
            this.gbxSort.Controls.Add(this.rdoCom);
            this.gbxSort.Controls.Add(this.rdoDate);
            this.gbxSort.Controls.Add(this.rdoOrderNo);
            this.gbxSort.Location = new System.Drawing.Point(22, 498);
            this.gbxSort.Name = "gbxSort";
            this.gbxSort.Size = new System.Drawing.Size(293, 54);
            this.gbxSort.TabIndex = 19;
            this.gbxSort.TabStop = false;
            this.gbxSort.Text = "정렬 기준";
            // 
            // rdoCom
            // 
            this.rdoCom.AutoSize = true;
            this.rdoCom.Location = new System.Drawing.Point(205, 23);
            this.rdoCom.Name = "rdoCom";
            this.rdoCom.Size = new System.Drawing.Size(71, 16);
            this.rdoCom.TabIndex = 19;
            this.rdoCom.TabStop = true;
            this.rdoCom.Text = "거래현황";
            this.rdoCom.UseVisualStyleBackColor = true;
            this.rdoCom.CheckedChanged += new System.EventHandler(this.rdoCom_CheckedChanged);
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Location = new System.Drawing.Point(111, 23);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(71, 16);
            this.rdoDate.TabIndex = 18;
            this.rdoDate.TabStop = true;
            this.rdoDate.Text = "최근날짜";
            this.rdoDate.UseVisualStyleBackColor = true;
            this.rdoDate.CheckedChanged += new System.EventHandler(this.rdoDate_CheckedChanged);
            // 
            // rdoOrderNo
            // 
            this.rdoOrderNo.AutoSize = true;
            this.rdoOrderNo.Location = new System.Drawing.Point(17, 23);
            this.rdoOrderNo.Name = "rdoOrderNo";
            this.rdoOrderNo.Size = new System.Drawing.Size(71, 16);
            this.rdoOrderNo.TabIndex = 17;
            this.rdoOrderNo.TabStop = true;
            this.rdoOrderNo.Text = "주문번호";
            this.rdoOrderNo.UseVisualStyleBackColor = true;
            this.rdoOrderNo.CheckedChanged += new System.EventHandler(this.rdoOrderNo_CheckedChanged);
            // 
            // btnBuyCancel
            // 
            this.btnBuyCancel.Location = new System.Drawing.Point(984, 498);
            this.btnBuyCancel.Name = "btnBuyCancel";
            this.btnBuyCancel.Size = new System.Drawing.Size(95, 23);
            this.btnBuyCancel.TabIndex = 4;
            this.btnBuyCancel.Text = "구매취소 요청";
            this.btnBuyCancel.UseVisualStyleBackColor = true;
            this.btnBuyCancel.Click += new System.EventHandler(this.btnBuyCancel_Click);
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(1085, 498);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(153, 23);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "영수증 엑셀파일 다운로드";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // gViewBuy
            // 
            this.gViewBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewBuy.Dock = System.Windows.Forms.DockStyle.Top;
            this.gViewBuy.Location = new System.Drawing.Point(3, 17);
            this.gViewBuy.MultiSelect = false;
            this.gViewBuy.Name = "gViewBuy";
            this.gViewBuy.RowTemplate.Height = 23;
            this.gViewBuy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gViewBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gViewBuy.Size = new System.Drawing.Size(1235, 393);
            this.gViewBuy.TabIndex = 0;
            // 
            // gbxCart
            // 
            this.gbxCart.Controls.Add(this.gbxCartSort);
            this.gbxCart.Controls.Add(this.btnCartBuy);
            this.gbxCart.Controls.Add(this.gviewCart);
            this.gbxCart.Controls.Add(this.btnDelete);
            this.gbxCart.Location = new System.Drawing.Point(345, 44);
            this.gbxCart.Name = "gbxCart";
            this.gbxCart.Size = new System.Drawing.Size(1241, 525);
            this.gbxCart.TabIndex = 16;
            this.gbxCart.TabStop = false;
            // 
            // gbxCartSort
            // 
            this.gbxCartSort.Controls.Add(this.rdoCartPriceDown);
            this.gbxCartSort.Controls.Add(this.rdoCartPriceUp);
            this.gbxCartSort.Controls.Add(this.rdoSaveNo);
            this.gbxCartSort.Location = new System.Drawing.Point(34, 416);
            this.gbxCartSort.Name = "gbxCartSort";
            this.gbxCartSort.Size = new System.Drawing.Size(309, 54);
            this.gbxCartSort.TabIndex = 21;
            this.gbxCartSort.TabStop = false;
            this.gbxCartSort.Text = "정렬 기준";
            // 
            // rdoCartPriceDown
            // 
            this.rdoCartPriceDown.AutoSize = true;
            this.rdoCartPriceDown.Location = new System.Drawing.Point(203, 23);
            this.rdoCartPriceDown.Name = "rdoCartPriceDown";
            this.rdoCartPriceDown.Size = new System.Drawing.Size(72, 16);
            this.rdoCartPriceDown.TabIndex = 19;
            this.rdoCartPriceDown.TabStop = true;
            this.rdoCartPriceDown.Text = "총 가격↓";
            this.rdoCartPriceDown.UseVisualStyleBackColor = true;
            this.rdoCartPriceDown.CheckedChanged += new System.EventHandler(this.rdoCartPriceDown_CheckedChanged);
            // 
            // rdoCartPriceUp
            // 
            this.rdoCartPriceUp.AutoSize = true;
            this.rdoCartPriceUp.Location = new System.Drawing.Point(110, 23);
            this.rdoCartPriceUp.Name = "rdoCartPriceUp";
            this.rdoCartPriceUp.Size = new System.Drawing.Size(72, 16);
            this.rdoCartPriceUp.TabIndex = 18;
            this.rdoCartPriceUp.TabStop = true;
            this.rdoCartPriceUp.Text = "총 가격↑";
            this.rdoCartPriceUp.UseVisualStyleBackColor = true;
            this.rdoCartPriceUp.CheckedChanged += new System.EventHandler(this.rdoCartPriceUp_CheckedChanged);
            // 
            // rdoSaveNo
            // 
            this.rdoSaveNo.AutoSize = true;
            this.rdoSaveNo.Location = new System.Drawing.Point(17, 23);
            this.rdoSaveNo.Name = "rdoSaveNo";
            this.rdoSaveNo.Size = new System.Drawing.Size(71, 16);
            this.rdoSaveNo.TabIndex = 17;
            this.rdoSaveNo.TabStop = true;
            this.rdoSaveNo.Text = "저장번호";
            this.rdoSaveNo.UseVisualStyleBackColor = true;
            this.rdoSaveNo.CheckedChanged += new System.EventHandler(this.rdoSaveNo_CheckedChanged);
            // 
            // btnCartBuy
            // 
            this.btnCartBuy.Location = new System.Drawing.Point(1042, 416);
            this.btnCartBuy.Name = "btnCartBuy";
            this.btnCartBuy.Size = new System.Drawing.Size(95, 23);
            this.btnCartBuy.TabIndex = 2;
            this.btnCartBuy.Text = "선택품목 구매";
            this.btnCartBuy.UseVisualStyleBackColor = true;
            this.btnCartBuy.Click += new System.EventHandler(this.btnCartBuy_Click);
            // 
            // gviewCart
            // 
            this.gviewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gviewCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.gviewCart.Location = new System.Drawing.Point(3, 17);
            this.gviewCart.MultiSelect = false;
            this.gviewCart.Name = "gviewCart";
            this.gviewCart.RowTemplate.Height = 23;
            this.gviewCart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gviewCart.Size = new System.Drawing.Size(1235, 393);
            this.gviewCart.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1143, 416);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "선택품목 삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxBuy
            // 
            this.gbxBuy.Controls.Add(this.lblBuyProSpec);
            this.gbxBuy.Controls.Add(this.txtBuySpec);
            this.gbxBuy.Controls.Add(this.btnAddCart);
            this.gbxBuy.Controls.Add(this.label4);
            this.gbxBuy.Controls.Add(this.nuProAmount);
            this.gbxBuy.Controls.Add(this.txtTotalPrice);
            this.gbxBuy.Controls.Add(this.label2);
            this.gbxBuy.Controls.Add(this.cbxBuyCusPro);
            this.gbxBuy.Controls.Add(this.btnBuyNow);
            this.gbxBuy.Controls.Add(this.label3);
            this.gbxBuy.Location = new System.Drawing.Point(540, 5);
            this.gbxBuy.Name = "gbxBuy";
            this.gbxBuy.Size = new System.Drawing.Size(354, 556);
            this.gbxBuy.TabIndex = 13;
            this.gbxBuy.TabStop = false;
            // 
            // lblBuyProSpec
            // 
            this.lblBuyProSpec.AutoSize = true;
            this.lblBuyProSpec.Location = new System.Drawing.Point(7, 62);
            this.lblBuyProSpec.Name = "lblBuyProSpec";
            this.lblBuyProSpec.Size = new System.Drawing.Size(53, 12);
            this.lblBuyProSpec.TabIndex = 21;
            this.lblBuyProSpec.Text = "제품구성";
            // 
            // txtBuySpec
            // 
            this.txtBuySpec.Location = new System.Drawing.Point(6, 82);
            this.txtBuySpec.Multiline = true;
            this.txtBuySpec.Name = "txtBuySpec";
            this.txtBuySpec.Size = new System.Drawing.Size(342, 290);
            this.txtBuySpec.TabIndex = 20;
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(156, 467);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(93, 73);
            this.btnAddCart.TabIndex = 18;
            this.btnAddCart.Text = "장바구니 추가";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "주문수량";
            // 
            // nuProAmount
            // 
            this.nuProAmount.Location = new System.Drawing.Point(67, 381);
            this.nuProAmount.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nuProAmount.Name = "nuProAmount";
            this.nuProAmount.Size = new System.Drawing.Size(54, 21);
            this.nuProAmount.TabIndex = 14;
            this.nuProAmount.ValueChanged += new System.EventHandler(this.nuProAmount_ValueChanged);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(67, 414);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(190, 21);
            this.txtTotalPrice.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "총 가격";
            // 
            // cbxBuyCusPro
            // 
            this.cbxBuyCusPro.FormattingEnabled = true;
            this.cbxBuyCusPro.Location = new System.Drawing.Point(67, 19);
            this.cbxBuyCusPro.Name = "cbxBuyCusPro";
            this.cbxBuyCusPro.Size = new System.Drawing.Size(190, 20);
            this.cbxBuyCusPro.TabIndex = 0;
            this.cbxBuyCusPro.SelectedIndexChanged += new System.EventHandler(this.cbxBuyCusPro_SelectedIndexChanged);
            // 
            // btnBuyNow
            // 
            this.btnBuyNow.Location = new System.Drawing.Point(255, 468);
            this.btnBuyNow.Name = "btnBuyNow";
            this.btnBuyNow.Size = new System.Drawing.Size(93, 73);
            this.btnBuyNow.TabIndex = 6;
            this.btnBuyNow.Text = "바로 구매하기";
            this.btnBuyNow.UseVisualStyleBackColor = true;
            this.btnBuyNow.Click += new System.EventHandler(this.btnBuyNow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "제품선택";
            // 
            // lstView
            // 
            this.lstView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstView.Location = new System.Drawing.Point(0, 0);
            this.lstView.MultiSelect = false;
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(875, 569);
            this.lstView.TabIndex = 0;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstView_MouseClick);
            // 
            // lblSpecTitle
            // 
            this.lblSpecTitle.AutoSize = true;
            this.lblSpecTitle.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSpecTitle.Location = new System.Drawing.Point(13, 20);
            this.lblSpecTitle.Name = "lblSpecTitle";
            this.lblSpecTitle.Size = new System.Drawing.Size(89, 21);
            this.lblSpecTitle.TabIndex = 3;
            this.lblSpecTitle.Text = "PC 구성";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.Location = new System.Drawing.Point(15, 111);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(0, 12);
            this.lblSpec.TabIndex = 2;
            // 
            // txtProSpec
            // 
            this.txtProSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProSpec.Location = new System.Drawing.Point(0, 0);
            this.txtProSpec.Name = "txtProSpec";
            this.txtProSpec.Size = new System.Drawing.Size(365, 569);
            this.txtProSpec.TabIndex = 0;
            this.txtProSpec.Text = "";
            // 
            // gbxAS
            // 
            this.gbxAS.Controls.Add(this.gbxAsSort);
            this.gbxAS.Controls.Add(this.lblCondition);
            this.gbxAS.Controls.Add(this.cbxOrderNo);
            this.gbxAS.Controls.Add(this.label1);
            this.gbxAS.Controls.Add(this.lblContentSize);
            this.gbxAS.Controls.Add(this.lblASApply);
            this.gbxAS.Controls.Add(this.lblASRecord);
            this.gbxAS.Controls.Add(this.gViewAS);
            this.gbxAS.Controls.Add(this.txtASContent);
            this.gbxAS.Controls.Add(this.cbxASCusPro);
            this.gbxAS.Controls.Add(this.btnSubmit);
            this.gbxAS.Controls.Add(this.lblCusPro);
            this.gbxAS.Controls.Add(this.txtCusID);
            this.gbxAS.Controls.Add(this.lblASContent);
            this.gbxAS.Controls.Add(this.lblCusID);
            this.gbxAS.Location = new System.Drawing.Point(335, 312);
            this.gbxAS.Name = "gbxAS";
            this.gbxAS.Size = new System.Drawing.Size(1219, 526);
            this.gbxAS.TabIndex = 9;
            this.gbxAS.TabStop = false;
            // 
            // gbxAsSort
            // 
            this.gbxAsSort.Controls.Add(this.rdoAsOrderNo);
            this.gbxAsSort.Controls.Add(this.rdoAsDate);
            this.gbxAsSort.Location = new System.Drawing.Point(986, 366);
            this.gbxAsSort.Name = "gbxAsSort";
            this.gbxAsSort.Size = new System.Drawing.Size(219, 54);
            this.gbxAsSort.TabIndex = 20;
            this.gbxAsSort.TabStop = false;
            this.gbxAsSort.Text = "정렬 기준";
            // 
            // rdoAsOrderNo
            // 
            this.rdoAsOrderNo.AutoSize = true;
            this.rdoAsOrderNo.Location = new System.Drawing.Point(131, 23);
            this.rdoAsOrderNo.Name = "rdoAsOrderNo";
            this.rdoAsOrderNo.Size = new System.Drawing.Size(71, 16);
            this.rdoAsOrderNo.TabIndex = 18;
            this.rdoAsOrderNo.TabStop = true;
            this.rdoAsOrderNo.Text = "주문번호";
            this.rdoAsOrderNo.UseVisualStyleBackColor = true;
            this.rdoAsOrderNo.CheckedChanged += new System.EventHandler(this.rdoAsOrderNo_CheckedChanged);
            // 
            // rdoAsDate
            // 
            this.rdoAsDate.AutoSize = true;
            this.rdoAsDate.Location = new System.Drawing.Point(17, 23);
            this.rdoAsDate.Name = "rdoAsDate";
            this.rdoAsDate.Size = new System.Drawing.Size(71, 16);
            this.rdoAsDate.TabIndex = 17;
            this.rdoAsDate.TabStop = true;
            this.rdoAsDate.Text = "신청날짜";
            this.rdoAsDate.UseVisualStyleBackColor = true;
            this.rdoAsDate.CheckedChanged += new System.EventHandler(this.rdoAsDate_CheckedChanged);
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(307, 397);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(255, 12);
            this.lblCondition.TabIndex = 16;
            this.lblCondition.Text = "* 고장 증상을 자세하게 10글자 이상 써주세요.";
            // 
            // cbxOrderNo
            // 
            this.cbxOrderNo.FormattingEnabled = true;
            this.cbxOrderNo.Location = new System.Drawing.Point(80, 483);
            this.cbxOrderNo.Name = "cbxOrderNo";
            this.cbxOrderNo.Size = new System.Drawing.Size(149, 20);
            this.cbxOrderNo.TabIndex = 14;
            this.cbxOrderNo.SelectedIndexChanged += new System.EventHandler(this.cbxOrderNo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "주문번호";
            // 
            // lblContentSize
            // 
            this.lblContentSize.AutoSize = true;
            this.lblContentSize.Location = new System.Drawing.Point(945, 437);
            this.lblContentSize.Name = "lblContentSize";
            this.lblContentSize.Size = new System.Drawing.Size(0, 12);
            this.lblContentSize.TabIndex = 13;
            // 
            // lblASApply
            // 
            this.lblASApply.AutoSize = true;
            this.lblASApply.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblASApply.Location = new System.Drawing.Point(6, 366);
            this.lblASApply.Name = "lblASApply";
            this.lblASApply.Size = new System.Drawing.Size(99, 21);
            this.lblASApply.TabIndex = 12;
            this.lblASApply.Text = "A/S 신청";
            // 
            // lblASRecord
            // 
            this.lblASRecord.AutoSize = true;
            this.lblASRecord.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblASRecord.Location = new System.Drawing.Point(6, 14);
            this.lblASRecord.Name = "lblASRecord";
            this.lblASRecord.Size = new System.Drawing.Size(151, 21);
            this.lblASRecord.TabIndex = 11;
            this.lblASRecord.Text = "A/S 신청 이력";
            // 
            // gViewAS
            // 
            this.gViewAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewAS.Location = new System.Drawing.Point(0, 42);
            this.gViewAS.Name = "gViewAS";
            this.gViewAS.ReadOnly = true;
            this.gViewAS.RowTemplate.Height = 23;
            this.gViewAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gViewAS.Size = new System.Drawing.Size(981, 298);
            this.gViewAS.TabIndex = 8;
            // 
            // txtASContent
            // 
            this.txtASContent.Location = new System.Drawing.Point(305, 415);
            this.txtASContent.Multiline = true;
            this.txtASContent.Name = "txtASContent";
            this.txtASContent.Size = new System.Drawing.Size(631, 83);
            this.txtASContent.TabIndex = 3;
            this.txtASContent.TextChanged += new System.EventHandler(this.txtASContent_TextChanged);
            // 
            // cbxASCusPro
            // 
            this.cbxASCusPro.FormattingEnabled = true;
            this.cbxASCusPro.Location = new System.Drawing.Point(80, 449);
            this.cbxASCusPro.Name = "cbxASCusPro";
            this.cbxASCusPro.Size = new System.Drawing.Size(149, 20);
            this.cbxASCusPro.TabIndex = 0;
            this.cbxASCusPro.SelectedIndexChanged += new System.EventHandler(this.cbxASCusPro_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(941, 475);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "A/S 신청";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCusPro
            // 
            this.lblCusPro.AutoSize = true;
            this.lblCusPro.Location = new System.Drawing.Point(21, 452);
            this.lblCusPro.Name = "lblCusPro";
            this.lblCusPro.Size = new System.Drawing.Size(50, 12);
            this.lblCusPro.TabIndex = 1;
            this.lblCusPro.Text = "구매 PC";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(80, 414);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(149, 21);
            this.txtCusID.TabIndex = 5;
            this.txtCusID.TextChanged += new System.EventHandler(this.txtCusID_TextChanged);
            // 
            // lblASContent
            // 
            this.lblASContent.AutoSize = true;
            this.lblASContent.Location = new System.Drawing.Point(242, 418);
            this.lblASContent.Name = "lblASContent";
            this.lblASContent.Size = new System.Drawing.Size(57, 12);
            this.lblASContent.TabIndex = 2;
            this.lblASContent.Text = "고장 증상";
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Location = new System.Drawing.Point(27, 418);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(44, 12);
            this.lblCusID.TabIndex = 4;
            this.lblCusID.Text = "회원 ID";
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(291, 50);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(65, 73);
            this.btnCart.TabIndex = 14;
            this.btnCart.Text = "장바구니";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnBuyRecord
            // 
            this.btnBuyRecord.Location = new System.Drawing.Point(384, 50);
            this.btnBuyRecord.Name = "btnBuyRecord";
            this.btnBuyRecord.Size = new System.Drawing.Size(65, 73);
            this.btnBuyRecord.TabIndex = 15;
            this.btnBuyRecord.Text = "구매내역";
            this.btnBuyRecord.UseVisualStyleBackColor = true;
            this.btnBuyRecord.Click += new System.EventHandler(this.btnBuyRecord_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 698);
            this.Controls.Add(this.btnBuyRecord);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.btnAS);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnProducts);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.panBottom.ResumeLayout(false);
            this.spCont.Panel1.ResumeLayout(false);
            this.spCont.Panel2.ResumeLayout(false);
            this.spCont.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spCont)).EndInit();
            this.spCont.ResumeLayout(false);
            this.gbxBuyRecord.ResumeLayout(false);
            this.gbxSort.ResumeLayout(false);
            this.gbxSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gViewBuy)).EndInit();
            this.gbxCart.ResumeLayout(false);
            this.gbxCartSort.ResumeLayout(false);
            this.gbxCartSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gviewCart)).EndInit();
            this.gbxBuy.ResumeLayout(false);
            this.gbxBuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuProAmount)).EndInit();
            this.gbxAS.ResumeLayout(false);
            this.gbxAS.PerformLayout();
            this.gbxAsSort.ResumeLayout(false);
            this.gbxAsSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gViewAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnAS;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.SplitContainer spCont;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.Label lblSpecTitle;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.RichTextBox txtProSpec;
        private System.Windows.Forms.GroupBox gbxAS;
        private System.Windows.Forms.TextBox txtASContent;
        private System.Windows.Forms.ComboBox cbxASCusPro;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCusPro;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.Label lblASContent;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.Label lblASRecord;
        private System.Windows.Forms.DataGridView gViewAS;
        private System.Windows.Forms.Label lblASApply;
        private System.Windows.Forms.GroupBox gbxBuy;
        private System.Windows.Forms.TextBox txtBuySpec;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nuProAmount;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxBuyCusPro;
        private System.Windows.Forms.Button btnBuyNow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBuyProSpec;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnBuyRecord;
        private System.Windows.Forms.GroupBox gbxCart;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView gviewCart;
        private System.Windows.Forms.GroupBox gbxBuyRecord;
        private System.Windows.Forms.DataGridView gViewBuy;
        private System.Windows.Forms.Button btnCartBuy;
        private System.Windows.Forms.Button btnBuyCancel;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Label lblContentSize;
        private System.Windows.Forms.ComboBox cbxOrderNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.SaveFileDialog saveFileDig;
        private System.Windows.Forms.GroupBox gbxSort;
        private System.Windows.Forms.RadioButton rdoCom;
        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.RadioButton rdoOrderNo;
        private System.Windows.Forms.GroupBox gbxAsSort;
        private System.Windows.Forms.RadioButton rdoAsOrderNo;
        private System.Windows.Forms.RadioButton rdoAsDate;
        private System.Windows.Forms.GroupBox gbxCartSort;
        private System.Windows.Forms.RadioButton rdoCartPriceUp;
        private System.Windows.Forms.RadioButton rdoSaveNo;
        private System.Windows.Forms.RadioButton rdoCartPriceDown;
    }
}

