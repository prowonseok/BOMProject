namespace CustomerApp.BUS
{
    partial class FrmJoin
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.lblPW = new System.Windows.Forms.Label();
            this.txtChkPW = new System.Windows.Forms.TextBox();
            this.lblChkPW = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.lblAddr = new System.Windows.Forms.Label();
            this.txtEmailID = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtAddrDetail = new System.Windows.Forms.TextBox();
            this.lblAddrDetail = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnAddr = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAt = new System.Windows.Forms.Label();
            this.txtEmailSite = new System.Windows.Forms.TextBox();
            this.cbxEmail = new System.Windows.Forms.ComboBox();
            this.lblPWState = new System.Windows.Forms.Label();
            this.lblChkPWState = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnChkID = new System.Windows.Forms.Button();
            this.lblEmailState = new System.Windows.Forms.Label();
            this.lblMust = new System.Windows.Forms.Label();
            this.lblPhoneState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(56, 70);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(51, 12);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "* 아이디";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(121, 66);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(182, 21);
            this.txtID.TabIndex = 1;
            this.txtID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyUp);
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(121, 111);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(182, 21);
            this.txtPW.TabIndex = 3;
            this.txtPW.TextChanged += new System.EventHandler(this.txtPW_TextChanged);
            this.txtPW.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPW_KeyUp);
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(44, 115);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(63, 12);
            this.lblPW.TabIndex = 2;
            this.lblPW.Text = "* 비밀번호";
            // 
            // txtChkPW
            // 
            this.txtChkPW.Location = new System.Drawing.Point(121, 174);
            this.txtChkPW.Name = "txtChkPW";
            this.txtChkPW.Size = new System.Drawing.Size(182, 21);
            this.txtChkPW.TabIndex = 4;
            this.txtChkPW.TextChanged += new System.EventHandler(this.txtChkPW_TextChanged);
            // 
            // lblChkPW
            // 
            this.lblChkPW.AutoSize = true;
            this.lblChkPW.Location = new System.Drawing.Point(16, 178);
            this.lblChkPW.Name = "lblChkPW";
            this.lblChkPW.Size = new System.Drawing.Size(91, 12);
            this.lblChkPW.TabIndex = 4;
            this.lblChkPW.Text = "* 비밀번호 확인";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(44, 224);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 12);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "* 전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "* (8자리 ~ 12자리 / 영문 대문자, 소문자, 숫자, 특수기호 조합)";
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(121, 266);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(407, 21);
            this.txtAddr.TabIndex = 10;
            this.txtAddr.TabStop = false;
            this.txtAddr.TextChanged += new System.EventHandler(this.txtAddr_TextChanged);
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(68, 270);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(39, 12);
            this.lblAddr.TabIndex = 9;
            this.lblAddr.Text = "* 주소";
            // 
            // txtEmailID
            // 
            this.txtEmailID.Location = new System.Drawing.Point(121, 357);
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(124, 21);
            this.txtEmailID.TabIndex = 8;
            this.txtEmailID.TextChanged += new System.EventHandler(this.txtEmailID_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(60, 361);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 12);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "* Email";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 29);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Goodee PC 회원가입";
            // 
            // txtAddrDetail
            // 
            this.txtAddrDetail.Location = new System.Drawing.Point(121, 293);
            this.txtAddrDetail.Name = "txtAddrDetail";
            this.txtAddrDetail.Size = new System.Drawing.Size(407, 21);
            this.txtAddrDetail.TabIndex = 7;
            // 
            // lblAddrDetail
            // 
            this.lblAddrDetail.AutoSize = true;
            this.lblAddrDetail.Location = new System.Drawing.Point(54, 297);
            this.lblAddrDetail.Name = "lblAddrDetail";
            this.lblAddrDetail.Size = new System.Drawing.Size(53, 12);
            this.lblAddrDetail.TabIndex = 14;
            this.lblAddrDetail.Text = "상세주소";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(379, 412);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Text = "회원가입";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnAddr
            // 
            this.btnAddr.Location = new System.Drawing.Point(453, 320);
            this.btnAddr.Name = "btnAddr";
            this.btnAddr.Size = new System.Drawing.Size(75, 23);
            this.btnAddr.TabIndex = 6;
            this.btnAddr.Text = "주소찾기";
            this.btnAddr.UseVisualStyleBackColor = true;
            this.btnAddr.Click += new System.EventHandler(this.btnAddr_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(460, 412);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "취소";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAt
            // 
            this.lblAt.AutoSize = true;
            this.lblAt.Location = new System.Drawing.Point(248, 361);
            this.lblAt.Name = "lblAt";
            this.lblAt.Size = new System.Drawing.Size(17, 12);
            this.lblAt.TabIndex = 19;
            this.lblAt.Text = "@";
            // 
            // txtEmailSite
            // 
            this.txtEmailSite.Location = new System.Drawing.Point(268, 357);
            this.txtEmailSite.Name = "txtEmailSite";
            this.txtEmailSite.Size = new System.Drawing.Size(127, 21);
            this.txtEmailSite.TabIndex = 10;
            this.txtEmailSite.TextChanged += new System.EventHandler(this.txtEmailSite_TextChanged);
            // 
            // cbxEmail
            // 
            this.cbxEmail.FormattingEnabled = true;
            this.cbxEmail.Location = new System.Drawing.Point(407, 357);
            this.cbxEmail.Name = "cbxEmail";
            this.cbxEmail.Size = new System.Drawing.Size(121, 20);
            this.cbxEmail.TabIndex = 9;
            this.cbxEmail.Text = "선택하세요";
            this.cbxEmail.SelectedIndexChanged += new System.EventHandler(this.cbxEmail_SelectedIndexChanged);
            // 
            // lblPWState
            // 
            this.lblPWState.AutoSize = true;
            this.lblPWState.Location = new System.Drawing.Point(309, 114);
            this.lblPWState.Name = "lblPWState";
            this.lblPWState.Size = new System.Drawing.Size(0, 12);
            this.lblPWState.TabIndex = 22;
            // 
            // lblChkPWState
            // 
            this.lblChkPWState.AutoSize = true;
            this.lblChkPWState.Location = new System.Drawing.Point(309, 178);
            this.lblChkPWState.Name = "lblChkPWState";
            this.lblChkPWState.Size = new System.Drawing.Size(0, 12);
            this.lblChkPWState.TabIndex = 23;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(121, 221);
            this.txtPhone.Mask = "000-9000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(182, 21);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // btnChkID
            // 
            this.btnChkID.Location = new System.Drawing.Point(311, 64);
            this.btnChkID.Name = "btnChkID";
            this.btnChkID.Size = new System.Drawing.Size(75, 23);
            this.btnChkID.TabIndex = 2;
            this.btnChkID.Text = "중복확인";
            this.btnChkID.UseVisualStyleBackColor = true;
            // 
            // lblEmailState
            // 
            this.lblEmailState.AutoSize = true;
            this.lblEmailState.Location = new System.Drawing.Point(121, 381);
            this.lblEmailState.Name = "lblEmailState";
            this.lblEmailState.Size = new System.Drawing.Size(0, 12);
            this.lblEmailState.TabIndex = 26;
            // 
            // lblMust
            // 
            this.lblMust.AutoSize = true;
            this.lblMust.Location = new System.Drawing.Point(474, 9);
            this.lblMust.Name = "lblMust";
            this.lblMust.Size = new System.Drawing.Size(63, 12);
            this.lblMust.TabIndex = 27;
            this.lblMust.Text = "* 필수항목";
            // 
            // lblPhoneState
            // 
            this.lblPhoneState.AutoSize = true;
            this.lblPhoneState.Location = new System.Drawing.Point(309, 225);
            this.lblPhoneState.Name = "lblPhoneState";
            this.lblPhoneState.Size = new System.Drawing.Size(0, 12);
            this.lblPhoneState.TabIndex = 28;
            // 
            // FrmJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 447);
            this.Controls.Add(this.lblPhoneState);
            this.Controls.Add(this.lblMust);
            this.Controls.Add(this.lblEmailState);
            this.Controls.Add(this.btnChkID);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblChkPWState);
            this.Controls.Add(this.lblPWState);
            this.Controls.Add(this.cbxEmail);
            this.Controls.Add(this.txtEmailSite);
            this.Controls.Add(this.lblAt);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddr);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAddrDetail);
            this.Controls.Add(this.lblAddrDetail);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtEmailID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.lblAddr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtChkPW);
            this.Controls.Add(this.lblChkPW);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Name = "FrmJoin";
            this.Text = "FrmJoin";
            this.Load += new System.EventHandler(this.FrmJoin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox txtChkPW;
        private System.Windows.Forms.Label lblChkPW;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.TextBox txtEmailID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtAddrDetail;
        private System.Windows.Forms.Label lblAddrDetail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnAddr;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAt;
        private System.Windows.Forms.TextBox txtEmailSite;
        private System.Windows.Forms.ComboBox cbxEmail;
        private System.Windows.Forms.Label lblPWState;
        private System.Windows.Forms.Label lblChkPWState;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Button btnChkID;
        private System.Windows.Forms.Label lblEmailState;
        private System.Windows.Forms.Label lblMust;
        private System.Windows.Forms.Label lblPhoneState;
    }
}