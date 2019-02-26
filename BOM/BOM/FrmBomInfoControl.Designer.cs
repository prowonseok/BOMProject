namespace BOM
{
    partial class FrmBomInfoControl
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
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnProEstimating = new System.Windows.Forms.Button();
            this.btnMatEstimating = new System.Windows.Forms.Button();
            this.btnBomInfo = new System.Windows.Forms.Button();
            this.dgvBom = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "자재명",
            "자재 번호",
            "자재 단계"});
            this.cbbType.Location = new System.Drawing.Point(268, 20);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(121, 20);
            this.cbbType.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(585, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(408, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 21);
            this.txtSearch.TabIndex = 14;
            // 
            // btnProEstimating
            // 
            this.btnProEstimating.Location = new System.Drawing.Point(414, 359);
            this.btnProEstimating.Name = "btnProEstimating";
            this.btnProEstimating.Size = new System.Drawing.Size(75, 23);
            this.btnProEstimating.TabIndex = 13;
            this.btnProEstimating.Text = "판매 예측";
            this.btnProEstimating.UseVisualStyleBackColor = true;
            // 
            // btnMatEstimating
            // 
            this.btnMatEstimating.Location = new System.Drawing.Point(301, 359);
            this.btnMatEstimating.Name = "btnMatEstimating";
            this.btnMatEstimating.Size = new System.Drawing.Size(88, 23);
            this.btnMatEstimating.TabIndex = 12;
            this.btnMatEstimating.Text = "소요량 예측";
            this.btnMatEstimating.UseVisualStyleBackColor = true;
            // 
            // btnBomInfo
            // 
            this.btnBomInfo.Location = new System.Drawing.Point(188, 359);
            this.btnBomInfo.Name = "btnBomInfo";
            this.btnBomInfo.Size = new System.Drawing.Size(75, 23);
            this.btnBomInfo.TabIndex = 11;
            this.btnBomInfo.Text = "BOM조회";
            this.btnBomInfo.UseVisualStyleBackColor = true;
            // 
            // dgvBom
            // 
            this.dgvBom.AllowUserToAddRows = false;
            this.dgvBom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBom.Location = new System.Drawing.Point(33, 49);
            this.dgvBom.MultiSelect = false;
            this.dgvBom.Name = "dgvBom";
            this.dgvBom.ReadOnly = true;
            this.dgvBom.RowTemplate.Height = 23;
            this.dgvBom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBom.Size = new System.Drawing.Size(627, 260);
            this.dgvBom.TabIndex = 9;
            this.dgvBom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBom_CellContentClick);
            // 
            // FrmBomInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnProEstimating);
            this.Controls.Add(this.btnMatEstimating);
            this.Controls.Add(this.btnBomInfo);
            this.Controls.Add(this.dgvBom);
            this.Name = "FrmBomInfoControl";
            this.Size = new System.Drawing.Size(683, 468);
            this.Load += new System.EventHandler(this.FrmBomInfoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnProEstimating;
        private System.Windows.Forms.Button btnMatEstimating;
        private System.Windows.Forms.Button btnBomInfo;
        private System.Windows.Forms.DataGridView dgvBom;
    }
}
