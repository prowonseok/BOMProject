namespace CustomerApp.BUS
{
    partial class Form1
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
            this.gbxAS = new System.Windows.Forms.GroupBox();
            this.lblASApply = new System.Windows.Forms.Label();
            this.lblASRecord = new System.Windows.Forms.Label();
            this.txtCusProDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gViewAS = new System.Windows.Forms.DataGridView();
            this.txtASContent = new System.Windows.Forms.TextBox();
            this.cbxASCusPro = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCusPro = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.lblASContent = new System.Windows.Forms.Label();
            this.lblCusID = new System.Windows.Forms.Label();
            this.lstView = new System.Windows.Forms.ListView();
            this.lblSpecTitle = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.txtProSpec = new System.Windows.Forms.RichTextBox();
            this.gbxBuy = new System.Windows.Forms.GroupBox();
            this.txtBuySpec = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nuProAmount = new System.Windows.Forms.NumericUpDown();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxBuyCusPro = new System.Windows.Forms.ComboBox();
            this.btnBuyNow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBuyProSpec = new System.Windows.Forms.Label();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnBuyRecord = new System.Windows.Forms.Button();
            this.gbxCart = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gviewCart = new System.Windows.Forms.DataGridView();
            this.gbxBuyRecord = new System.Windows.Forms.GroupBox();
            this.gViewBuy = new System.Windows.Forms.DataGridView();
            this.panTop.SuspendLayout();
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spCont)).BeginInit();
            this.spCont.Panel1.SuspendLayout();
            this.spCont.Panel2.SuspendLayout();
            this.spCont.SuspendLayout();
            this.gbxAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gViewAS)).BeginInit();
            this.gbxBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuProAmount)).BeginInit();
            this.gbxCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gviewCart)).BeginInit();
            this.gbxBuyRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gViewBuy)).BeginInit();
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
            this.spCont.Panel1.Controls.Add(this.gbxBuyRecord);
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
            // gbxAS
            // 
            this.gbxAS.Controls.Add(this.gbxCart);
            this.gbxAS.Controls.Add(this.lblASApply);
            this.gbxAS.Controls.Add(this.lblASRecord);
            this.gbxAS.Controls.Add(this.gbxBuy);
            this.gbxAS.Controls.Add(this.txtCusProDate);
            this.gbxAS.Controls.Add(this.label1);
            this.gbxAS.Controls.Add(this.gViewAS);
            this.gbxAS.Controls.Add(this.txtASContent);
            this.gbxAS.Controls.Add(this.cbxASCusPro);
            this.gbxAS.Controls.Add(this.btnSubmit);
            this.gbxAS.Controls.Add(this.lblCusPro);
            this.gbxAS.Controls.Add(this.txtCusID);
            this.gbxAS.Controls.Add(this.lblASContent);
            this.gbxAS.Controls.Add(this.lblCusID);
            this.gbxAS.Location = new System.Drawing.Point(39, 50);
            this.gbxAS.Name = "gbxAS";
            this.gbxAS.Size = new System.Drawing.Size(1219, 526);
            this.gbxAS.TabIndex = 9;
            this.gbxAS.TabStop = false;
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
            // txtCusProDate
            // 
            this.txtCusProDate.Location = new System.Drawing.Point(80, 487);
            this.txtCusProDate.Name = "txtCusProDate";
            this.txtCusProDate.Size = new System.Drawing.Size(121, 21);
            this.txtCusProDate.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "구매날짜";
            // 
            // gViewAS
            // 
            this.gViewAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewAS.Location = new System.Drawing.Point(0, 42);
            this.gViewAS.Name = "gViewAS";
            this.gViewAS.RowTemplate.Height = 23;
            this.gViewAS.Size = new System.Drawing.Size(981, 298);
            this.gViewAS.TabIndex = 8;
            // 
            // txtASContent
            // 
            this.txtASContent.Location = new System.Drawing.Point(270, 414);
            this.txtASContent.Multiline = true;
            this.txtASContent.Name = "txtASContent";
            this.txtASContent.Size = new System.Drawing.Size(550, 94);
            this.txtASContent.TabIndex = 3;
            // 
            // cbxASCusPro
            // 
            this.cbxASCusPro.FormattingEnabled = true;
            this.cbxASCusPro.Location = new System.Drawing.Point(80, 451);
            this.cbxASCusPro.Name = "cbxASCusPro";
            this.cbxASCusPro.Size = new System.Drawing.Size(121, 20);
            this.cbxASCusPro.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(835, 485);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "A/S 신청";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblCusPro
            // 
            this.lblCusPro.AutoSize = true;
            this.lblCusPro.Location = new System.Drawing.Point(21, 454);
            this.lblCusPro.Name = "lblCusPro";
            this.lblCusPro.Size = new System.Drawing.Size(50, 12);
            this.lblCusPro.TabIndex = 1;
            this.lblCusPro.Text = "구매 PC";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(80, 414);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(121, 21);
            this.txtCusID.TabIndex = 5;
            // 
            // lblASContent
            // 
            this.lblASContent.AutoSize = true;
            this.lblASContent.Location = new System.Drawing.Point(207, 418);
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
            this.lblSpec.Size = new System.Drawing.Size(33, 12);
            this.lblSpec.TabIndex = 2;
            this.lblSpec.Text = "spec";
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
            // gbxBuy
            // 
            this.gbxBuy.Controls.Add(this.lblBuyProSpec);
            this.gbxBuy.Controls.Add(this.txtBuySpec);
            this.gbxBuy.Controls.Add(this.btnAdd);
            this.gbxBuy.Controls.Add(this.label4);
            this.gbxBuy.Controls.Add(this.nuProAmount);
            this.gbxBuy.Controls.Add(this.txtTotalPrice);
            this.gbxBuy.Controls.Add(this.label2);
            this.gbxBuy.Controls.Add(this.cbxBuyCusPro);
            this.gbxBuy.Controls.Add(this.btnBuyNow);
            this.gbxBuy.Controls.Add(this.label3);
            this.gbxBuy.Location = new System.Drawing.Point(20, 54);
            this.gbxBuy.Name = "gbxBuy";
            this.gbxBuy.Size = new System.Drawing.Size(354, 556);
            this.gbxBuy.TabIndex = 13;
            this.gbxBuy.TabStop = false;
            // 
            // txtBuySpec
            // 
            this.txtBuySpec.Location = new System.Drawing.Point(6, 82);
            this.txtBuySpec.Multiline = true;
            this.txtBuySpec.Name = "txtBuySpec";
            this.txtBuySpec.Size = new System.Drawing.Size(342, 290);
            this.txtBuySpec.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(156, 467);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 73);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "장바구니 추가";
            this.btnAdd.UseVisualStyleBackColor = true;
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
            // lblBuyProSpec
            // 
            this.lblBuyProSpec.AutoSize = true;
            this.lblBuyProSpec.Location = new System.Drawing.Point(7, 62);
            this.lblBuyProSpec.Name = "lblBuyProSpec";
            this.lblBuyProSpec.Size = new System.Drawing.Size(53, 12);
            this.lblBuyProSpec.TabIndex = 21;
            this.lblBuyProSpec.Text = "제품구성";
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
            // gbxCart
            // 
            this.gbxCart.Controls.Add(this.btnDelete);
            this.gbxCart.Controls.Add(this.gviewCart);
            this.gbxCart.Location = new System.Drawing.Point(401, 159);
            this.gbxCart.Name = "gbxCart";
            this.gbxCart.Size = new System.Drawing.Size(944, 525);
            this.gbxCart.TabIndex = 16;
            this.gbxCart.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(846, 416);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "선택품목 삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gviewCart
            // 
            this.gviewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gviewCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.gviewCart.Location = new System.Drawing.Point(3, 17);
            this.gviewCart.Name = "gviewCart";
            this.gviewCart.RowTemplate.Height = 23;
            this.gviewCart.Size = new System.Drawing.Size(938, 393);
            this.gviewCart.TabIndex = 0;
            // 
            // gbxBuyRecord
            // 
            this.gbxBuyRecord.Controls.Add(this.gViewBuy);
            this.gbxBuyRecord.Location = new System.Drawing.Point(62, 80);
            this.gbxBuyRecord.Name = "gbxBuyRecord";
            this.gbxBuyRecord.Size = new System.Drawing.Size(944, 525);
            this.gbxBuyRecord.TabIndex = 16;
            this.gbxBuyRecord.TabStop = false;
            // 
            // gViewBuy
            // 
            this.gViewBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewBuy.Dock = System.Windows.Forms.DockStyle.Top;
            this.gViewBuy.Location = new System.Drawing.Point(3, 17);
            this.gViewBuy.Name = "gViewBuy";
            this.gViewBuy.RowTemplate.Height = 23;
            this.gViewBuy.Size = new System.Drawing.Size(938, 393);
            this.gViewBuy.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 698);
            this.Controls.Add(this.btnBuyRecord);
            this.Controls.Add(this.gbxAS);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.btnAS);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnProducts);
            this.Name = "Form1";
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
            this.gbxAS.ResumeLayout(false);
            this.gbxAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gViewAS)).EndInit();
            this.gbxBuy.ResumeLayout(false);
            this.gbxBuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuProAmount)).EndInit();
            this.gbxCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gviewCart)).EndInit();
            this.gbxBuyRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gViewBuy)).EndInit();
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
        private System.Windows.Forms.TextBox txtCusProDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gViewAS;
        private System.Windows.Forms.Label lblASApply;
        private System.Windows.Forms.GroupBox gbxBuy;
        private System.Windows.Forms.TextBox txtBuySpec;
        private System.Windows.Forms.Button btnAdd;
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
    }
}

