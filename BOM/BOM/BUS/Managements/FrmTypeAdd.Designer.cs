namespace BOM.BUS.Managements
{
    partial class FrmTypeAdd
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
            this.tbTypeNo = new System.Windows.Forms.TextBox();
            this.tbTypeCate = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTypeNo
            // 
            this.tbTypeNo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbTypeNo.Location = new System.Drawing.Point(51, 39);
            this.tbTypeNo.MaxLength = 50;
            this.tbTypeNo.Name = "tbTypeNo";
            this.tbTypeNo.Size = new System.Drawing.Size(100, 21);
            this.tbTypeNo.TabIndex = 0;
            this.tbTypeNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTypeNo_KeyPress);
            // 
            // tbTypeCate
            // 
            this.tbTypeCate.Location = new System.Drawing.Point(190, 39);
            this.tbTypeCate.MaxLength = 100;
            this.tbTypeCate.Name = "tbTypeCate";
            this.tbTypeCate.Size = new System.Drawing.Size(100, 21);
            this.tbTypeCate.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(114, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(215, 190);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(75, 23);
            this.btnRegist.TabIndex = 3;
            this.btnRegist.Text = "등록";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // FrmTypeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 225);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbTypeCate);
            this.Controls.Add(this.tbTypeNo);
            this.Name = "FrmTypeAdd";
            this.Text = "FrmTypeAdd";
            this.Load += new System.EventHandler(this.FrmTypeAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTypeNo;
        private System.Windows.Forms.TextBox tbTypeCate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegist;
    }
}