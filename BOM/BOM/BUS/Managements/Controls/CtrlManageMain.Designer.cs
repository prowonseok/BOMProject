namespace BOM.BUS.Managements.Controls
{
    partial class CtrlManageMain
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
            this.btnProAdd = new System.Windows.Forms.Button();
            this.btnTypeAdd = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.dgvMatList = new System.Windows.Forms.DataGridView();
            this.checkCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnMatAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProAdd
            // 
            this.btnProAdd.Location = new System.Drawing.Point(253, 58);
            this.btnProAdd.Name = "btnProAdd";
            this.btnProAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProAdd.TabIndex = 11;
            this.btnProAdd.Text = "상품추가";
            this.btnProAdd.UseVisualStyleBackColor = true;
            // 
            // btnTypeAdd
            // 
            this.btnTypeAdd.Location = new System.Drawing.Point(422, 58);
            this.btnTypeAdd.Name = "btnTypeAdd";
            this.btnTypeAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTypeAdd.TabIndex = 10;
            this.btnTypeAdd.Text = "타입 추가";
            this.btnTypeAdd.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(20, 58);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 9;
            this.btnOrder.Text = "발주";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // dgvMatList
            // 
            this.dgvMatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkCol});
            this.dgvMatList.Location = new System.Drawing.Point(20, 87);
            this.dgvMatList.MultiSelect = false;
            this.dgvMatList.Name = "dgvMatList";
            this.dgvMatList.RowTemplate.Height = 23;
            this.dgvMatList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatList.Size = new System.Drawing.Size(848, 391);
            this.dgvMatList.TabIndex = 8;
            // 
            // checkCol
            // 
            this.checkCol.HeaderText = "선택";
            this.checkCol.Name = "checkCol";
            // 
            // btnMatAdd
            // 
            this.btnMatAdd.Location = new System.Drawing.Point(793, 58);
            this.btnMatAdd.Name = "btnMatAdd";
            this.btnMatAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMatAdd.TabIndex = 7;
            this.btnMatAdd.Text = "등록";
            this.btnMatAdd.UseVisualStyleBackColor = true;
            // 
            // CtrlManageMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnProAdd);
            this.Controls.Add(this.btnTypeAdd);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.dgvMatList);
            this.Controls.Add(this.btnMatAdd);
            this.Name = "CtrlManageMain";
            this.Size = new System.Drawing.Size(888, 537);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProAdd;
        private System.Windows.Forms.Button btnTypeAdd;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridView dgvMatList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkCol;
        private System.Windows.Forms.Button btnMatAdd;
    }
}
