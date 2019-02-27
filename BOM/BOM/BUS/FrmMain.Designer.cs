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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnma = new System.Windows.Forms.Button();
            this.btnchp = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnSales1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnBomMain = new System.Windows.Forms.Button();
            this.btnProMatEstimating = new System.Windows.Forms.Button();
            this.btnBomMatEstimating = new System.Windows.Forms.Button();
            this.btnBomSearch = new System.Windows.Forms.Button();
            this.btnBomAdd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblFunctionName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimer = new System.Windows.Forms.Label();
            this.dgvMainSales = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainSales)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBOM
            // 
            this.BtnBOM.BackColor = System.Drawing.Color.White;
            this.BtnBOM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnManage.Location = new System.Drawing.Point(0, 300);
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
            this.btnSales.Location = new System.Drawing.Point(0, 226);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(124, 74);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "판매 관리";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnma
            // 
            this.btnma.BackColor = System.Drawing.Color.White;
            this.btnma.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnSi.Location = new System.Drawing.Point(0, 326);
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
            this.btnSales1.Location = new System.Drawing.Point(0, 297);
            this.btnSales1.Name = "btnSales1";
            this.btnSales1.Size = new System.Drawing.Size(124, 30);
            this.btnSales1.TabIndex = 4;
            this.btnSales1.Text = "판매조회";
            this.btnSales1.UseVisualStyleBackColor = false;
            this.btnSales1.Visible = false;
            this.btnSales1.Click += new System.EventHandler(this.btnSales1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(0, 413);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 30);
            this.button7.TabIndex = 12;
            this.button7.Text = "출하지시서";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnBomMain
            // 
            this.btnBomMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBomMain.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBomMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBomMain.Location = new System.Drawing.Point(0, 53);
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
            this.btnBomAdd.Location = new System.Drawing.Point(0, 253);
            this.btnBomAdd.Name = "btnBomAdd";
            this.btnBomAdd.Size = new System.Drawing.Size(124, 30);
            this.btnBomAdd.TabIndex = 0;
            this.btnBomAdd.Text = "BOM등록";
            this.btnBomAdd.UseVisualStyleBackColor = true;
            this.btnBomAdd.Visible = false;
            this.btnBomAdd.Click += new System.EventHandler(this.btnBomAdd_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 74);
            this.button3.TabIndex = 10;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblFunctionName
            // 
            this.lblFunctionName.AutoSize = true;
            this.lblFunctionName.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFunctionName.Location = new System.Drawing.Point(269, 49);
            this.lblFunctionName.Name = "lblFunctionName";
            this.lblFunctionName.Size = new System.Drawing.Size(0, 27);
            this.lblFunctionName.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtTimer);
            this.panel1.Controls.Add(this.dgvMainSales);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(124, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 572);
            this.panel1.TabIndex = 13;
            // 
            // txtTimer
            // 
            this.txtTimer.AutoSize = true;
            this.txtTimer.ForeColor = System.Drawing.Color.Black;
            this.txtTimer.Location = new System.Drawing.Point(684, 399);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(34, 12);
            this.txtTimer.TabIndex = 7;
            this.txtTimer.Text = "Time";
            // 
            // dgvMainSales
            // 
            this.dgvMainSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainSales.Location = new System.Drawing.Point(194, 144);
            this.dgvMainSales.Name = "dgvMainSales";
            this.dgvMainSales.RowTemplate.Height = 23;
            this.dgvMainSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMainSales.Size = new System.Drawing.Size(572, 245);
            this.dgvMainSales.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(591, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "1분마다 자동으로 갱신";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(724, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "갱신";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(58, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "자재 등록";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(118, 456);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 50);
            this.button6.TabIndex = 8;
            this.button6.Text = "자재 조회";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(58, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 50);
            this.button4.TabIndex = 10;
            this.button4.Text = "상품 관리";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(58, 301);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 50);
            this.button5.TabIndex = 9;
            this.button5.Text = "발주 관리";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1042, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnProMatEstimating);
            this.Controls.Add(this.lblFunctionName);
            this.Controls.Add(this.btnma);
            this.Controls.Add(this.btnBomMain);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnBomAdd);
            this.Controls.Add(this.btnSales1);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.btnBomSearch);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.BtnBOM);
            this.Controls.Add(this.btnchp);
            this.Controls.Add(this.btnBomMatEstimating);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBOM;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnma;
        private System.Windows.Forms.Button btnchp;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnSales1;
        private System.Windows.Forms.Button btnProMatEstimating;
        private System.Windows.Forms.Button btnBomMatEstimating;
        private System.Windows.Forms.Button btnBomSearch;
        private System.Windows.Forms.Button btnBomAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBomMain;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblFunctionName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTimer;
        private System.Windows.Forms.DataGridView dgvMainSales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}