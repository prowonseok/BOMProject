namespace BOM.BUS.Managements
{
    partial class FrmProducts
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMatType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSpec = new System.Windows.Forms.TextBox();
            this.ofdProImg = new System.Windows.Forms.OpenFileDialog();
            this.pbProImg = new System.Windows.Forms.PictureBox();
            this.btnImgSearch = new System.Windows.Forms.Button();
            this.lblImg = new System.Windows.Forms.Label();
            this.gbSpec = new System.Windows.Forms.GroupBox();
            this.lblCOOLER = new System.Windows.Forms.Label();
            this.lblCASE = new System.Windows.Forms.Label();
            this.lblPSU = new System.Windows.Forms.Label();
            this.lblSSD = new System.Windows.Forms.Label();
            this.lblHDD = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblVGA = new System.Windows.Forms.Label();
            this.lblMB = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.cbCOOLER = new System.Windows.Forms.ComboBox();
            this.cbCASE = new System.Windows.Forms.ComboBox();
            this.cbPSU = new System.Windows.Forms.ComboBox();
            this.cbSSD = new System.Windows.Forms.ComboBox();
            this.cbHDD = new System.Windows.Forms.ComboBox();
            this.cbRAM = new System.Windows.Forms.ComboBox();
            this.cbVGA = new System.Windows.Forms.ComboBox();
            this.cbMB = new System.Windows.Forms.ComboBox();
            this.cbCPU = new System.Windows.Forms.ComboBox();
            this.cbMatType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProImg)).BeginInit();
            this.gbSpec.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(883, 459);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "등록";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(779, 459);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblMatType
            // 
            this.lblMatType.AutoSize = true;
            this.lblMatType.Location = new System.Drawing.Point(12, 15);
            this.lblMatType.Name = "lblMatType";
            this.lblMatType.Size = new System.Drawing.Size(57, 12);
            this.lblMatType.TabIndex = 2;
            this.lblMatType.Text = "제품 분류";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 54);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 12);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "가격";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "제품명";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(89, 51);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 21);
            this.tbPrice.TabIndex = 9;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(89, 91);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 10;
            // 
            // tbSpec
            // 
            this.tbSpec.Location = new System.Drawing.Point(369, 32);
            this.tbSpec.Multiline = true;
            this.tbSpec.Name = "tbSpec";
            this.tbSpec.Size = new System.Drawing.Size(308, 401);
            this.tbSpec.TabIndex = 11;
            // 
            // ofdProImg
            // 
            this.ofdProImg.FileName = "openFileDialog1";
            // 
            // pbProImg
            // 
            this.pbProImg.Location = new System.Drawing.Point(89, 133);
            this.pbProImg.Name = "pbProImg";
            this.pbProImg.Size = new System.Drawing.Size(250, 250);
            this.pbProImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProImg.TabIndex = 12;
            this.pbProImg.TabStop = false;
            // 
            // btnImgSearch
            // 
            this.btnImgSearch.Location = new System.Drawing.Point(89, 410);
            this.btnImgSearch.Name = "btnImgSearch";
            this.btnImgSearch.Size = new System.Drawing.Size(75, 23);
            this.btnImgSearch.TabIndex = 13;
            this.btnImgSearch.Text = "찾아보기";
            this.btnImgSearch.UseVisualStyleBackColor = true;
            this.btnImgSearch.Click += new System.EventHandler(this.btnImgSearch_Click);
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Location = new System.Drawing.Point(12, 133);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(41, 12);
            this.lblImg.TabIndex = 14;
            this.lblImg.Text = "이미지";
            // 
            // gbSpec
            // 
            this.gbSpec.Controls.Add(this.lblCOOLER);
            this.gbSpec.Controls.Add(this.lblCASE);
            this.gbSpec.Controls.Add(this.lblPSU);
            this.gbSpec.Controls.Add(this.lblSSD);
            this.gbSpec.Controls.Add(this.lblHDD);
            this.gbSpec.Controls.Add(this.lblRAM);
            this.gbSpec.Controls.Add(this.lblVGA);
            this.gbSpec.Controls.Add(this.lblMB);
            this.gbSpec.Controls.Add(this.lblCPU);
            this.gbSpec.Controls.Add(this.cbCOOLER);
            this.gbSpec.Controls.Add(this.cbCASE);
            this.gbSpec.Controls.Add(this.cbPSU);
            this.gbSpec.Controls.Add(this.cbSSD);
            this.gbSpec.Controls.Add(this.cbHDD);
            this.gbSpec.Controls.Add(this.cbRAM);
            this.gbSpec.Controls.Add(this.cbVGA);
            this.gbSpec.Controls.Add(this.cbMB);
            this.gbSpec.Controls.Add(this.cbCPU);
            this.gbSpec.Location = new System.Drawing.Point(350, 12);
            this.gbSpec.Name = "gbSpec";
            this.gbSpec.Size = new System.Drawing.Size(608, 441);
            this.gbSpec.TabIndex = 15;
            this.gbSpec.TabStop = false;
            this.gbSpec.Text = "제품 사양";
            // 
            // lblCOOLER
            // 
            this.lblCOOLER.AutoSize = true;
            this.lblCOOLER.Location = new System.Drawing.Point(373, 389);
            this.lblCOOLER.Name = "lblCOOLER";
            this.lblCOOLER.Size = new System.Drawing.Size(55, 12);
            this.lblCOOLER.TabIndex = 33;
            this.lblCOOLER.Text = "COOLER";
            // 
            // lblCASE
            // 
            this.lblCASE.AutoSize = true;
            this.lblCASE.Location = new System.Drawing.Point(373, 345);
            this.lblCASE.Name = "lblCASE";
            this.lblCASE.Size = new System.Drawing.Size(38, 12);
            this.lblCASE.TabIndex = 32;
            this.lblCASE.Text = "CASE";
            // 
            // lblPSU
            // 
            this.lblPSU.AutoSize = true;
            this.lblPSU.Location = new System.Drawing.Point(373, 301);
            this.lblPSU.Name = "lblPSU";
            this.lblPSU.Size = new System.Drawing.Size(29, 12);
            this.lblPSU.TabIndex = 31;
            this.lblPSU.Text = "PSU";
            // 
            // lblSSD
            // 
            this.lblSSD.AutoSize = true;
            this.lblSSD.Location = new System.Drawing.Point(373, 257);
            this.lblSSD.Name = "lblSSD";
            this.lblSSD.Size = new System.Drawing.Size(29, 12);
            this.lblSSD.TabIndex = 30;
            this.lblSSD.Text = "SSD";
            // 
            // lblHDD
            // 
            this.lblHDD.AutoSize = true;
            this.lblHDD.Location = new System.Drawing.Point(373, 213);
            this.lblHDD.Name = "lblHDD";
            this.lblHDD.Size = new System.Drawing.Size(29, 12);
            this.lblHDD.TabIndex = 29;
            this.lblHDD.Text = "HDD";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(373, 169);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(32, 12);
            this.lblRAM.TabIndex = 28;
            this.lblRAM.Text = "RAM";
            // 
            // lblVGA
            // 
            this.lblVGA.AutoSize = true;
            this.lblVGA.Location = new System.Drawing.Point(373, 125);
            this.lblVGA.Name = "lblVGA";
            this.lblVGA.Size = new System.Drawing.Size(30, 12);
            this.lblVGA.TabIndex = 27;
            this.lblVGA.Text = "VGA";
            // 
            // lblMB
            // 
            this.lblMB.AutoSize = true;
            this.lblMB.Location = new System.Drawing.Point(373, 81);
            this.lblMB.Name = "lblMB";
            this.lblMB.Size = new System.Drawing.Size(30, 12);
            this.lblMB.TabIndex = 26;
            this.lblMB.Text = "M/B";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(373, 37);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(30, 12);
            this.lblCPU.TabIndex = 25;
            this.lblCPU.Text = "CPU";
            // 
            // cbCOOLER
            // 
            this.cbCOOLER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCOOLER.FormattingEnabled = true;
            this.cbCOOLER.Location = new System.Drawing.Point(458, 386);
            this.cbCOOLER.Name = "cbCOOLER";
            this.cbCOOLER.Size = new System.Drawing.Size(121, 20);
            this.cbCOOLER.TabIndex = 24;
            // 
            // cbCASE
            // 
            this.cbCASE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCASE.FormattingEnabled = true;
            this.cbCASE.Location = new System.Drawing.Point(458, 342);
            this.cbCASE.Name = "cbCASE";
            this.cbCASE.Size = new System.Drawing.Size(121, 20);
            this.cbCASE.TabIndex = 23;
            // 
            // cbPSU
            // 
            this.cbPSU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPSU.FormattingEnabled = true;
            this.cbPSU.Location = new System.Drawing.Point(458, 298);
            this.cbPSU.Name = "cbPSU";
            this.cbPSU.Size = new System.Drawing.Size(121, 20);
            this.cbPSU.TabIndex = 22;
            // 
            // cbSSD
            // 
            this.cbSSD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSSD.FormattingEnabled = true;
            this.cbSSD.Location = new System.Drawing.Point(458, 254);
            this.cbSSD.Name = "cbSSD";
            this.cbSSD.Size = new System.Drawing.Size(121, 20);
            this.cbSSD.TabIndex = 21;
            // 
            // cbHDD
            // 
            this.cbHDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHDD.FormattingEnabled = true;
            this.cbHDD.Location = new System.Drawing.Point(458, 210);
            this.cbHDD.Name = "cbHDD";
            this.cbHDD.Size = new System.Drawing.Size(121, 20);
            this.cbHDD.TabIndex = 20;
            // 
            // cbRAM
            // 
            this.cbRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRAM.FormattingEnabled = true;
            this.cbRAM.Location = new System.Drawing.Point(458, 166);
            this.cbRAM.Name = "cbRAM";
            this.cbRAM.Size = new System.Drawing.Size(121, 20);
            this.cbRAM.TabIndex = 19;
            // 
            // cbVGA
            // 
            this.cbVGA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVGA.FormattingEnabled = true;
            this.cbVGA.Location = new System.Drawing.Point(458, 122);
            this.cbVGA.Name = "cbVGA";
            this.cbVGA.Size = new System.Drawing.Size(121, 20);
            this.cbVGA.TabIndex = 18;
            // 
            // cbMB
            // 
            this.cbMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMB.FormattingEnabled = true;
            this.cbMB.Location = new System.Drawing.Point(458, 78);
            this.cbMB.Name = "cbMB";
            this.cbMB.Size = new System.Drawing.Size(121, 20);
            this.cbMB.TabIndex = 17;
            // 
            // cbCPU
            // 
            this.cbCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCPU.FormattingEnabled = true;
            this.cbCPU.Location = new System.Drawing.Point(458, 34);
            this.cbCPU.Name = "cbCPU";
            this.cbCPU.Size = new System.Drawing.Size(121, 20);
            this.cbCPU.TabIndex = 16;
            // 
            // cbMatType
            // 
            this.cbMatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatType.FormattingEnabled = true;
            this.cbMatType.Location = new System.Drawing.Point(89, 12);
            this.cbMatType.Name = "cbMatType";
            this.cbMatType.Size = new System.Drawing.Size(121, 20);
            this.cbMatType.TabIndex = 34;
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 501);
            this.Controls.Add(this.cbMatType);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.btnImgSearch);
            this.Controls.Add(this.pbProImg);
            this.Controls.Add(this.tbSpec);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMatType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbSpec);
            this.Name = "FrmProducts";
            this.Text = "FrmProducts";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProImg)).EndInit();
            this.gbSpec.ResumeLayout(false);
            this.gbSpec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMatType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSpec;
        private System.Windows.Forms.OpenFileDialog ofdProImg;
        private System.Windows.Forms.PictureBox pbProImg;
        private System.Windows.Forms.Button btnImgSearch;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.GroupBox gbSpec;
        private System.Windows.Forms.ComboBox cbCOOLER;
        private System.Windows.Forms.ComboBox cbCASE;
        private System.Windows.Forms.ComboBox cbPSU;
        private System.Windows.Forms.ComboBox cbSSD;
        private System.Windows.Forms.ComboBox cbHDD;
        private System.Windows.Forms.ComboBox cbRAM;
        private System.Windows.Forms.ComboBox cbVGA;
        private System.Windows.Forms.ComboBox cbMB;
        private System.Windows.Forms.ComboBox cbCPU;
        private System.Windows.Forms.Label lblCOOLER;
        private System.Windows.Forms.Label lblCASE;
        private System.Windows.Forms.Label lblPSU;
        private System.Windows.Forms.Label lblSSD;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblVGA;
        private System.Windows.Forms.Label lblMB;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.ComboBox cbMatType;
    }
}