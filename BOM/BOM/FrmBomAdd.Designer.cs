namespace BOM
{
    partial class FrmBomAdd
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
            this.lblChildMatNo = new System.Windows.Forms.Label();
            this.txtChildMatNo = new System.Windows.Forms.TextBox();
            this.txtChildMatName = new System.Windows.Forms.TextBox();
            this.lblChildMatName = new System.Windows.Forms.Label();
            this.btnMatSearch = new System.Windows.Forms.Button();
            this.txtChildMatEA = new System.Windows.Forms.TextBox();
            this.lblChildMatEA = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChildMatNo
            // 
            this.lblChildMatNo.AutoSize = true;
            this.lblChildMatNo.Location = new System.Drawing.Point(15, 41);
            this.lblChildMatNo.Name = "lblChildMatNo";
            this.lblChildMatNo.Size = new System.Drawing.Size(69, 12);
            this.lblChildMatNo.TabIndex = 0;
            this.lblChildMatNo.Text = "품목 번호 : ";
            // 
            // txtChildMatNo
            // 
            this.txtChildMatNo.Location = new System.Drawing.Point(90, 38);
            this.txtChildMatNo.Name = "txtChildMatNo";
            this.txtChildMatNo.Size = new System.Drawing.Size(100, 21);
            this.txtChildMatNo.TabIndex = 1;
            // 
            // txtChildMatName
            // 
            this.txtChildMatName.Enabled = false;
            this.txtChildMatName.Location = new System.Drawing.Point(90, 85);
            this.txtChildMatName.Name = "txtChildMatName";
            this.txtChildMatName.Size = new System.Drawing.Size(100, 21);
            this.txtChildMatName.TabIndex = 3;
            // 
            // lblChildMatName
            // 
            this.lblChildMatName.AutoSize = true;
            this.lblChildMatName.Location = new System.Drawing.Point(27, 88);
            this.lblChildMatName.Name = "lblChildMatName";
            this.lblChildMatName.Size = new System.Drawing.Size(57, 12);
            this.lblChildMatName.TabIndex = 2;
            this.lblChildMatName.Text = "품목 명 : ";
            // 
            // btnMatSearch
            // 
            this.btnMatSearch.Location = new System.Drawing.Point(210, 36);
            this.btnMatSearch.Name = "btnMatSearch";
            this.btnMatSearch.Size = new System.Drawing.Size(75, 23);
            this.btnMatSearch.TabIndex = 4;
            this.btnMatSearch.Text = "찾기";
            this.btnMatSearch.UseVisualStyleBackColor = true;
            // 
            // txtChildMatEA
            // 
            this.txtChildMatEA.Location = new System.Drawing.Point(90, 134);
            this.txtChildMatEA.Name = "txtChildMatEA";
            this.txtChildMatEA.Size = new System.Drawing.Size(100, 21);
            this.txtChildMatEA.TabIndex = 6;
            // 
            // lblChildMatEA
            // 
            this.lblChildMatEA.AutoSize = true;
            this.lblChildMatEA.Location = new System.Drawing.Point(27, 134);
            this.lblChildMatEA.Name = "lblChildMatEA";
            this.lblChildMatEA.Size = new System.Drawing.Size(57, 12);
            this.lblChildMatEA.TabIndex = 5;
            this.lblChildMatEA.Text = "수량 명 : ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // FrmBomAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 223);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtChildMatEA);
            this.Controls.Add(this.lblChildMatEA);
            this.Controls.Add(this.btnMatSearch);
            this.Controls.Add(this.txtChildMatName);
            this.Controls.Add(this.lblChildMatName);
            this.Controls.Add(this.txtChildMatNo);
            this.Controls.Add(this.lblChildMatNo);
            this.Name = "FrmBomAdd";
            this.Text = "BOM등록";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChildMatNo;
        private System.Windows.Forms.TextBox txtChildMatNo;
        private System.Windows.Forms.TextBox txtChildMatName;
        private System.Windows.Forms.Label lblChildMatName;
        private System.Windows.Forms.Button btnMatSearch;
        private System.Windows.Forms.TextBox txtChildMatEA;
        private System.Windows.Forms.Label lblChildMatEA;
        private System.Windows.Forms.Button btnAdd;
    }
}