namespace BOM.BUS.Managements
{
    partial class CtrlAS
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvASList = new System.Windows.Forms.DataGridView();
            this.btnASList = new System.Windows.Forms.Button();
            this.lblASList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvASList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvASList
            // 
            this.dgvASList.Location = new System.Drawing.Point(20, 30);
            this.dgvASList.MultiSelect = false;
            this.dgvASList.Name = "dgvASList";
            this.dgvASList.ReadOnly = true;
            this.dgvASList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvASList.Size = new System.Drawing.Size(735, 394);
            this.dgvASList.TabIndex = 0;
            this.dgvASList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvASList_CellContentClick);
            // 
            // btnASList
            // 
            this.btnASList.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.btnASList.Location = new System.Drawing.Point(680, 430);
            this.btnASList.Name = "btnASList";
            this.btnASList.Size = new System.Drawing.Size(75, 23);
            this.btnASList.TabIndex = 1;
            this.btnASList.Text = "처리 내역";
            this.btnASList.UseVisualStyleBackColor = true;
            this.btnASList.Click += new System.EventHandler(this.btnASList_Click);
            // 
            // lblASList
            // 
            this.lblASList.AutoSize = true;
            this.lblASList.Location = new System.Drawing.Point(20, 15);
            this.lblASList.Name = "lblASList";
            this.lblASList.Size = new System.Drawing.Size(83, 12);
            this.lblASList.TabIndex = 2;
            this.lblASList.Text = "A/S 접수 내역";
            // 
            // CtrlAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblASList);
            this.Controls.Add(this.btnASList);
            this.Controls.Add(this.dgvASList);
            this.Name = "CtrlAS";
            this.Size = new System.Drawing.Size(794, 495);
            this.Load += new System.EventHandler(this.CtrlAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvASList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvASList;
        private System.Windows.Forms.Button btnASList;
        private System.Windows.Forms.Label lblASList;
    }
}
