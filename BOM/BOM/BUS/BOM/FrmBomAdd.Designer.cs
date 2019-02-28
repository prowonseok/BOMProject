namespace BOM.BUS.BOM
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
            this.txtParentMatLevel = new System.Windows.Forms.TextBox();
            this.lblPLevel = new System.Windows.Forms.Label();
            this.txtChildMatLevel = new System.Windows.Forms.TextBox();
            this.lblChildMatLevel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.trvMat = new System.Windows.Forms.TreeView();
            this.gbPMat = new System.Windows.Forms.GroupBox();
            this.gbCMat = new System.Windows.Forms.GroupBox();
            this.gbPMat.SuspendLayout();
            this.gbCMat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChildMatNo
            // 
            this.lblChildMatNo.AutoSize = true;
            this.lblChildMatNo.Location = new System.Drawing.Point(14, 29);
            this.lblChildMatNo.Name = "lblChildMatNo";
            this.lblChildMatNo.Size = new System.Drawing.Size(70, 15);
            this.lblChildMatNo.TabIndex = 0;
            this.lblChildMatNo.Text = "품목 번호 : ";
            // 
            // txtChildMatNo
            // 
            this.txtChildMatNo.Location = new System.Drawing.Point(89, 26);
            this.txtChildMatNo.Name = "txtChildMatNo";
            this.txtChildMatNo.ReadOnly = true;
            this.txtChildMatNo.Size = new System.Drawing.Size(100, 23);
            this.txtChildMatNo.TabIndex = 1;
            // 
            // txtChildMatName
            // 
            this.txtChildMatName.Location = new System.Drawing.Point(89, 71);
            this.txtChildMatName.Name = "txtChildMatName";
            this.txtChildMatName.ReadOnly = true;
            this.txtChildMatName.Size = new System.Drawing.Size(279, 23);
            this.txtChildMatName.TabIndex = 3;
            // 
            // lblChildMatName
            // 
            this.lblChildMatName.AutoSize = true;
            this.lblChildMatName.Location = new System.Drawing.Point(26, 74);
            this.lblChildMatName.Name = "lblChildMatName";
            this.lblChildMatName.Size = new System.Drawing.Size(58, 15);
            this.lblChildMatName.TabIndex = 2;
            this.lblChildMatName.Text = "품목 명 : ";
            // 
            // btnCMatSearch
            // 
            this.btnCMatSearch.FlatAppearance.BorderSize = 0;
            this.btnCMatSearch.Location = new System.Drawing.Point(388, 24);
            this.btnCMatSearch.Name = "btnCMatSearch";
            this.btnCMatSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCMatSearch.TabIndex = 4;
            this.btnCMatSearch.Text = "찾기";
            this.btnCMatSearch.UseVisualStyleBackColor = true;
            this.btnCMatSearch.Click += new System.EventHandler(this.btnMatSearch_Click);
            // 
            // txtChildMatEA
            // 
            this.txtChildMatEA.Location = new System.Drawing.Point(89, 116);
            this.txtChildMatEA.Name = "txtChildMatEA";
            this.txtChildMatEA.Size = new System.Drawing.Size(100, 23);
            this.txtChildMatEA.TabIndex = 6;
            this.txtChildMatEA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChildMatEA_KeyPress);
            // 
            // lblChildMatEA
            // 
            this.lblChildMatEA.AutoSize = true;
            this.lblChildMatEA.Location = new System.Drawing.Point(42, 119);
            this.lblChildMatEA.Name = "lblChildMatEA";
            this.lblChildMatEA.Size = new System.Drawing.Size(42, 15);
            this.lblChildMatEA.TabIndex = 5;
            this.lblChildMatEA.Text = "수량 : ";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(411, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPMatSearch
            // 
            this.btnPMatSearch.FlatAppearance.BorderSize = 0;
            this.btnPMatSearch.Location = new System.Drawing.Point(388, 30);
            this.btnPMatSearch.Name = "btnPMatSearch";
            this.btnPMatSearch.Size = new System.Drawing.Size(75, 23);
            this.btnPMatSearch.TabIndex = 10;
            this.btnPMatSearch.Text = "찾기";
            this.btnPMatSearch.UseVisualStyleBackColor = true;
            this.btnPMatSearch.Click += new System.EventHandler(this.btnPMatSearch_Click);
            // 
            // txtParentMatNo
            // 
            this.txtParentMatNo.Location = new System.Drawing.Point(89, 32);
            this.txtParentMatNo.Name = "txtParentMatNo";
            this.txtParentMatNo.ReadOnly = true;
            this.txtParentMatNo.Size = new System.Drawing.Size(100, 23);
            this.txtParentMatNo.TabIndex = 9;
            // 
            // lblParentMatNo
            // 
            this.lblParentMatNo.AutoSize = true;
            this.lblParentMatNo.Location = new System.Drawing.Point(14, 35);
            this.lblParentMatNo.Name = "lblParentMatNo";
            this.lblParentMatNo.Size = new System.Drawing.Size(70, 15);
            this.lblParentMatNo.TabIndex = 8;
            this.lblParentMatNo.Text = "품목 번호 : ";
            // 
            // txtParentMatName
            // 
            this.txtParentMatName.Location = new System.Drawing.Point(89, 82);
            this.txtParentMatName.Name = "txtParentMatName";
            this.txtParentMatName.ReadOnly = true;
            this.txtParentMatName.Size = new System.Drawing.Size(279, 23);
            this.txtParentMatName.TabIndex = 12;
            // 
            // lblParentMatName
            // 
            this.lblParentMatName.AutoSize = true;
            this.lblParentMatName.Location = new System.Drawing.Point(26, 85);
            this.lblParentMatName.Name = "lblParentMatName";
            this.lblParentMatName.Size = new System.Drawing.Size(58, 15);
            this.lblParentMatName.TabIndex = 11;
            this.lblParentMatName.Text = "품목 명 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "개";
            // 
            // txtParentMatLevel
            // 
            this.txtParentMatLevel.Location = new System.Drawing.Point(268, 32);
            this.txtParentMatLevel.Name = "txtParentMatLevel";
            this.txtParentMatLevel.ReadOnly = true;
            this.txtParentMatLevel.Size = new System.Drawing.Size(100, 23);
            this.txtParentMatLevel.TabIndex = 15;
            // 
            // lblPLevel
            // 
            this.lblPLevel.AutoSize = true;
            this.lblPLevel.Location = new System.Drawing.Point(193, 35);
            this.lblPLevel.Name = "lblPLevel";
            this.lblPLevel.Size = new System.Drawing.Size(70, 15);
            this.lblPLevel.TabIndex = 14;
            this.lblPLevel.Text = "품목 레벨 : ";
            // 
            // txtChildMatLevel
            // 
            this.txtChildMatLevel.Location = new System.Drawing.Point(268, 26);
            this.txtChildMatLevel.Name = "txtChildMatLevel";
            this.txtChildMatLevel.ReadOnly = true;
            this.txtChildMatLevel.Size = new System.Drawing.Size(100, 23);
            this.txtChildMatLevel.TabIndex = 17;
            // 
            // lblChildMatLevel
            // 
            this.lblChildMatLevel.AutoSize = true;
            this.lblChildMatLevel.Location = new System.Drawing.Point(193, 29);
            this.lblChildMatLevel.Name = "lblChildMatLevel";
            this.lblChildMatLevel.Size = new System.Drawing.Size(70, 15);
            this.lblChildMatLevel.TabIndex = 16;
            this.lblChildMatLevel.Text = "품목 레벨 : ";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(291, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // trvMat
            // 
            this.trvMat.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trvMat.Location = new System.Drawing.Point(507, 26);
            this.trvMat.Name = "trvMat";
            this.trvMat.Size = new System.Drawing.Size(316, 363);
            this.trvMat.TabIndex = 19;
            // 
            // gbPMat
            // 
            this.gbPMat.Controls.Add(this.btnPMatSearch);
            this.gbPMat.Controls.Add(this.lblParentMatNo);
            this.gbPMat.Controls.Add(this.txtParentMatNo);
            this.gbPMat.Controls.Add(this.lblParentMatName);
            this.gbPMat.Controls.Add(this.txtParentMatName);
            this.gbPMat.Controls.Add(this.txtParentMatLevel);
            this.gbPMat.Controls.Add(this.lblPLevel);
            this.gbPMat.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbPMat.Location = new System.Drawing.Point(23, 26);
            this.gbPMat.Name = "gbPMat";
            this.gbPMat.Size = new System.Drawing.Size(478, 139);
            this.gbPMat.TabIndex = 20;
            this.gbPMat.TabStop = false;
            this.gbPMat.Text = "모품목";
            // 
            // gbCMat
            // 
            this.gbCMat.Controls.Add(this.btnCMatSearch);
            this.gbCMat.Controls.Add(this.lblChildMatNo);
            this.gbCMat.Controls.Add(this.txtChildMatNo);
            this.gbCMat.Controls.Add(this.lblChildMatName);
            this.gbCMat.Controls.Add(this.txtChildMatLevel);
            this.gbCMat.Controls.Add(this.txtChildMatName);
            this.gbCMat.Controls.Add(this.lblChildMatLevel);
            this.gbCMat.Controls.Add(this.lblChildMatEA);
            this.gbCMat.Controls.Add(this.label1);
            this.gbCMat.Controls.Add(this.txtChildMatEA);
            this.gbCMat.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbCMat.Location = new System.Drawing.Point(23, 186);
            this.gbCMat.Name = "gbCMat";
            this.gbCMat.Size = new System.Drawing.Size(478, 155);
            this.gbCMat.TabIndex = 21;
            this.gbCMat.TabStop = false;
            this.gbCMat.Text = "자품목";
            // 
            // FrmBomAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 401);
            this.Controls.Add(this.gbCMat);
            this.Controls.Add(this.gbPMat);
            this.Controls.Add(this.trvMat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmBomAdd";
            this.Text = "BOM등록";
            this.Load += new System.EventHandler(this.FrmBomAdd_Load);
            this.gbPMat.ResumeLayout(false);
            this.gbPMat.PerformLayout();
            this.gbCMat.ResumeLayout(false);
            this.gbCMat.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtParentMatLevel;
        private System.Windows.Forms.Label lblPLevel;
        private System.Windows.Forms.TextBox txtChildMatLevel;
        private System.Windows.Forms.Label lblChildMatLevel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TreeView trvMat;
        private System.Windows.Forms.GroupBox gbPMat;
        private System.Windows.Forms.GroupBox gbCMat;
    }
}