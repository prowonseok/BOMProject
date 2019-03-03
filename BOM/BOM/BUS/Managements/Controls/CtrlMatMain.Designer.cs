namespace BOM.BUS.Managements.Controls
{
    partial class CtrlMatMain
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
            this.btnTypeAdd = new System.Windows.Forms.Button();
            this.dgvMatList = new System.Windows.Forms.DataGridView();
            this.checkCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnMatAdd = new System.Windows.Forms.Button();
            this.lblMatList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTypeAdd
            // 
            this.btnTypeAdd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTypeAdd.Location = new System.Drawing.Point(649, 435);
            this.btnTypeAdd.Name = "btnTypeAdd";
            this.btnTypeAdd.Size = new System.Drawing.Size(79, 23);
            this.btnTypeAdd.TabIndex = 8;
            this.btnTypeAdd.Text = "제품군 등록";
            this.btnTypeAdd.UseVisualStyleBackColor = true;
            this.btnTypeAdd.Click += new System.EventHandler(this.btnTypeAdd_Click);
            // 
            // dgvMatList
            // 
            this.dgvMatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkCol});
            this.dgvMatList.Location = new System.Drawing.Point(20, 57);
            this.dgvMatList.MultiSelect = false;
            this.dgvMatList.Name = "dgvMatList";
            this.dgvMatList.RowTemplate.Height = 23;
            this.dgvMatList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatList.Size = new System.Drawing.Size(789, 372);
            this.dgvMatList.TabIndex = 7;
            // 
            // checkCol
            // 
            this.checkCol.HeaderText = "선택";
            this.checkCol.Name = "checkCol";
            // 
            // btnMatAdd
            // 
            this.btnMatAdd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMatAdd.Location = new System.Drawing.Point(734, 435);
            this.btnMatAdd.Name = "btnMatAdd";
            this.btnMatAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMatAdd.TabIndex = 6;
            this.btnMatAdd.Text = "자재 등록";
            this.btnMatAdd.UseVisualStyleBackColor = true;
            this.btnMatAdd.Click += new System.EventHandler(this.btnMatAdd_Click);
            // 
            // lblMatList
            // 
            this.lblMatList.AutoSize = true;
            this.lblMatList.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMatList.Location = new System.Drawing.Point(18, 32);
            this.lblMatList.Name = "lblMatList";
            this.lblMatList.Size = new System.Drawing.Size(59, 15);
            this.lblMatList.TabIndex = 9;
            this.lblMatList.Text = "자재 현항";
            // 
            // CtrlMatMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblMatList);
            this.Controls.Add(this.btnTypeAdd);
            this.Controls.Add(this.dgvMatList);
            this.Controls.Add(this.btnMatAdd);
            this.Name = "CtrlMatMain";
            this.Size = new System.Drawing.Size(829, 486);
            this.Load += new System.EventHandler(this.CtrlMatMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTypeAdd;
        private System.Windows.Forms.DataGridView dgvMatList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkCol;
        private System.Windows.Forms.Button btnMatAdd;
        private System.Windows.Forms.Label lblMatList;
    }
}
