namespace BOM
{
    partial class FrmBomInfo
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
            this.dgvBom = new System.Windows.Forms.DataGridView();
            this.btnBomInfo = new System.Windows.Forms.Button();
            this.btnBomAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMatEstimating = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBom
            // 
            this.dgvBom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBom.Location = new System.Drawing.Point(12, 116);
            this.dgvBom.Name = "dgvBom";
            this.dgvBom.ReadOnly = true;
            this.dgvBom.RowTemplate.Height = 23;
            this.dgvBom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBom.Size = new System.Drawing.Size(627, 260);
            this.dgvBom.TabIndex = 0;
            this.dgvBom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBom_CellContentClick);
            // 
            // btnBomInfo
            // 
            this.btnBomInfo.Location = new System.Drawing.Point(125, 28);
            this.btnBomInfo.Name = "btnBomInfo";
            this.btnBomInfo.Size = new System.Drawing.Size(75, 23);
            this.btnBomInfo.TabIndex = 3;
            this.btnBomInfo.Text = "BOM조회";
            this.btnBomInfo.UseVisualStyleBackColor = true;
            this.btnBomInfo.Click += new System.EventHandler(this.btnBomInfo_Click);
            // 
            // btnBomAdd
            // 
            this.btnBomAdd.Location = new System.Drawing.Point(12, 28);
            this.btnBomAdd.Name = "btnBomAdd";
            this.btnBomAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBomAdd.TabIndex = 2;
            this.btnBomAdd.Text = "BOM등록";
            this.btnBomAdd.UseVisualStyleBackColor = true;
            this.btnBomAdd.Click += new System.EventHandler(this.btnBomAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "생산 예측";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMatEstimating
            // 
            this.btnMatEstimating.Location = new System.Drawing.Point(238, 28);
            this.btnMatEstimating.Name = "btnMatEstimating";
            this.btnMatEstimating.Size = new System.Drawing.Size(88, 23);
            this.btnMatEstimating.TabIndex = 4;
            this.btnMatEstimating.Text = "소요량 예측";
            this.btnMatEstimating.UseVisualStyleBackColor = true;
            this.btnMatEstimating.Click += new System.EventHandler(this.btnMatEstimating_Click);
            // 
            // FrmBomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMatEstimating);
            this.Controls.Add(this.btnBomInfo);
            this.Controls.Add(this.btnBomAdd);
            this.Controls.Add(this.dgvBom);
            this.Name = "FrmBomInfo";
            this.Text = "FrmBomInfo";
            this.Load += new System.EventHandler(this.FrmBomInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBom;
        private System.Windows.Forms.Button btnBomInfo;
        private System.Windows.Forms.Button btnBomAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMatEstimating;
    }
}