namespace BOM.BUS.Managements
{
    partial class FrmASDetails
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
            this.btnASFix = new System.Windows.Forms.Button();
            this.lblASNo = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProName = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.tbASNo = new System.Windows.Forms.TextBox();
            this.tbCusName = new System.Windows.Forms.TextBox();
            this.tbEmployee = new System.Windows.Forms.TextBox();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.tbOrderNo = new System.Windows.Forms.TextBox();
            this.tbProdName = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnASFix
            // 
            this.btnASFix.Location = new System.Drawing.Point(331, 493);
            this.btnASFix.Name = "btnASFix";
            this.btnASFix.Size = new System.Drawing.Size(75, 23);
            this.btnASFix.TabIndex = 0;
            this.btnASFix.Text = "AS 처리";
            this.btnASFix.UseVisualStyleBackColor = true;
            this.btnASFix.Click += new System.EventHandler(this.btnASFix_Click);
            // 
            // lblASNo
            // 
            this.lblASNo.AutoSize = true;
            this.lblASNo.Location = new System.Drawing.Point(12, 23);
            this.lblASNo.Name = "lblASNo";
            this.lblASNo.Size = new System.Drawing.Size(77, 12);
            this.lblASNo.TabIndex = 1;
            this.lblASNo.Text = "AS 신청 번호";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Location = new System.Drawing.Point(232, 23);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(57, 12);
            this.lblOrderNo.TabIndex = 2;
            this.lblOrderNo.Text = "주문 번호";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "고객명";
            // 
            // lblProName
            // 
            this.lblProName.AutoSize = true;
            this.lblProName.Location = new System.Drawing.Point(248, 70);
            this.lblProName.Name = "lblProName";
            this.lblProName.Size = new System.Drawing.Size(41, 12);
            this.lblProName.TabIndex = 4;
            this.lblProName.Text = "상품명";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(32, 211);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(57, 12);
            this.lblContent.TabIndex = 5;
            this.lblContent.Text = "상세 내용";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(260, 117);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 12);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "비용";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(32, 164);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(57, 12);
            this.lblStartDate.TabIndex = 7;
            this.lblStartDate.Text = "시작 일시";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(232, 164);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(57, 12);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "종료 일시";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(48, 117);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(41, 12);
            this.lblEmployee.TabIndex = 9;
            this.lblEmployee.Text = "담당자";
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(28, 242);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ReadOnly = true;
            this.tbContent.Size = new System.Drawing.Size(378, 234);
            this.tbContent.TabIndex = 10;
            // 
            // tbASNo
            // 
            this.tbASNo.Location = new System.Drawing.Point(109, 20);
            this.tbASNo.Name = "tbASNo";
            this.tbASNo.ReadOnly = true;
            this.tbASNo.Size = new System.Drawing.Size(100, 21);
            this.tbASNo.TabIndex = 11;
            // 
            // tbCusName
            // 
            this.tbCusName.Location = new System.Drawing.Point(109, 67);
            this.tbCusName.Name = "tbCusName";
            this.tbCusName.ReadOnly = true;
            this.tbCusName.Size = new System.Drawing.Size(100, 21);
            this.tbCusName.TabIndex = 12;
            // 
            // tbEmployee
            // 
            this.tbEmployee.Location = new System.Drawing.Point(109, 114);
            this.tbEmployee.Name = "tbEmployee";
            this.tbEmployee.ReadOnly = true;
            this.tbEmployee.Size = new System.Drawing.Size(100, 21);
            this.tbEmployee.TabIndex = 13;
            // 
            // tbStartDate
            // 
            this.tbStartDate.Location = new System.Drawing.Point(109, 161);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.ReadOnly = true;
            this.tbStartDate.Size = new System.Drawing.Size(100, 21);
            this.tbStartDate.TabIndex = 14;
            // 
            // tbOrderNo
            // 
            this.tbOrderNo.Location = new System.Drawing.Point(306, 20);
            this.tbOrderNo.Name = "tbOrderNo";
            this.tbOrderNo.ReadOnly = true;
            this.tbOrderNo.Size = new System.Drawing.Size(100, 21);
            this.tbOrderNo.TabIndex = 15;
            // 
            // tbProdName
            // 
            this.tbProdName.Location = new System.Drawing.Point(306, 67);
            this.tbProdName.Name = "tbProdName";
            this.tbProdName.ReadOnly = true;
            this.tbProdName.Size = new System.Drawing.Size(100, 21);
            this.tbProdName.TabIndex = 16;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(306, 114);
            this.tbCost.Name = "tbCost";
            this.tbCost.ReadOnly = true;
            this.tbCost.Size = new System.Drawing.Size(100, 21);
            this.tbCost.TabIndex = 17;
            // 
            // tbEndDate
            // 
            this.tbEndDate.Location = new System.Drawing.Point(306, 161);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.ReadOnly = true;
            this.tbEndDate.Size = new System.Drawing.Size(100, 21);
            this.tbEndDate.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(250, 493);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmASDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 546);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbEndDate);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.tbProdName);
            this.Controls.Add(this.tbOrderNo);
            this.Controls.Add(this.tbStartDate);
            this.Controls.Add(this.tbEmployee);
            this.Controls.Add(this.tbCusName);
            this.Controls.Add(this.tbASNo);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblProName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.lblASNo);
            this.Controls.Add(this.btnASFix);
            this.Name = "FrmASDetails";
            this.Text = "AS 상세 정보";
            this.Load += new System.EventHandler(this.FrmASDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnASFix;
        private System.Windows.Forms.Label lblASNo;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProName;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.TextBox tbASNo;
        private System.Windows.Forms.TextBox tbCusName;
        private System.Windows.Forms.TextBox tbEmployee;
        private System.Windows.Forms.TextBox tbStartDate;
        private System.Windows.Forms.TextBox tbOrderNo;
        private System.Windows.Forms.TextBox tbProdName;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox tbEndDate;
        private System.Windows.Forms.Button btnCancel;
    }
}