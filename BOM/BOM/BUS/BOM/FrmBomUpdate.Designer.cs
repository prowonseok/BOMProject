namespace BOM
{
    partial class FrmBomUpdate
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
            this.txtEa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatNo = new System.Windows.Forms.TextBox();
            this.txtMatName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "수량 : ";
            // 
            // txtEa
            // 
            this.txtEa.Location = new System.Drawing.Point(113, 116);
            this.txtEa.Name = "txtEa";
            this.txtEa.Size = new System.Drawing.Size(92, 21);
            this.txtEa.TabIndex = 3;
            this.txtEa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEa_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "개";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(53, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(218, 174);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "자재 번호 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "자재명 : ";
            // 
            // txtMatNo
            // 
            this.txtMatNo.Location = new System.Drawing.Point(113, 12);
            this.txtMatNo.Name = "txtMatNo";
            this.txtMatNo.ReadOnly = true;
            this.txtMatNo.Size = new System.Drawing.Size(120, 21);
            this.txtMatNo.TabIndex = 9;
            // 
            // txtMatName
            // 
            this.txtMatName.Location = new System.Drawing.Point(113, 64);
            this.txtMatName.Name = "txtMatName";
            this.txtMatName.ReadOnly = true;
            this.txtMatName.Size = new System.Drawing.Size(185, 21);
            this.txtMatName.TabIndex = 10;
            // 
            // FrmBomUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 224);
            this.Controls.Add(this.txtMatName);
            this.Controls.Add(this.txtMatNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEa);
            this.Controls.Add(this.label1);
            this.Name = "FrmBomUpdate";
            this.Text = "FrmBomUpdate";
            this.Load += new System.EventHandler(this.FrmBomUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatNo;
        private System.Windows.Forms.TextBox txtMatName;
    }
}