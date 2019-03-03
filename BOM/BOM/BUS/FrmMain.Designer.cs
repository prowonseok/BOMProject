namespace BOM.BUS
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnBOM = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnma = new System.Windows.Forms.Button();
            this.btnchp = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnSales1 = new System.Windows.Forms.Button();
            this.btnShipment = new System.Windows.Forms.Button();
            this.btnBomMain = new System.Windows.Forms.Button();
            this.btnProMatEstimating = new System.Windows.Forms.Button();
            this.btnBomMatEstimating = new System.Windows.Forms.Button();
            this.btnBomSearch = new System.Windows.Forms.Button();
            this.btnBomAdd = new System.Windows.Forms.Button();
            this.lblFunctionName = new System.Windows.Forms.Label();
            this.btnDateInsert = new System.Windows.Forms.Panel();
            this.btnDataInsert = new System.Windows.Forms.Button();
            this.btnMatView = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.btnOfferOrder = new System.Windows.Forms.Button();
            this.timerChk = new System.Windows.Forms.Timer(this.components);
            this.lblBOM = new System.Windows.Forms.Label();
            this.btnAS = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblPasswordChange = new System.Windows.Forms.Label();
            this.btnDateInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBOM
            // 
            this.BtnBOM.BackColor = System.Drawing.Color.White;
            this.BtnBOM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBOM.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnBOM.Location = new System.Drawing.Point(0, 151);
            this.BtnBOM.Name = "BtnBOM";
            this.BtnBOM.Size = new System.Drawing.Size(124, 74);
            this.BtnBOM.TabIndex = 0;
            this.BtnBOM.Text = "BOM 관리";
            this.BtnBOM.UseVisualStyleBackColor = false;
            this.BtnBOM.Click += new System.EventHandler(this.BtnBOM_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.White;
            this.btnManage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnManage.Location = new System.Drawing.Point(0, 296);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(124, 74);
            this.btnManage.TabIndex = 1;
            this.btnManage.Text = "관리자";
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.White;
            this.btnSales.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSales.Location = new System.Drawing.Point(0, 223);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(124, 74);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "판매 관리";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnma
            // 
            this.btnma.BackColor = System.Drawing.Color.White;
            this.btnma.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnma.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnma.Location = new System.Drawing.Point(0, 384);
            this.btnma.Name = "btnma";
            this.btnma.Size = new System.Drawing.Size(124, 30);
            this.btnma.TabIndex = 7;
            this.btnma.Text = "매출";
            this.btnma.UseVisualStyleBackColor = false;
            this.btnma.Visible = false;
            this.btnma.Click += new System.EventHandler(this.btnma_Click);
            // 
            // btnchp
            // 
            this.btnchp.BackColor = System.Drawing.Color.White;
            this.btnchp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnchp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchp.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnchp.Location = new System.Drawing.Point(0, 355);
            this.btnchp.Name = "btnchp";
            this.btnchp.Size = new System.Drawing.Size(124, 30);
            this.btnchp.TabIndex = 6;
            this.btnchp.Text = "거래처 등록";
            this.btnchp.UseVisualStyleBackColor = false;
            this.btnchp.Visible = false;
            this.btnchp.Click += new System.EventHandler(this.btnchp_Click);
            // 
            // btnSi
            // 
            this.btnSi.BackColor = System.Drawing.Color.White;
            this.btnSi.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSi.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSi.Location = new System.Drawing.Point(0, 355);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(124, 30);
            this.btnSi.TabIndex = 5;
            this.btnSi.Text = "단가변경";
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Visible = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnSales1
            // 
            this.btnSales1.BackColor = System.Drawing.Color.White;
            this.btnSales1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSales1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSales1.Location = new System.Drawing.Point(0, 391);
            this.btnSales1.Name = "btnSales1";
            this.btnSales1.Size = new System.Drawing.Size(124, 30);
            this.btnSales1.TabIndex = 4;
            this.btnSales1.Text = "판매조회";
            this.btnSales1.UseVisualStyleBackColor = false;
            this.btnSales1.Visible = false;
            this.btnSales1.Click += new System.EventHandler(this.btnSales1_Click);
            // 
            // btnShipment
            // 
            this.btnShipment.BackColor = System.Drawing.Color.White;
            this.btnShipment.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnShipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShipment.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnShipment.Location = new System.Drawing.Point(0, 399);
            this.btnShipment.Name = "btnShipment";
            this.btnShipment.Size = new System.Drawing.Size(124, 30);
            this.btnShipment.TabIndex = 12;
            this.btnShipment.Text = "출하지시서";
            this.btnShipment.UseVisualStyleBackColor = false;
            this.btnShipment.Visible = false;
            this.btnShipment.Click += new System.EventHandler(this.btnShipment_Click);
            // 
            // btnBomMain
            // 
            this.btnBomMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBomMain.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBomMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBomMain.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBomMain.Location = new System.Drawing.Point(0, 0);
            this.btnBomMain.Name = "btnBomMain";
            this.btnBomMain.Size = new System.Drawing.Size(124, 30);
            this.btnBomMain.TabIndex = 12;
            this.btnBomMain.Text = "BOM 메인";
            this.btnBomMain.UseVisualStyleBackColor = true;
            this.btnBomMain.Visible = false;
            this.btnBomMain.Click += new System.EventHandler(this.btnBomMain_Click);
            // 
            // btnProMatEstimating
            // 
            this.btnProMatEstimating.BackColor = System.Drawing.Color.White;
            this.btnProMatEstimating.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnProMatEstimating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProMatEstimating.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProMatEstimating.Location = new System.Drawing.Point(0, 340);
            this.btnProMatEstimating.Name = "btnProMatEstimating";
            this.btnProMatEstimating.Size = new System.Drawing.Size(124, 30);
            this.btnProMatEstimating.TabIndex = 3;
            this.btnProMatEstimating.Text = "판매 예측";
            this.btnProMatEstimating.UseVisualStyleBackColor = true;
            this.btnProMatEstimating.Visible = false;
            this.btnProMatEstimating.Click += new System.EventHandler(this.btnProMatEstimating_Click);
            // 
            // btnBomMatEstimating
            // 
            this.btnBomMatEstimating.BackColor = System.Drawing.Color.White;
            this.btnBomMatEstimating.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBomMatEstimating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBomMatEstimating.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBomMatEstimating.Location = new System.Drawing.Point(0, 311);
            this.btnBomMatEstimating.Name = "btnBomMatEstimating";
            this.btnBomMatEstimating.Size = new System.Drawing.Size(124, 30);
            this.btnBomMatEstimating.TabIndex = 2;
            this.btnBomMatEstimating.Text = "소요량 예측";
            this.btnBomMatEstimating.UseVisualStyleBackColor = true;
            this.btnBomMatEstimating.Visible = false;
            this.btnBomMatEstimating.Click += new System.EventHandler(this.btnBomMatEstimating_Click);
            // 
            // btnBomSearch
            // 
            this.btnBomSearch.BackColor = System.Drawing.Color.White;
            this.btnBomSearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBomSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBomSearch.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBomSearch.Location = new System.Drawing.Point(0, 282);
            this.btnBomSearch.Name = "btnBomSearch";
            this.btnBomSearch.Size = new System.Drawing.Size(124, 30);
            this.btnBomSearch.TabIndex = 1;
            this.btnBomSearch.Text = "BOM 조회";
            this.btnBomSearch.UseVisualStyleBackColor = true;
            this.btnBomSearch.Visible = false;
            this.btnBomSearch.Click += new System.EventHandler(this.btnBomSearch_Click);
            // 
            // btnBomAdd
            // 
            this.btnBomAdd.BackColor = System.Drawing.Color.White;
            this.btnBomAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBomAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBomAdd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBomAdd.Location = new System.Drawing.Point(0, 253);
            this.btnBomAdd.Name = "btnBomAdd";
            this.btnBomAdd.Size = new System.Drawing.Size(124, 30);
            this.btnBomAdd.TabIndex = 0;
            this.btnBomAdd.Text = "BOM등록";
            this.btnBomAdd.UseVisualStyleBackColor = true;
            this.btnBomAdd.Visible = false;
            this.btnBomAdd.Click += new System.EventHandler(this.btnBomAdd_Click);
            // 
            // lblFunctionName
            // 
            this.lblFunctionName.AutoSize = true;
            this.lblFunctionName.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFunctionName.Location = new System.Drawing.Point(130, 39);
            this.lblFunctionName.Name = "lblFunctionName";
            this.lblFunctionName.Size = new System.Drawing.Size(0, 37);
            this.lblFunctionName.TabIndex = 11;
            // 
            // btnDateInsert
            // 
            this.btnDateInsert.BackColor = System.Drawing.Color.White;
            this.btnDateInsert.Controls.Add(this.btnDataInsert);
            this.btnDateInsert.Location = new System.Drawing.Point(124, 79);
            this.btnDateInsert.Name = "btnDateInsert";
            this.btnDateInsert.Size = new System.Drawing.Size(838, 472);
            this.btnDateInsert.TabIndex = 13;
            // 
            // btnDataInsert
            // 
            this.btnDataInsert.Location = new System.Drawing.Point(438, 16);
            this.btnDataInsert.Name = "btnDataInsert";
            this.btnDataInsert.Size = new System.Drawing.Size(119, 23);
            this.btnDataInsert.TabIndex = 14;
            this.btnDataInsert.Text = "데이터 삽입폼";
            this.btnDataInsert.UseVisualStyleBackColor = true;
            this.btnDataInsert.Click += new System.EventHandler(this.btnDataInsert_Click);
            // 
            // btnMatView
            // 
            this.btnMatView.BackColor = System.Drawing.Color.White;
            this.btnMatView.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMatView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatView.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMatView.Location = new System.Drawing.Point(0, 432);
            this.btnMatView.Name = "btnMatView";
            this.btnMatView.Size = new System.Drawing.Size(124, 30);
            this.btnMatView.TabIndex = 8;
            this.btnMatView.Text = "자재 조회";
            this.btnMatView.UseVisualStyleBackColor = false;
            this.btnMatView.Click += new System.EventHandler(this.btnMatView_Click);
            // 
            // btnProd
            // 
            this.btnProd.BackColor = System.Drawing.Color.White;
            this.btnProd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProd.Location = new System.Drawing.Point(0, 403);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(124, 30);
            this.btnProd.TabIndex = 10;
            this.btnProd.Text = "상품 관리";
            this.btnProd.UseVisualStyleBackColor = false;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // btnOfferOrder
            // 
            this.btnOfferOrder.BackColor = System.Drawing.Color.White;
            this.btnOfferOrder.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOfferOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfferOrder.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOfferOrder.Location = new System.Drawing.Point(0, 374);
            this.btnOfferOrder.Name = "btnOfferOrder";
            this.btnOfferOrder.Size = new System.Drawing.Size(124, 30);
            this.btnOfferOrder.TabIndex = 9;
            this.btnOfferOrder.Text = "발주 관리";
            this.btnOfferOrder.UseVisualStyleBackColor = false;
            this.btnOfferOrder.Click += new System.EventHandler(this.btnOfferOrder_Click);
            // 
            // timerChk
            // 
            this.timerChk.Interval = 6000;
            // 
            // lblBOM
            // 
            this.lblBOM.AutoSize = true;
            this.lblBOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBOM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBOM.Location = new System.Drawing.Point(27, 21);
            this.lblBOM.Name = "lblBOM";
            this.lblBOM.Size = new System.Drawing.Size(84, 33);
            this.lblBOM.TabIndex = 14;
            this.lblBOM.Text = "BOM";
            // 
            // btnAS
            // 
            this.btnAS.BackColor = System.Drawing.Color.White;
            this.btnAS.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAS.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.btnAS.ForeColor = System.Drawing.Color.White;
            this.btnAS.Location = new System.Drawing.Point(0, 461);
            this.btnAS.Name = "btnAS";
            this.btnAS.Size = new System.Drawing.Size(124, 30);
            this.btnAS.TabIndex = 14;
            this.btnAS.Text = "A/S 관리";
            this.btnAS.UseVisualStyleBackColor = false;
            this.btnAS.Click += new System.EventHandler(this.btnAS_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Image = global::BOM.Properties.Resources.setting;
            this.btnSetting.Location = new System.Drawing.Point(922, 33);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(40, 40);
            this.btnSetting.TabIndex = 15;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHome.Location = new System.Drawing.Point(0, 79);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(124, 79);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblPasswordChange
            // 
            this.lblPasswordChange.AutoSize = true;
            this.lblPasswordChange.Location = new System.Drawing.Point(881, 21);
            this.lblPasswordChange.Name = "lblPasswordChange";
            this.lblPasswordChange.Size = new System.Drawing.Size(81, 12);
            this.lblPasswordChange.TabIndex = 16;
            this.lblPasswordChange.Text = "비밀번호 변경";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(968, 554);
            this.Controls.Add(this.lblPasswordChange);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.lblBOM);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.btnSales1);
            this.Controls.Add(this.btnDateInsert);
            this.Controls.Add(this.btnAS);
            this.Controls.Add(this.btnProMatEstimating);
            this.Controls.Add(this.lblFunctionName);
            this.Controls.Add(this.btnOfferOrder);
            this.Controls.Add(this.btnBomMain);
            this.Controls.Add(this.btnProd);
            this.Controls.Add(this.btnMatView);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnShipment);
            this.Controls.Add(this.btnBomAdd);
            this.Controls.Add(this.btnBomSearch);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.BtnBOM);
            this.Controls.Add(this.btnchp);
            this.Controls.Add(this.btnBomMatEstimating);
            this.Controls.Add(this.btnma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMain";
            this.Text = "BOM";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.btnDateInsert.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBOM;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnma;
        private System.Windows.Forms.Button btnchp;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnSales1;
        private System.Windows.Forms.Button btnProMatEstimating;
        private System.Windows.Forms.Button btnBomMatEstimating;
        private System.Windows.Forms.Button btnBomSearch;
        private System.Windows.Forms.Button btnBomAdd;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBomMain;
        private System.Windows.Forms.Button btnShipment;
        private System.Windows.Forms.Label lblFunctionName;
        private System.Windows.Forms.Panel btnDateInsert;
        private System.Windows.Forms.Button btnMatView;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnOfferOrder;
        private System.Windows.Forms.Timer timerChk;

        private System.Windows.Forms.Button btnDataInsert;
        private System.Windows.Forms.Label lblBOM;

        private System.Windows.Forms.Button btnAS;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Label lblPasswordChange;
    }
}