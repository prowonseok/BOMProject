namespace BOM
{
    partial class FrmBomMatEstimating
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.btnSearchPro = new System.Windows.Forms.Button();
            this.tvProMat = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "제품명 : ";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(88, 35);
            this.txtPName.Name = "txtPName";
            this.txtPName.ReadOnly = true;
            this.txtPName.Size = new System.Drawing.Size(148, 21);
            this.txtPName.TabIndex = 1;
            // 
            // btnSearchPro
            // 
            this.btnSearchPro.Location = new System.Drawing.Point(271, 33);
            this.btnSearchPro.Name = "btnSearchPro";
            this.btnSearchPro.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPro.TabIndex = 2;
            this.btnSearchPro.Text = "제품 찾기";
            this.btnSearchPro.UseVisualStyleBackColor = true;
            this.btnSearchPro.Click += new System.EventHandler(this.btnSearchPro_Click);
            // 
            // tvProMat
            // 
            this.tvProMat.Location = new System.Drawing.Point(31, 62);
            this.tvProMat.Name = "tvProMat";
            this.tvProMat.Size = new System.Drawing.Size(315, 313);
            this.tvProMat.TabIndex = 3;
            // 
            // FrmBomMatEstimating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 398);
            this.Controls.Add(this.tvProMat);
            this.Controls.Add(this.btnSearchPro);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.label1);
            this.Name = "FrmBomMatEstimating";
            this.Text = "FrmMatEstimating";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Button btnSearchPro;
        private System.Windows.Forms.TreeView tvProMat;
    }
}