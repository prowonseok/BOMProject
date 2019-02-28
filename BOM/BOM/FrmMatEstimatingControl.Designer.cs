namespace BOM
{
    partial class FrmMatEstimatingControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.dgvMat = new System.Windows.Forms.DataGridView();
            this.btnSearchTree = new System.Windows.Forms.Button();
            this.txtEA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tvProMat = new System.Windows.Forms.TreeView();
            this.btnSearchPro = new System.Windows.Forms.Button();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(369, 487);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(97, 23);
            this.btnExcel.TabIndex = 23;
            this.btnExcel.Text = "Excel로 저장";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(515, 487);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(75, 23);
            this.btnXml.TabIndex = 22;
            this.btnXml.Text = "xml로 저장";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // dgvMat
            // 
            this.dgvMat.AllowUserToAddRows = false;
            this.dgvMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMat.Location = new System.Drawing.Point(369, 49);
            this.dgvMat.MultiSelect = false;
            this.dgvMat.Name = "dgvMat";
            this.dgvMat.ReadOnly = true;
            this.dgvMat.RowTemplate.Height = 23;
            this.dgvMat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMat.Size = new System.Drawing.Size(406, 421);
            this.dgvMat.TabIndex = 21;
            // 
            // btnSearchTree
            // 
            this.btnSearchTree.Location = new System.Drawing.Point(275, 83);
            this.btnSearchTree.Name = "btnSearchTree";
            this.btnSearchTree.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTree.TabIndex = 20;
            this.btnSearchTree.Text = "검색";
            this.btnSearchTree.UseVisualStyleBackColor = true;
            this.btnSearchTree.Click += new System.EventHandler(this.btnSearchTree_Click);
            // 
            // txtEA
            // 
            this.txtEA.Location = new System.Drawing.Point(92, 85);
            this.txtEA.Name = "txtEA";
            this.txtEA.Size = new System.Drawing.Size(148, 21);
            this.txtEA.TabIndex = 19;
            this.txtEA.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "개수 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(103, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 35);
            this.label2.TabIndex = 17;
            this.label2.Text = "소  요  량";
            // 
            // tvProMat
            // 
            this.tvProMat.Location = new System.Drawing.Point(35, 157);
            this.tvProMat.Name = "tvProMat";
            this.tvProMat.Size = new System.Drawing.Size(315, 313);
            this.tvProMat.TabIndex = 16;
            this.tvProMat.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvProMat_NodeMouseDoubleClick);
            // 
            // btnSearchPro
            // 
            this.btnSearchPro.Location = new System.Drawing.Point(275, 49);
            this.btnSearchPro.Name = "btnSearchPro";
            this.btnSearchPro.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPro.TabIndex = 15;
            this.btnSearchPro.Text = "제품 찾기";
            this.btnSearchPro.UseVisualStyleBackColor = true;
            this.btnSearchPro.Click += new System.EventHandler(this.btnSearchPro_Click);
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(92, 51);
            this.txtPName.Name = "txtPName";
            this.txtPName.ReadOnly = true;
            this.txtPName.Size = new System.Drawing.Size(148, 21);
            this.txtPName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "제품명 : ";
            // 
            // FrmMatEstimatingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "FrmMatEstimatingControl";
            this.Size = new System.Drawing.Size(809, 558);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.DataGridView dgvMat;
        private System.Windows.Forms.Button btnSearchTree;
        private System.Windows.Forms.TextBox txtEA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tvProMat;
        private System.Windows.Forms.Button btnSearchPro;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
