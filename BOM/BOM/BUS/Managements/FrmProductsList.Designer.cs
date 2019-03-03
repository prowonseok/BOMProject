namespace BOM.BUS.Managements
{
    partial class FrmProductsList
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
            this.btnToProducts = new System.Windows.Forms.Button();
            this.dgvProductsList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToProducts
            // 
            this.btnToProducts.Location = new System.Drawing.Point(630, 365);
            this.btnToProducts.Name = "btnToProducts";
            this.btnToProducts.Size = new System.Drawing.Size(75, 23);
            this.btnToProducts.TabIndex = 3;
            this.btnToProducts.Text = "닫기";
            this.btnToProducts.UseVisualStyleBackColor = true;
            this.btnToProducts.Click += new System.EventHandler(this.btnToProducts_Click);
            // 
            // dgvProductsList
            // 
            this.dgvProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsList.Location = new System.Drawing.Point(12, 12);
            this.dgvProductsList.Name = "dgvProductsList";
            this.dgvProductsList.ReadOnly = true;
            this.dgvProductsList.RowTemplate.Height = 23;
            this.dgvProductsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductsList.Size = new System.Drawing.Size(693, 347);
            this.dgvProductsList.TabIndex = 2;
            this.dgvProductsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductsList_CellContentClick);
            // 
            // FrmProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 399);
            this.Controls.Add(this.btnToProducts);
            this.Controls.Add(this.dgvProductsList);
            this.Name = "FrmProductsList";
            this.Text = "상품 목록";
            this.Load += new System.EventHandler(this.FrmProductsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToProducts;
        private System.Windows.Forms.DataGridView dgvProductsList;
    }
}