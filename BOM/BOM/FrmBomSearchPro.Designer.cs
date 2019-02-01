namespace BOM
{
    partial class FrmBomSearchPro
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
            this.dgvProInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProInfo
            // 
            this.dgvProInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProInfo.Location = new System.Drawing.Point(30, 31);
            this.dgvProInfo.Name = "dgvProInfo";
            this.dgvProInfo.RowTemplate.Height = 23;
            this.dgvProInfo.Size = new System.Drawing.Size(663, 356);
            this.dgvProInfo.TabIndex = 0;
            // 
            // FrmBomSearchPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProInfo);
            this.Name = "FrmBomSearchPro";
            this.Text = "FrmBomSearchPro";
            this.Load += new System.EventHandler(this.FrmBomSearchPro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProInfo;
    }
}