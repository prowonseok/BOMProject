namespace CustomerApp.BUS
{
    partial class FrmLogin
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
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnFindPW = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnFindID = new System.Windows.Forms.Button();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(246, 91);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(92, 23);
            this.btnJoin.TabIndex = 40;
            this.btnJoin.Text = "회원가입";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnFindPW
            // 
            this.btnFindPW.Location = new System.Drawing.Point(148, 91);
            this.btnFindPW.Name = "btnFindPW";
            this.btnFindPW.Size = new System.Drawing.Size(92, 23);
            this.btnFindPW.TabIndex = 39;
            this.btnFindPW.Text = "패스워드 찾기";
            this.btnFindPW.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(263, 37);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 48);
            this.btnLogin.TabIndex = 38;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnFindID
            // 
            this.btnFindID.Location = new System.Drawing.Point(50, 91);
            this.btnFindID.Name = "btnFindID";
            this.btnFindID.Size = new System.Drawing.Size(92, 23);
            this.btnFindID.TabIndex = 37;
            this.btnFindID.Text = "아이디 찾기";
            this.btnFindID.UseVisualStyleBackColor = true;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(115, 64);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(142, 21);
            this.txtPW.TabIndex = 36;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(115, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(142, 21);
            this.txtID.TabIndex = 35;
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(48, 68);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(53, 12);
            this.lblPW.TabIndex = 34;
            this.lblPW.Text = "패스워드";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(60, 41);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 12);
            this.lblID.TabIndex = 33;
            this.lblID.Text = "아이디";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 147);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnFindPW);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnFindID);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblID);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnFindPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnFindID;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblID;
    }
}