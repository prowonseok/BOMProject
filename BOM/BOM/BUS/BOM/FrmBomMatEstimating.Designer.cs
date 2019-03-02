namespace BOM
{
    partial class FrmBomMatEstimating
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
            this.txtPName = new System.Windows.Forms.TextBox();
            this.btnSearchPro = new System.Windows.Forms.Button();
            this.tvProMat = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchTree = new System.Windows.Forms.Button();
            this.dgvMat = new System.Windows.Forms.DataGridView();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "제품명 : ";
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPName.Location = new System.Drawing.Point(88, 35);
            this.txtPName.Name = "txtPName";
            this.txtPName.ReadOnly = true;
            this.txtPName.Size = new System.Drawing.Size(148, 23);
            this.txtPName.TabIndex = 1;
            // 
            // btnSearchPro
            // 
            this.btnSearchPro.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearchPro.Location = new System.Drawing.Point(271, 33);
            this.btnSearchPro.Name = "btnSearchPro";
            this.btnSearchPro.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPro.TabIndex = 2;
            this.btnSearchPro.Text = "제품 찾기";
            this.btnSearchPro.UseVisualStyleBackColor = true;
            this.btnSearchPro.Click += new System.EventHandler(this.btnSearchPro_Click);
            // 
            // tvProMat
            // 
            this.tvProMat.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tvProMat.Location = new System.Drawing.Point(31, 141);
            this.tvProMat.Name = "tvProMat";
            this.tvProMat.Size = new System.Drawing.Size(315, 313);
            this.tvProMat.TabIndex = 3;
            this.tvProMat.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvProMat_BeforeSelect);
            this.tvProMat.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvProMat_AfterSelect);
            this.tvProMat.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvProMat_NodeMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(109, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "소  요  량";
            // 
            // txtEA
            // 
            this.txtEA.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEA.Location = new System.Drawing.Point(88, 69);
            this.txtEA.Name = "txtEA";
            this.txtEA.Size = new System.Drawing.Size(148, 23);
            this.txtEA.TabIndex = 6;
            this.txtEA.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(41, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "개수 : ";
            // 
            // btnSearchTree
            // 
            this.btnSearchTree.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearchTree.Location = new System.Drawing.Point(271, 67);
            this.btnSearchTree.Name = "btnSearchTree";
            this.btnSearchTree.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTree.TabIndex = 7;
            this.btnSearchTree.Text = "검색";
            this.btnSearchTree.UseVisualStyleBackColor = true;
            this.btnSearchTree.Click += new System.EventHandler(this.btnSearchTree_Click);
            // 
            // dgvMat
            // 
            this.dgvMat.AllowUserToAddRows = false;
            this.dgvMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMat.Location = new System.Drawing.Point(365, 33);
            this.dgvMat.MultiSelect = false;
            this.dgvMat.Name = "dgvMat";
            this.dgvMat.ReadOnly = true;
            this.dgvMat.RowTemplate.Height = 23;
            this.dgvMat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMat.Size = new System.Drawing.Size(406, 421);
            this.dgvMat.TabIndex = 8;
            // 
            // btnXml
            // 
            this.btnXml.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnXml.Location = new System.Drawing.Point(522, 471);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(97, 36);
            this.btnXml.TabIndex = 11;
            this.btnXml.Text = "xml로 저장";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.Location = new System.Drawing.Point(365, 471);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(97, 36);
            this.btnExcel.TabIndex = 12;
            this.btnExcel.Text = "Excel로 저장";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // FrmBomMatEstimating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 519);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.dgvMat);
            this.Controls.Add(this.btnSearchTree);
            this.Controls.Add(this.txtEA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tvProMat);
            this.Controls.Add(this.btnSearchPro);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBomMatEstimating";
            this.Text = "FrmMatEstimating";
            this.Load += new System.EventHandler(this.FrmBomMatEstimating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Button btnSearchPro;
        private System.Windows.Forms.TreeView tvProMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchTree;
        private System.Windows.Forms.DataGridView dgvMat;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}