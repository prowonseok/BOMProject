namespace BOM.BUS.BOM
{
    partial class FrmBomInfo
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
            this.dgvBom = new System.Windows.Forms.DataGridView();
            this.btnBomInfo = new System.Windows.Forms.Button();
            this.btnBomAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMatEstimating = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBom
            // 
            this.dgvBom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBom.Location = new System.Drawing.Point(12, 116);
            this.dgvBom.MultiSelect = false;
            this.dgvBom.Name = "dgvBom";
            this.dgvBom.ReadOnly = true;
            this.dgvBom.RowTemplate.Height = 23;
            this.dgvBom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBom.Size = new System.Drawing.Size(627, 260);
            this.dgvBom.TabIndex = 0;
            this.dgvBom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBom_CellContentClick);
            // 
            // btnBomInfo
            // 
            this.btnBomInfo.Location = new System.Drawing.Point(125, 28);
            this.btnBomInfo.Name = "btnBomInfo";
            this.btnBomInfo.Size = new System.Drawing.Size(75, 23);
            this.btnBomInfo.TabIndex = 3;
            this.btnBomInfo.Text = "BOM조회";
            this.btnBomInfo.UseVisualStyleBackColor = true;
            this.btnBomInfo.Click += new System.EventHandler(this.btnBomInfo_Click);
            // 
            // btnBomAdd
            // 
            this.btnBomAdd.Location = new System.Drawing.Point(12, 28);
            this.btnBomAdd.Name = "btnBomAdd";
            this.btnBomAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBomAdd.TabIndex = 2;
            this.btnBomAdd.Text = "BOM등록";
            this.btnBomAdd.UseVisualStyleBackColor = true;
            this.btnBomAdd.Click += new System.EventHandler(this.btnBomAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "생산 예측";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMatEstimating
            // 
            this.btnMatEstimating.Location = new System.Drawing.Point(238, 28);
            this.btnMatEstimating.Name = "btnMatEstimating";
            this.btnMatEstimating.Size = new System.Drawing.Size(88, 23);
            this.btnMatEstimating.TabIndex = 4;
            this.btnMatEstimating.Text = "소요량 예측";
            this.btnMatEstimating.UseVisualStyleBackColor = true;
            this.btnMatEstimating.Click += new System.EventHandler(this.btnMatEstimating_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(387, 89);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 21);
            this.txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(564, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "자재명",
            "자재 번호",
            "자재 타입"});
            this.cbbType.Location = new System.Drawing.Point(247, 87);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(121, 20);
            this.cbbType.TabIndex = 8;
            // 
            // FrmBomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 429);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMatEstimating);
            this.Controls.Add(this.btnBomInfo);
            this.Controls.Add(this.btnBomAdd);
            this.Controls.Add(this.dgvBom);
            this.Name = "FrmBomInfo";
            this.Load += new System.EventHandler(this.FrmBomInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBom;
        private System.Windows.Forms.Button btnBomInfo;
        private System.Windows.Forms.Button btnBomAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMatEstimating;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbType;
    }
}