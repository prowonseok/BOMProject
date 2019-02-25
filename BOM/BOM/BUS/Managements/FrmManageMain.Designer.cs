namespace BOM.BUS.Managements
{
    partial class FrmManageMain
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
            this.btnMatAdd = new System.Windows.Forms.Button();
            this.dgvMatList = new System.Windows.Forms.DataGridView();
            this.checkCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnTypeAdd = new System.Windows.Forms.Button();
            this.btnProAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMatAdd
            // 
            this.btnMatAdd.Location = new System.Drawing.Point(785, 66);
            this.btnMatAdd.Name = "btnMatAdd";
            this.btnMatAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMatAdd.TabIndex = 0;
            this.btnMatAdd.Text = "등록";
            this.btnMatAdd.UseVisualStyleBackColor = true;
            this.btnMatAdd.Click += new System.EventHandler(this.btnMatAdd_Click);
            // 
            // dgvMatList
            // 
            this.dgvMatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkCol});
            this.dgvMatList.Location = new System.Drawing.Point(12, 95);
            this.dgvMatList.MultiSelect = false;
            this.dgvMatList.Name = "dgvMatList";
            this.dgvMatList.RowTemplate.Height = 23;
            this.dgvMatList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatList.Size = new System.Drawing.Size(848, 391);
            this.dgvMatList.TabIndex = 3;
            this.dgvMatList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMatList_MouseClick);
            // 
            // checkCol
            // 
            this.checkCol.HeaderText = "선택";
            this.checkCol.Name = "checkCol";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(12, 66);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "발주";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnTypeAdd
            // 
            this.btnTypeAdd.Location = new System.Drawing.Point(414, 66);
            this.btnTypeAdd.Name = "btnTypeAdd";
            this.btnTypeAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTypeAdd.TabIndex = 5;
            this.btnTypeAdd.Text = "타입 추가";
            this.btnTypeAdd.UseVisualStyleBackColor = true;
            this.btnTypeAdd.Click += new System.EventHandler(this.btnTypeAdd_Click);
            // 
            // btnProAdd
            // 
            this.btnProAdd.Location = new System.Drawing.Point(245, 66);
            this.btnProAdd.Name = "btnProAdd";
            this.btnProAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProAdd.TabIndex = 6;
            this.btnProAdd.Text = "상품추가";
            this.btnProAdd.UseVisualStyleBackColor = true;
            this.btnProAdd.Click += new System.EventHandler(this.btnProAdd_Click);
            // 
            // FrmManageMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 498);
            this.Controls.Add(this.btnProAdd);
            this.Controls.Add(this.btnTypeAdd);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.dgvMatList);
            this.Controls.Add(this.btnMatAdd);
            this.Name = "FrmManageMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmManageMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMatAdd;
        private System.Windows.Forms.DataGridView dgvMatList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkCol;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnTypeAdd;
        private System.Windows.Forms.Button btnProAdd;
    }
}