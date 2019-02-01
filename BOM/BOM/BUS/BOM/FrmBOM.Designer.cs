namespace BOM.BUS.BOM
{
    partial class FrmBOM
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
            this.btnBomAdd = new System.Windows.Forms.Button();
            this.btnBomInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBomAdd
            // 
            this.btnBomAdd.Location = new System.Drawing.Point(265, 150);
            this.btnBomAdd.Name = "btnBomAdd";
            this.btnBomAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBomAdd.TabIndex = 0;
            this.btnBomAdd.Text = "BOM등록";
            this.btnBomAdd.UseVisualStyleBackColor = true;
            this.btnBomAdd.Click += new System.EventHandler(this.btnBom_Click);
            // 
            // btnBomInfo
            // 
            this.btnBomInfo.Location = new System.Drawing.Point(376, 150);
            this.btnBomInfo.Name = "btnBomInfo";
            this.btnBomInfo.Size = new System.Drawing.Size(75, 23);
            this.btnBomInfo.TabIndex = 1;
            this.btnBomInfo.Text = "BOM조회";
            this.btnBomInfo.UseVisualStyleBackColor = true;
            this.btnBomInfo.Click += new System.EventHandler(this.btnBomInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBomInfo);
            this.Controls.Add(this.btnBomAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBomAdd;
        private System.Windows.Forms.Button btnBomInfo;
    }
}

