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
            this.BtnBOM = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.dgvMainSales = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnma = new System.Windows.Forms.Button();
            this.btnchp = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnSales1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProMatEstimating = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBomMatEstimating = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnBomSearch = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnBomAdd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainSales)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBOM
            // 
            this.BtnBOM.Location = new System.Drawing.Point(0, 150);
            this.BtnBOM.Name = "BtnBOM";
            this.BtnBOM.Size = new System.Drawing.Size(124, 74);
            this.BtnBOM.TabIndex = 0;
            this.BtnBOM.Text = "BOM 관리";
            this.BtnBOM.UseVisualStyleBackColor = true;
            this.BtnBOM.Click += new System.EventHandler(this.BtnBOM_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(0, 295);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(124, 74);
            this.btnManage.TabIndex = 1;
            this.btnManage.Text = "관리자";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(0, 222);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(124, 74);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "판매 관리";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // dgvMainSales
            // 
            this.dgvMainSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainSales.Location = new System.Drawing.Point(110, 106);
            this.dgvMainSales.Name = "dgvMainSales";
            this.dgvMainSales.RowTemplate.Height = 23;
            this.dgvMainSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMainSales.Size = new System.Drawing.Size(572, 245);
            this.dgvMainSales.TabIndex = 3;
            this.dgvMainSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMainSales_CellClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(555, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "1분마다 자동으로 갱신";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "갱신";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnma);
            this.panel1.Controls.Add(this.dgvMainSales);
            this.panel1.Controls.Add(this.btnchp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSi);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnSales1);
            this.panel1.Location = new System.Drawing.Point(256, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 483);
            this.panel1.TabIndex = 8;
            // 
            // btnma
            // 
            this.btnma.Location = new System.Drawing.Point(-90, 147);
            this.btnma.Name = "btnma";
            this.btnma.Size = new System.Drawing.Size(132, 50);
            this.btnma.TabIndex = 7;
            this.btnma.Text = "판매 예측";
            this.btnma.UseVisualStyleBackColor = true;
            // 
            // btnchp
            // 
            this.btnchp.Location = new System.Drawing.Point(-90, 98);
            this.btnchp.Name = "btnchp";
            this.btnchp.Size = new System.Drawing.Size(132, 50);
            this.btnchp.TabIndex = 6;
            this.btnchp.Text = "소요량 예측";
            this.btnchp.UseVisualStyleBackColor = true;
            // 
            // btnSi
            // 
            this.btnSi.Location = new System.Drawing.Point(-90, 49);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(132, 50);
            this.btnSi.TabIndex = 5;
            this.btnSi.Text = "BOM조회";
            this.btnSi.UseVisualStyleBackColor = true;
            // 
            // btnSales1
            // 
            this.btnSales1.Location = new System.Drawing.Point(-90, 0);
            this.btnSales1.Name = "btnSales1";
            this.btnSales1.Size = new System.Drawing.Size(132, 50);
            this.btnSales1.TabIndex = 4;
            this.btnSales1.Text = "BOM등록";
            this.btnSales1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnProMatEstimating);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnBomMatEstimating);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btnBomSearch);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.btnBomAdd);
            this.panel2.Location = new System.Drawing.Point(123, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 483);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "자재 등록";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnProMatEstimating
            // 
            this.btnProMatEstimating.Location = new System.Drawing.Point(0, 148);
            this.btnProMatEstimating.Name = "btnProMatEstimating";
            this.btnProMatEstimating.Size = new System.Drawing.Size(132, 50);
            this.btnProMatEstimating.TabIndex = 3;
            this.btnProMatEstimating.Text = "판매 예측";
            this.btnProMatEstimating.UseVisualStyleBackColor = true;
            this.btnProMatEstimating.Click += new System.EventHandler(this.btnProMatEstimating_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(43, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 50);
            this.button4.TabIndex = 10;
            this.button4.Text = "상품 관리";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnBomMatEstimating
            // 
            this.btnBomMatEstimating.Location = new System.Drawing.Point(0, 99);
            this.btnBomMatEstimating.Name = "btnBomMatEstimating";
            this.btnBomMatEstimating.Size = new System.Drawing.Size(132, 50);
            this.btnBomMatEstimating.TabIndex = 2;
            this.btnBomMatEstimating.Text = "소요량 예측";
            this.btnBomMatEstimating.UseVisualStyleBackColor = true;
            this.btnBomMatEstimating.Click += new System.EventHandler(this.btnBomMatEstimating_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(43, 252);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 50);
            this.button5.TabIndex = 9;
            this.button5.Text = "발주 관리";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnBomSearch
            // 
            this.btnBomSearch.Location = new System.Drawing.Point(0, 50);
            this.btnBomSearch.Name = "btnBomSearch";
            this.btnBomSearch.Size = new System.Drawing.Size(132, 50);
            this.btnBomSearch.TabIndex = 1;
            this.btnBomSearch.Text = "BOM조회";
            this.btnBomSearch.UseVisualStyleBackColor = true;
            this.btnBomSearch.Click += new System.EventHandler(this.btnBomSearch_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(43, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 50);
            this.button6.TabIndex = 8;
            this.button6.Text = "자재 조회";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnBomAdd
            // 
            this.btnBomAdd.Location = new System.Drawing.Point(0, 1);
            this.btnBomAdd.Name = "btnBomAdd";
            this.btnBomAdd.Size = new System.Drawing.Size(132, 50);
            this.btnBomAdd.TabIndex = 0;
            this.btnBomAdd.Text = "BOM등록";
            this.btnBomAdd.UseVisualStyleBackColor = true;
            this.btnBomAdd.Click += new System.EventHandler(this.btnBomAdd_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 74);
            this.button3.TabIndex = 10;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 562);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.BtnBOM);
            this.Controls.Add(this.btnManage);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainSales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBOM;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.DataGridView dgvMainSales;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnma;
        private System.Windows.Forms.Button btnchp;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnSales1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnProMatEstimating;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBomMatEstimating;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnBomSearch;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnBomAdd;
        private System.Windows.Forms.Button button3;
    }
}