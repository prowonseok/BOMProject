﻿namespace BOM.BUS.Managements
{
    partial class FrmMatAdd
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
            this.lblMatNo = new System.Windows.Forms.Label();
            this.lblMatType = new System.Windows.Forms.Label();
            this.lblManufac = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblMatLvl = new System.Windows.Forms.Label();
            this.tbMatNo = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbMatLvl = new System.Windows.Forms.TextBox();
            this.tbMatEa = new System.Windows.Forms.TextBox();
            this.lblMatEa = new System.Windows.Forms.Label();
            this.lblOfferer = new System.Windows.Forms.Label();
            this.cbMatType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbOfferer = new System.Windows.Forms.ComboBox();
            this.tbManufac = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMatNo
            // 
            this.lblMatNo.AutoSize = true;
            this.lblMatNo.Location = new System.Drawing.Point(21, 25);
            this.lblMatNo.Name = "lblMatNo";
            this.lblMatNo.Size = new System.Drawing.Size(57, 12);
            this.lblMatNo.TabIndex = 0;
            this.lblMatNo.Text = "자재 번호";
            // 
            // lblMatType
            // 
            this.lblMatType.AutoSize = true;
            this.lblMatType.Location = new System.Drawing.Point(21, 63);
            this.lblMatType.Name = "lblMatType";
            this.lblMatType.Size = new System.Drawing.Size(57, 12);
            this.lblMatType.TabIndex = 1;
            this.lblMatType.Text = "자재 분류";
            // 
            // lblManufac
            // 
            this.lblManufac.AutoSize = true;
            this.lblManufac.Location = new System.Drawing.Point(37, 100);
            this.lblManufac.Name = "lblManufac";
            this.lblManufac.Size = new System.Drawing.Size(41, 12);
            this.lblManufac.TabIndex = 2;
            this.lblManufac.Text = "제조사";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 137);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "자재명";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(276, 25);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(29, 12);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "단가";
            // 
            // lblMatLvl
            // 
            this.lblMatLvl.AutoSize = true;
            this.lblMatLvl.Location = new System.Drawing.Point(248, 63);
            this.lblMatLvl.Name = "lblMatLvl";
            this.lblMatLvl.Size = new System.Drawing.Size(57, 12);
            this.lblMatLvl.TabIndex = 5;
            this.lblMatLvl.Text = "자재 단계";
            // 
            // tbMatNo
            // 
            this.tbMatNo.Location = new System.Drawing.Point(113, 22);
            this.tbMatNo.Name = "tbMatNo";
            this.tbMatNo.Size = new System.Drawing.Size(121, 21);
            this.tbMatNo.TabIndex = 6;
            this.tbMatNo.TextChanged += new System.EventHandler(this.tbMatNo_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(113, 134);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 21);
            this.tbName.TabIndex = 9;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(340, 22);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(121, 21);
            this.tbCost.TabIndex = 10;
            this.tbCost.TextChanged += new System.EventHandler(this.tbCost_TextChanged);
            this.tbCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCost_KeyDown);
            // 
            // tbMatLvl
            // 
            this.tbMatLvl.Location = new System.Drawing.Point(340, 60);
            this.tbMatLvl.Name = "tbMatLvl";
            this.tbMatLvl.Size = new System.Drawing.Size(121, 21);
            this.tbMatLvl.TabIndex = 11;
            // 
            // tbMatEa
            // 
            this.tbMatEa.Location = new System.Drawing.Point(340, 97);
            this.tbMatEa.Name = "tbMatEa";
            this.tbMatEa.Size = new System.Drawing.Size(121, 21);
            this.tbMatEa.TabIndex = 12;
            // 
            // lblMatEa
            // 
            this.lblMatEa.AutoSize = true;
            this.lblMatEa.Location = new System.Drawing.Point(264, 100);
            this.lblMatEa.Name = "lblMatEa";
            this.lblMatEa.Size = new System.Drawing.Size(41, 12);
            this.lblMatEa.TabIndex = 15;
            this.lblMatEa.Text = "입고량";
            // 
            // lblOfferer
            // 
            this.lblOfferer.AutoSize = true;
            this.lblOfferer.Location = new System.Drawing.Point(264, 137);
            this.lblOfferer.Name = "lblOfferer";
            this.lblOfferer.Size = new System.Drawing.Size(41, 12);
            this.lblOfferer.TabIndex = 16;
            this.lblOfferer.Text = "공급사";
            // 
            // cbMatType
            // 
            this.cbMatType.FormattingEnabled = true;
            this.cbMatType.Location = new System.Drawing.Point(113, 60);
            this.cbMatType.Name = "cbMatType";
            this.cbMatType.Size = new System.Drawing.Size(121, 20);
            this.cbMatType.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(386, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(287, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbOfferer
            // 
            this.cbOfferer.FormattingEnabled = true;
            this.cbOfferer.Location = new System.Drawing.Point(340, 134);
            this.cbOfferer.Name = "cbOfferer";
            this.cbOfferer.Size = new System.Drawing.Size(121, 20);
            this.cbOfferer.TabIndex = 21;
            // 
            // tbManufac
            // 
            this.tbManufac.Location = new System.Drawing.Point(113, 97);
            this.tbManufac.Name = "tbManufac";
            this.tbManufac.Size = new System.Drawing.Size(121, 21);
            this.tbManufac.TabIndex = 22;
            // 
            // FrmMatAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 222);
            this.Controls.Add(this.tbManufac);
            this.Controls.Add(this.cbOfferer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbMatType);
            this.Controls.Add(this.lblOfferer);
            this.Controls.Add(this.lblMatEa);
            this.Controls.Add(this.tbMatEa);
            this.Controls.Add(this.tbMatLvl);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbMatNo);
            this.Controls.Add(this.lblMatLvl);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblManufac);
            this.Controls.Add(this.lblMatType);
            this.Controls.Add(this.lblMatNo);
            this.Name = "FrmMatAdd";
            this.Text = "FrmMatAdd";
            this.Load += new System.EventHandler(this.FrmMatAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatNo;
        private System.Windows.Forms.Label lblMatType;
        private System.Windows.Forms.Label lblManufac;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblMatLvl;
        private System.Windows.Forms.TextBox tbMatNo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox tbMatLvl;
        private System.Windows.Forms.TextBox tbMatEa;
        private System.Windows.Forms.Label lblMatEa;
        private System.Windows.Forms.Label lblOfferer;
        private System.Windows.Forms.ComboBox cbMatType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbOfferer;
        private System.Windows.Forms.TextBox tbManufac;
    }
}