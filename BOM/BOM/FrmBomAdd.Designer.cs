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
            this.btnCMatSearch = new System.Windows.Forms.Button();
            this.txtChildMatEA = new System.Windows.Forms.TextBox();
            this.lblChildMatEA = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPMatSearch = new System.Windows.Forms.Button();
            this.txtParentMatNo = new System.Windows.Forms.TextBox();
            this.lblParentMatNo = new System.Windows.Forms.Label();
            this.txtParentMatName = new System.Windows.Forms.TextBox();
            this.lblParentMatName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChildMatNo
            // 
            this.lblChildMatNo.AutoSize = true;
            this.lblChildMatNo.Location = new System.Drawing.Point(21, 115);
            this.lblChildMatNo.Name = "lblChildMatNo";
            this.lblChildMatNo.Size = new System.Drawing.Size(85, 12);
            this.lblChildMatNo.TabIndex = 0;
            this.lblChildMatNo.Text = "자 품목 번호 : ";
            // 
            // txtChildMatNo
            // 
            this.txtChildMatNo.Enabled = false;
            this.txtChildMatNo.Location = new System.Drawing.Point(112, 112);
            this.txtChildMatNo.Name = "txtChildMatNo";
            this.txtChildMatNo.Size = new System.Drawing.Size(100, 21);
            this.txtChildMatNo.TabIndex = 1;
            // 
            // txtChildMatName
            // 
            this.txtChildMatName.Enabled = false;
            this.txtChildMatName.Location = new System.Drawing.Point(112, 157);
            this.txtChildMatName.Name = "txtChildMatName";
            this.txtChildMatName.Size = new System.Drawing.Size(253, 21);
            this.txtChildMatName.TabIndex = 3;
            // 
            // lblChildMatName
            // 
            this.lblChildMatName.AutoSize = true;
            this.lblChildMatName.Location = new System.Drawing.Point(49, 160);
            this.lblChildMatName.Name = "lblChildMatName";
            this.lblChildMatName.Size = new System.Drawing.Size(57, 12);
            this.lblChildMatName.TabIndex = 2;
            this.lblChildMatName.Text = "품목 명 : ";
            // 
            // btnCMatSearch
            // 
            this.btnCMatSearch.Location = new System.Drawing.Point(397, 110);
            this.btnCMatSearch.Name = "btnCMatSearch";
            this.btnCMatSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCMatSearch.TabIndex = 4;
            this.btnCMatSearch.Text = "찾기";
            this.btnCMatSearch.UseVisualStyleBackColor = true;
            this.btnCMatSearch.Click += new System.EventHandler(this.btnMatSearch_Click);
            // 
            // txtChildMatEA
            // 
            this.txtChildMatEA.Location = new System.Drawing.Point(112, 202);
            this.txtChildMatEA.Name = "txtChildMatEA";
            this.txtChildMatEA.Size = new System.Drawing.Size(100, 21);
            this.txtChildMatEA.TabIndex = 6;
            // 
            // lblChildMatEA
            // 
            this.lblChildMatEA.AutoSize = true;
            this.lblChildMatEA.Location = new System.Drawing.Point(49, 205);
            this.lblChildMatEA.Name = "lblChildMatEA";
            this.lblChildMatEA.Size = new System.Drawing.Size(57, 12);
            this.lblChildMatEA.TabIndex = 5;
            this.lblChildMatEA.Text = "수량 명 : ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(397, 257);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnPMatSearch
            // 
            this.btnPMatSearch.Location = new System.Drawing.Point(397, 20);
            this.btnPMatSearch.Name = "btnPMatSearch";
            this.btnPMatSearch.Size = new System.Drawing.Size(75, 23);
            this.btnPMatSearch.TabIndex = 10;
            this.btnPMatSearch.Text = "찾기";
            this.btnPMatSearch.UseVisualStyleBackColor = true;
            this.btnPMatSearch.Click += new System.EventHandler(this.btnPMatSearch_Click);
            // 
            // txtParentMatNo
            // 
            this.txtParentMatNo.Enabled = false;
            this.txtParentMatNo.Location = new System.Drawing.Point(112, 22);
            this.txtParentMatNo.Name = "txtParentMatNo";
            this.txtParentMatNo.Size = new System.Drawing.Size(100, 21);
            this.txtParentMatNo.TabIndex = 9;
            // 
            // lblParentMatNo
            // 
            this.lblParentMatNo.AutoSize = true;
            this.lblParentMatNo.Location = new System.Drawing.Point(37, 25);
            this.lblParentMatNo.Name = "lblParentMatNo";
            this.lblParentMatNo.Size = new System.Drawing.Size(69, 12);
            this.lblParentMatNo.TabIndex = 8;
            this.lblParentMatNo.Text = "품목 번호 : ";
            // 
            // txtParentMatName
            // 
            this.txtParentMatName.Enabled = false;
            this.txtParentMatName.Location = new System.Drawing.Point(112, 67);
            this.txtParentMatName.Name = "txtParentMatName";
            this.txtParentMatName.Size = new System.Drawing.Size(253, 21);
            this.txtParentMatName.TabIndex = 12;
            // 
            // lblParentMatName
            // 
            this.lblParentMatName.AutoSize = true;
            this.lblParentMatName.Location = new System.Drawing.Point(49, 70);
            this.lblParentMatName.Name = "lblParentMatName";
            this.lblParentMatName.Size = new System.Drawing.Size(57, 12);
            this.lblParentMatName.TabIndex = 11;
            this.lblParentMatName.Text = "품목 명 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "개";
            // 
            // FrmBomAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParentMatName);
            this.Controls.Add(this.lblParentMatName);
            this.Controls.Add(this.btnPMatSearch);
            this.Controls.Add(this.txtParentMatNo);
            this.Controls.Add(this.lblParentMatNo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtChildMatEA);
            this.Controls.Add(this.lblChildMatEA);
            this.Controls.Add(this.btnCMatSearch);
            this.Controls.Add(this.txtChildMatName);
            this.Controls.Add(this.lblChildMatName);
            this.Controls.Add(this.txtChildMatNo);
            this.Controls.Add(this.lblChildMatNo);
            this.Name = "FrmBomAdd";
            this.Text = "BOM등록";
            this.Load += new System.EventHandler(this.FrmBomAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChildMatNo;
        private System.Windows.Forms.TextBox txtChildMatNo;
        private System.Windows.Forms.TextBox txtChildMatName;
        private System.Windows.Forms.Label lblChildMatName;
        private System.Windows.Forms.Button btnCMatSearch;
        private System.Windows.Forms.TextBox txtChildMatEA;
        private System.Windows.Forms.Label lblChildMatEA;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPMatSearch;
        private System.Windows.Forms.TextBox txtParentMatNo;
        private System.Windows.Forms.Label lblParentMatNo;
        private System.Windows.Forms.TextBox txtParentMatName;
        private System.Windows.Forms.Label lblParentMatName;
        private System.Windows.Forms.Label label1;
    }
}