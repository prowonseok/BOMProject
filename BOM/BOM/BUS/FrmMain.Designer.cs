﻿namespace BOM.BUS
{
    partial class FrmMain
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
            this.BtnBOM = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnBOM
            // 
            this.BtnBOM.Location = new System.Drawing.Point(132, 12);
            this.BtnBOM.Name = "BtnBOM";
            this.BtnBOM.Size = new System.Drawing.Size(166, 172);
            this.BtnBOM.TabIndex = 0;
            this.BtnBOM.Text = "BOM";
            this.BtnBOM.UseVisualStyleBackColor = true;
            this.BtnBOM.Click += new System.EventHandler(this.BtnBOM_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(455, 12);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(166, 172);
            this.btnManage.TabIndex = 1;
            this.btnManage.Text = "관리자";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 400);
            this.panel1.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.BtnBOM);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBOM;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Panel panel1;
    }
}