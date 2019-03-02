namespace BOM
{
    partial class FrmBomDetailInfo
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
            this.rdoExplosion = new System.Windows.Forms.RadioButton();
            this.rdoImplosion = new System.Windows.Forms.RadioButton();
            this.dgvBom = new System.Windows.Forms.DataGridView();
            this.lblMatNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatNo = new System.Windows.Forms.TextBox();
            this.txtMatName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoExplosion
            // 
            this.rdoExplosion.AutoSize = true;
            this.rdoExplosion.Checked = true;
            this.rdoExplosion.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoExplosion.Location = new System.Drawing.Point(14, 87);
            this.rdoExplosion.Name = "rdoExplosion";
            this.rdoExplosion.Size = new System.Drawing.Size(61, 19);
            this.rdoExplosion.TabIndex = 2;
            this.rdoExplosion.TabStop = true;
            this.rdoExplosion.Text = "정전개";
            this.rdoExplosion.UseVisualStyleBackColor = true;
            this.rdoExplosion.CheckedChanged += new System.EventHandler(this.rdoExplosion_CheckedChanged);
            // 
            // rdoImplosion
            // 
            this.rdoImplosion.AutoSize = true;
            this.rdoImplosion.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoImplosion.Location = new System.Drawing.Point(136, 87);
            this.rdoImplosion.Name = "rdoImplosion";
            this.rdoImplosion.Size = new System.Drawing.Size(61, 19);
            this.rdoImplosion.TabIndex = 3;
            this.rdoImplosion.Text = "역전개";
            this.rdoImplosion.UseVisualStyleBackColor = true;
            this.rdoImplosion.CheckedChanged += new System.EventHandler(this.rdoImplosion_CheckedChanged);
            // 
            // dgvBom
            // 
            this.dgvBom.AllowUserToAddRows = false;
            this.dgvBom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBom.Location = new System.Drawing.Point(12, 113);
            this.dgvBom.MultiSelect = false;
            this.dgvBom.Name = "dgvBom";
            this.dgvBom.ReadOnly = true;
            this.dgvBom.RowTemplate.Height = 23;
            this.dgvBom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBom.Size = new System.Drawing.Size(646, 299);
            this.dgvBom.TabIndex = 4;
            // 
            // lblMatNo
            // 
            this.lblMatNo.AutoSize = true;
            this.lblMatNo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMatNo.Location = new System.Drawing.Point(12, 51);
            this.lblMatNo.Name = "lblMatNo";
            this.lblMatNo.Size = new System.Drawing.Size(70, 15);
            this.lblMatNo.TabIndex = 5;
            this.lblMatNo.Text = "품목 번호 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(274, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "품목명 : ";
            // 
            // txtMatNo
            // 
            this.txtMatNo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMatNo.Location = new System.Drawing.Point(87, 48);
            this.txtMatNo.Name = "txtMatNo";
            this.txtMatNo.ReadOnly = true;
            this.txtMatNo.Size = new System.Drawing.Size(100, 23);
            this.txtMatNo.TabIndex = 7;
            // 
            // txtMatName
            // 
            this.txtMatName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMatName.Location = new System.Drawing.Point(333, 48);
            this.txtMatName.Name = "txtMatName";
            this.txtMatName.ReadOnly = true;
            this.txtMatName.Size = new System.Drawing.Size(325, 23);
            this.txtMatName.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(582, 84);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "품목 찾기";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.Location = new System.Drawing.Point(370, 84);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(476, 84);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmBomDetailInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMatName);
            this.Controls.Add(this.txtMatNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMatNo);
            this.Controls.Add(this.dgvBom);
            this.Controls.Add(this.rdoImplosion);
            this.Controls.Add(this.rdoExplosion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBomDetailInfo";
            this.Text = "FrmBomDetialInfo";
            this.Load += new System.EventHandler(this.FrmBomDetailInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoExplosion;
        private System.Windows.Forms.RadioButton rdoImplosion;
        private System.Windows.Forms.DataGridView dgvBom;
        private System.Windows.Forms.Label lblMatNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatNo;
        private System.Windows.Forms.TextBox txtMatName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}