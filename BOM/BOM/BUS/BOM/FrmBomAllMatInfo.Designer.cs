﻿namespace BOM
{
    partial class FrmBomAllMatInfo
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
            this.dgvAllMat = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllMat
            // 
            this.dgvAllMat.AllowUserToAddRows = false;
            this.dgvAllMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllMat.Location = new System.Drawing.Point(12, 46);
            this.dgvAllMat.MultiSelect = false;
            this.dgvAllMat.Name = "dgvAllMat";
            this.dgvAllMat.ReadOnly = true;
            this.dgvAllMat.RowTemplate.Height = 23;
            this.dgvAllMat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllMat.Size = new System.Drawing.Size(498, 336);
            this.dgvAllMat.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(96, 412);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(297, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "자재명",
            "자재 번호",
            "자재 타입",
            "제조사"});
            this.cbbType.Location = new System.Drawing.Point(118, 17);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(121, 20);
            this.cbbType.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(435, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(258, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 21);
            this.txtSearch.TabIndex = 9;
            // 
            // FrmBomAllMatInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 476);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvAllMat);
            this.Name = "FrmBomAllMatInfo";
            this.Text = "FrmBomAllMatInfo";
            this.Load += new System.EventHandler(this.FrmBomAllMatInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllMat;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}