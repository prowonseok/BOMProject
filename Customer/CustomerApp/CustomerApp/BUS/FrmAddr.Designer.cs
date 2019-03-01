namespace CustomerApp.BUS
{
    partial class FrmAddr
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdoDong = new System.Windows.Forms.RadioButton();
            this.gbxSearchType = new System.Windows.Forms.GroupBox();
            this.rdoPost = new System.Windows.Forms.RadioButton();
            this.rdoRoad = new System.Windows.Forms.RadioButton();
            this.gViewResult = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblGuide = new System.Windows.Forms.Label();
            this.gbxSearchType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(15, 97);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(420, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // rdoDong
            // 
            this.rdoDong.AutoSize = true;
            this.rdoDong.Location = new System.Drawing.Point(6, 21);
            this.rdoDong.Name = "rdoDong";
            this.rdoDong.Size = new System.Drawing.Size(115, 16);
            this.rdoDong.TabIndex = 1;
            this.rdoDong.TabStop = true;
            this.rdoDong.Text = "지번 주소로 검색";
            this.rdoDong.UseVisualStyleBackColor = true;
            this.rdoDong.CheckedChanged += new System.EventHandler(this.rdoDong_CheckedChanged);
            // 
            // gbxSearchType
            // 
            this.gbxSearchType.Controls.Add(this.rdoPost);
            this.gbxSearchType.Controls.Add(this.rdoRoad);
            this.gbxSearchType.Controls.Add(this.rdoDong);
            this.gbxSearchType.Location = new System.Drawing.Point(15, 40);
            this.gbxSearchType.Name = "gbxSearchType";
            this.gbxSearchType.Size = new System.Drawing.Size(501, 51);
            this.gbxSearchType.TabIndex = 2;
            this.gbxSearchType.TabStop = false;
            // 
            // rdoPost
            // 
            this.rdoPost.AutoSize = true;
            this.rdoPost.Location = new System.Drawing.Point(384, 21);
            this.rdoPost.Name = "rdoPost";
            this.rdoPost.Size = new System.Drawing.Size(111, 16);
            this.rdoPost.TabIndex = 3;
            this.rdoPost.TabStop = true;
            this.rdoPost.Text = "우편번호로 검색";
            this.rdoPost.UseVisualStyleBackColor = true;
            this.rdoPost.CheckedChanged += new System.EventHandler(this.rdoPost_CheckedChanged);
            // 
            // rdoRoad
            // 
            this.rdoRoad.AutoSize = true;
            this.rdoRoad.Location = new System.Drawing.Point(189, 21);
            this.rdoRoad.Name = "rdoRoad";
            this.rdoRoad.Size = new System.Drawing.Size(127, 16);
            this.rdoRoad.TabIndex = 2;
            this.rdoRoad.TabStop = true;
            this.rdoRoad.Text = "도로명 주소로 검색";
            this.rdoRoad.UseVisualStyleBackColor = true;
            this.rdoRoad.CheckedChanged += new System.EventHandler(this.rdoRoad_CheckedChanged);
            // 
            // gViewResult
            // 
            this.gViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewResult.Location = new System.Drawing.Point(12, 124);
            this.gViewResult.MultiSelect = false;
            this.gViewResult.Name = "gViewResult";
            this.gViewResult.RowTemplate.Height = 23;
            this.gViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gViewResult.Size = new System.Drawing.Size(513, 150);
            this.gViewResult.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(441, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(450, 280);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "선택하기";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblGuide
            // 
            this.lblGuide.AutoSize = true;
            this.lblGuide.Location = new System.Drawing.Point(16, 12);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(0, 12);
            this.lblGuide.TabIndex = 7;
            // 
            // FrmAddr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 314);
            this.Controls.Add(this.lblGuide);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gViewResult);
            this.Controls.Add(this.gbxSearchType);
            this.Controls.Add(this.txtSearch);
            this.Name = "FrmAddr";
            this.Text = "FrmAddr";
            this.Load += new System.EventHandler(this.FrmAddr_Load);
            this.gbxSearchType.ResumeLayout(false);
            this.gbxSearchType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdoDong;
        private System.Windows.Forms.GroupBox gbxSearchType;
        private System.Windows.Forms.RadioButton rdoRoad;
        private System.Windows.Forms.RadioButton rdoPost;
        private System.Windows.Forms.DataGridView gViewResult;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblGuide;
    }
}