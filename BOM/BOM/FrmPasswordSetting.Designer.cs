namespace BOM
{
    partial class FrmPasswordSetting
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
            this.lblPrevPassword = new System.Windows.Forms.Label();
            this.tbPrevPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tbNewPasswordChk = new System.Windows.Forms.TextBox();
            this.lblNewPasswordChk = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrevPassword
            // 
            this.lblPrevPassword.AutoSize = true;
            this.lblPrevPassword.Location = new System.Drawing.Point(12, 9);
            this.lblPrevPassword.Name = "lblPrevPassword";
            this.lblPrevPassword.Size = new System.Drawing.Size(81, 12);
            this.lblPrevPassword.TabIndex = 0;
            this.lblPrevPassword.Text = "기존 비밀번호";
            // 
            // tbPrevPassword
            // 
            this.tbPrevPassword.Location = new System.Drawing.Point(14, 24);
            this.tbPrevPassword.Name = "tbPrevPassword";
            this.tbPrevPassword.Size = new System.Drawing.Size(102, 21);
            this.tbPrevPassword.TabIndex = 1;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(14, 75);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(100, 21);
            this.tbNewPassword.TabIndex = 3;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(12, 60);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(69, 12);
            this.lblNewPassword.TabIndex = 2;
            this.lblNewPassword.Text = "새 비밀번호";
            // 
            // tbNewPasswordChk
            // 
            this.tbNewPasswordChk.Location = new System.Drawing.Point(14, 126);
            this.tbNewPasswordChk.Name = "tbNewPasswordChk";
            this.tbNewPasswordChk.Size = new System.Drawing.Size(100, 21);
            this.tbNewPasswordChk.TabIndex = 5;
            // 
            // lblNewPasswordChk
            // 
            this.lblNewPasswordChk.AutoSize = true;
            this.lblNewPasswordChk.Location = new System.Drawing.Point(12, 111);
            this.lblNewPasswordChk.Name = "lblNewPasswordChk";
            this.lblNewPasswordChk.Size = new System.Drawing.Size(97, 12);
            this.lblNewPasswordChk.TabIndex = 4;
            this.lblNewPasswordChk.Text = "새 비밀번호 확인";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(71, 162);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(43, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "적용";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(14, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(43, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmPasswordSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(134, 203);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbNewPasswordChk);
            this.Controls.Add(this.lblNewPasswordChk);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.tbPrevPassword);
            this.Controls.Add(this.lblPrevPassword);
            this.Name = "FrmPasswordSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrevPassword;
        private System.Windows.Forms.TextBox tbPrevPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tbNewPasswordChk;
        private System.Windows.Forms.Label lblNewPasswordChk;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}