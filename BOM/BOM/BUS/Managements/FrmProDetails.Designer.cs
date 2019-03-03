namespace BOM.BUS.Managements
{
    partial class FrmProDetails
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
            this.lblProNo = new System.Windows.Forms.Label();
            this.lblMatNo = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.lblChangeDate = new System.Windows.Forms.Label();
            this.tbProNo = new System.Windows.Forms.TextBox();
            this.tbMatNo = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tbChangeDate = new System.Windows.Forms.TextBox();
            this.tbSpec = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProNo
            // 
            this.lblProNo.AutoSize = true;
            this.lblProNo.Location = new System.Drawing.Point(27, 21);
            this.lblProNo.Name = "lblProNo";
            this.lblProNo.Size = new System.Drawing.Size(57, 12);
            this.lblProNo.TabIndex = 0;
            this.lblProNo.Text = "상품 번호";
            // 
            // lblMatNo
            // 
            this.lblMatNo.AutoSize = true;
            this.lblMatNo.Location = new System.Drawing.Point(27, 60);
            this.lblMatNo.Name = "lblMatNo";
            this.lblMatNo.Size = new System.Drawing.Size(57, 12);
            this.lblMatNo.TabIndex = 1;
            this.lblMatNo.Text = "자재 번호";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(55, 99);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 12);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "가격";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 138);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "상품명";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.Location = new System.Drawing.Point(15, 213);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(41, 12);
            this.lblSpec.TabIndex = 4;
            this.lblSpec.Text = "구성품";
            // 
            // lblChangeDate
            // 
            this.lblChangeDate.AutoSize = true;
            this.lblChangeDate.Location = new System.Drawing.Point(15, 177);
            this.lblChangeDate.Name = "lblChangeDate";
            this.lblChangeDate.Size = new System.Drawing.Size(69, 12);
            this.lblChangeDate.TabIndex = 6;
            this.lblChangeDate.Text = "가격 변경일";
            // 
            // tbProNo
            // 
            this.tbProNo.Location = new System.Drawing.Point(90, 18);
            this.tbProNo.Name = "tbProNo";
            this.tbProNo.ReadOnly = true;
            this.tbProNo.Size = new System.Drawing.Size(100, 21);
            this.tbProNo.TabIndex = 7;
            // 
            // tbMatNo
            // 
            this.tbMatNo.Location = new System.Drawing.Point(90, 57);
            this.tbMatNo.Name = "tbMatNo";
            this.tbMatNo.ReadOnly = true;
            this.tbMatNo.Size = new System.Drawing.Size(100, 21);
            this.tbMatNo.TabIndex = 8;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(90, 96);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(100, 21);
            this.tbPrice.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(90, 135);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 10;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(212, 18);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(180, 180);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 11;
            this.pbImage.TabStop = false;
            // 
            // tbChangeDate
            // 
            this.tbChangeDate.Location = new System.Drawing.Point(90, 174);
            this.tbChangeDate.Name = "tbChangeDate";
            this.tbChangeDate.ReadOnly = true;
            this.tbChangeDate.Size = new System.Drawing.Size(100, 21);
            this.tbChangeDate.TabIndex = 12;
            // 
            // tbSpec
            // 
            this.tbSpec.Location = new System.Drawing.Point(17, 242);
            this.tbSpec.Multiline = true;
            this.tbSpec.Name = "tbSpec";
            this.tbSpec.ReadOnly = true;
            this.tbSpec.Size = new System.Drawing.Size(375, 299);
            this.tbSpec.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 547);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "닫기";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmProDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 583);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbSpec);
            this.Controls.Add(this.tbChangeDate);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbMatNo);
            this.Controls.Add(this.tbProNo);
            this.Controls.Add(this.lblChangeDate);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMatNo);
            this.Controls.Add(this.lblProNo);
            this.Name = "FrmProDetails";
            this.Text = "제품 상세 정보";
            this.Load += new System.EventHandler(this.FrmProDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProNo;
        private System.Windows.Forms.Label lblMatNo;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.Label lblChangeDate;
        private System.Windows.Forms.TextBox tbProNo;
        private System.Windows.Forms.TextBox tbMatNo;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox tbChangeDate;
        private System.Windows.Forms.TextBox tbSpec;
        private System.Windows.Forms.Button btnCancel;
    }
}