namespace CustomerApp.BUS
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnAS = new System.Windows.Forms.Button();
            this.panTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panBottom = new System.Windows.Forms.Panel();
            this.lstView = new System.Windows.Forms.ListView();
            this.panTop.SuspendLayout();
            this.panBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(1062, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(1156, 12);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 23);
            this.btnJoin.TabIndex = 1;
            this.btnJoin.Text = "회원가입";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("휴먼편지체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(121, 28);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Goodee PC";
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(12, 50);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(65, 73);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "상품보기";
            this.btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(105, 50);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(65, 73);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "구매하기";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // btnAS
            // 
            this.btnAS.Location = new System.Drawing.Point(198, 50);
            this.btnAS.Name = "btnAS";
            this.btnAS.Size = new System.Drawing.Size(65, 73);
            this.btnAS.TabIndex = 2;
            this.btnAS.Text = "A/S 문의";
            this.btnAS.UseVisualStyleBackColor = true;
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.label1);
            this.panTop.Controls.Add(this.lblTitle);
            this.panTop.Controls.Add(this.btnLogin);
            this.panTop.Controls.Add(this.btnJoin);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1244, 44);
            this.panTop.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(1140, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "l";
            // 
            // panBottom
            // 
            this.panBottom.Controls.Add(this.lstView);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 129);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(1244, 569);
            this.panBottom.TabIndex = 4;
            // 
            // lstView
            // 
            this.lstView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstView.Location = new System.Drawing.Point(0, 0);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(1244, 569);
            this.lstView.TabIndex = 0;
            this.lstView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 698);
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.btnAS);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.panBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnAS;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.ListView lstView;
    }
}

