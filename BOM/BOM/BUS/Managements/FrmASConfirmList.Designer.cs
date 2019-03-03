namespace BOM.BUS.Managements
{
    partial class FrmASConfirmList
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
            this.dgvASDetailsList = new System.Windows.Forms.DataGridView();
            this.lblASList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvASDetailsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvASDetailsList
            // 
            this.dgvASDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvASDetailsList.Location = new System.Drawing.Point(12, 32);
            this.dgvASDetailsList.Name = "dgvASDetailsList";
            this.dgvASDetailsList.RowTemplate.Height = 23;
            this.dgvASDetailsList.Size = new System.Drawing.Size(601, 386);
            this.dgvASDetailsList.TabIndex = 0;
            // 
            // lblASList
            // 
            this.lblASList.AutoSize = true;
            this.lblASList.Location = new System.Drawing.Point(12, 17);
            this.lblASList.Name = "lblASList";
            this.lblASList.Size = new System.Drawing.Size(77, 12);
            this.lblASList.TabIndex = 1;
            this.lblASList.Text = "AS 처리 내역";
            // 
            // FrmASConfirmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblASList);
            this.Controls.Add(this.dgvASDetailsList);
            this.Name = "FrmASConfirmList";
            this.Text = "AS 처리 내역";
            this.Load += new System.EventHandler(this.FrmASConfirmList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvASDetailsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvASDetailsList;
        private System.Windows.Forms.Label lblASList;
    }
}