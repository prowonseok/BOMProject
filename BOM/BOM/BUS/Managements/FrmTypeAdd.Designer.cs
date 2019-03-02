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
            this.dgvMatTypeList = new System.Windows.Forms.DataGridView();
            this.lblMatTypeList = new System.Windows.Forms.Label();
            this.lblTypeNo = new System.Windows.Forms.Label();
            this.lblTypeCate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatTypeList)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTypeNo
            // 
            this.tbTypeNo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbTypeNo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbTypeNo.Location = new System.Drawing.Point(48, 335);
            this.tbTypeNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTypeNo.MaxLength = 50;
            this.tbTypeNo.Name = "tbTypeNo";
            this.tbTypeNo.Size = new System.Drawing.Size(100, 23);
            this.tbTypeNo.TabIndex = 0;
            this.tbTypeNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTypeNo_KeyPress);
            // 
            // tbTypeCate
            // 
            this.tbTypeCate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbTypeCate.Location = new System.Drawing.Point(172, 335);
            this.tbTypeCate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTypeCate.MaxLength = 100;
            this.tbTypeCate.Name = "tbTypeCate";
            this.tbTypeCate.Size = new System.Drawing.Size(100, 23);
            this.tbTypeCate.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(102, 366);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegist
            // 
            this.btnRegist.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRegist.Location = new System.Drawing.Point(197, 366);
            this.btnRegist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(75, 29);
            this.btnRegist.TabIndex = 3;
            this.btnRegist.Text = "등록";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // dgvMatTypeList
            // 
            this.dgvMatTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatTypeList.Location = new System.Drawing.Point(12, 30);
            this.dgvMatTypeList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMatTypeList.Name = "dgvMatTypeList";
            this.dgvMatTypeList.RowTemplate.Height = 23;
            this.dgvMatTypeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatTypeList.Size = new System.Drawing.Size(260, 275);
            this.dgvMatTypeList.TabIndex = 4;
            // 
            // lblMatTypeList
            // 
            this.lblMatTypeList.AutoSize = true;
            this.lblMatTypeList.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMatTypeList.Location = new System.Drawing.Point(10, 11);
            this.lblMatTypeList.Name = "lblMatTypeList";
            this.lblMatTypeList.Size = new System.Drawing.Size(87, 15);
            this.lblMatTypeList.TabIndex = 5;
            this.lblMatTypeList.Text = "자재 분류 현황";
            // 
            // lblTypeNo
            // 
            this.lblTypeNo.AutoSize = true;
            this.lblTypeNo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTypeNo.Location = new System.Drawing.Point(46, 316);
            this.lblTypeNo.Name = "lblTypeNo";
            this.lblTypeNo.Size = new System.Drawing.Size(59, 15);
            this.lblTypeNo.TabIndex = 6;
            this.lblTypeNo.Text = "분류 번호";
            // 
            // lblTypeCate
            // 
            this.lblTypeCate.AutoSize = true;
            this.lblTypeCate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTypeCate.Location = new System.Drawing.Point(170, 316);
            this.lblTypeCate.Name = "lblTypeCate";
            this.lblTypeCate.Size = new System.Drawing.Size(43, 15);
            this.lblTypeCate.TabIndex = 7;
            this.lblTypeCate.Text = "분류명";
            // 
            // FrmTypeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 410);
            this.Controls.Add(this.lblTypeCate);
            this.Controls.Add(this.lblTypeNo);
            this.Controls.Add(this.lblMatTypeList);
            this.Controls.Add(this.dgvMatTypeList);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbTypeCate);
            this.Controls.Add(this.tbTypeNo);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTypeAdd";
            this.Text = "FrmTypeAdd";
            this.Load += new System.EventHandler(this.FrmTypeAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatTypeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTypeNo;
        private System.Windows.Forms.TextBox tbTypeCate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.DataGridView dgvMatTypeList;
        private System.Windows.Forms.Label lblMatTypeList;
        private System.Windows.Forms.Label lblTypeNo;
        private System.Windows.Forms.Label lblTypeCate;
    }
}