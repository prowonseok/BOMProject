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
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMatAdd
            // 
            this.btnMatAdd.Location = new System.Drawing.Point(780, 409);
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
            this.Column1});
            this.dgvMatList.Location = new System.Drawing.Point(12, 12);
            this.dgvMatList.Name = "dgvMatList";
            this.dgvMatList.RowTemplate.Height = 23;
            this.dgvMatList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatList.Size = new System.Drawing.Size(848, 391);
            this.dgvMatList.TabIndex = 3;
            this.dgvMatList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvMatList_CellPainting);
            this.dgvMatList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMatList_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "선택";
            this.Column1.Name = "Column1";
            // 
            // FrmManageMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 440);
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}