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
            this.tbMatType = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSpec = new System.Windows.Forms.TextBox();
            this.ofdProImg = new System.Windows.Forms.OpenFileDialog();
            this.pbProImg = new System.Windows.Forms.PictureBox();
            this.btnImgSearch = new System.Windows.Forms.Button();
            this.lblImg = new System.Windows.Forms.Label();
            this.gbSpec = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1085, 574);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "등록";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(981, 574);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblMatType
            // 
            this.lblMatType.AutoSize = true;
            this.lblMatType.Location = new System.Drawing.Point(45, 41);
            this.lblMatType.Name = "lblMatType";
            this.lblMatType.Size = new System.Drawing.Size(57, 12);
            this.lblMatType.TabIndex = 2;
            this.lblMatType.Text = "제품 분류";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(45, 99);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 12);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "가격";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 156);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "제품명";
            // 
            // tbMatType
            // 
            this.tbMatType.Location = new System.Drawing.Point(130, 38);
            this.tbMatType.Name = "tbMatType";
            this.tbMatType.Size = new System.Drawing.Size(100, 21);
            this.tbMatType.TabIndex = 8;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(130, 96);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 21);
            this.tbPrice.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(130, 153);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 10;
            // 
            // tbSpec
            // 
            this.tbSpec.Location = new System.Drawing.Point(459, 61);
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
            this.pbProImg.Location = new System.Drawing.Point(130, 218);
            this.pbProImg.Name = "pbProImg";
            this.pbProImg.Size = new System.Drawing.Size(237, 244);
            this.pbProImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProImg.TabIndex = 12;
            this.pbProImg.TabStop = false;
            // 
            // btnImgSearch
            // 
            this.btnImgSearch.Location = new System.Drawing.Point(130, 477);
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
            this.lblImg.Location = new System.Drawing.Point(45, 218);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(41, 12);
            this.lblImg.TabIndex = 14;
            this.lblImg.Text = "이미지";
            // 
            // gbSpec
            // 
            this.gbSpec.Location = new System.Drawing.Point(440, 41);
            this.gbSpec.Name = "gbSpec";
            this.gbSpec.Size = new System.Drawing.Size(720, 441);
            this.gbSpec.TabIndex = 15;
            this.gbSpec.TabStop = false;
            this.gbSpec.Text = "제품 사양";
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 609);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.btnImgSearch);
            this.Controls.Add(this.pbProImg);
            this.Controls.Add(this.tbSpec);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbMatType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMatType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbSpec);
            this.Name = "FrmProducts";
            this.Text = "FrmProducts";
            ((System.ComponentModel.ISupportInitialize)(this.pbProImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMatType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbMatType;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSpec;
        private System.Windows.Forms.OpenFileDialog ofdProImg;
        private System.Windows.Forms.PictureBox pbProImg;
        private System.Windows.Forms.Button btnImgSearch;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.GroupBox gbSpec;
    }
}