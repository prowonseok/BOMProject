namespace BOM
{
    partial class FrmMainControl
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
            this.dgvMainSales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMainSales
            // 
            this.dgvMainSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainSales.Location = new System.Drawing.Point(82, 109);
            this.dgvMainSales.Name = "dgvMainSales";
            this.dgvMainSales.RowTemplate.Height = 23;
            this.dgvMainSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMainSales.Size = new System.Drawing.Size(572, 245);
            this.dgvMainSales.TabIndex = 7;
            this.dgvMainSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMainSales_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(527, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "1분마다 자동으로 갱신";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "갱신";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMainSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "FrmMainControl";
            this.Size = new System.Drawing.Size(736, 483);
            this.Load += new System.EventHandler(this.FrmMainControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMainSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}
