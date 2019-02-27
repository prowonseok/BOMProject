namespace BOM.BUS.Sales
{
    partial class SalesInquiry
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
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.rdoMember = new System.Windows.Forms.RadioButton();
            this.rdoProduct = new System.Windows.Forms.RadioButton();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.lbl1 = new System.Windows.Forms.Label();
            this.comboProduct = new System.Windows.Forms.ComboBox();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSales = new System.Windows.Forms.RadioButton();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Location = new System.Drawing.Point(16, 45);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(59, 16);
            this.rdoDate.TabIndex = 0;
            this.rdoDate.Text = "날짜별";
            this.rdoDate.UseVisualStyleBackColor = true;
            this.rdoDate.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoMember
            // 
            this.rdoMember.AutoSize = true;
            this.rdoMember.Location = new System.Drawing.Point(16, 72);
            this.rdoMember.Name = "rdoMember";
            this.rdoMember.Size = new System.Drawing.Size(59, 16);
            this.rdoMember.TabIndex = 1;
            this.rdoMember.Text = "회원별";
            this.rdoMember.UseVisualStyleBackColor = true;
            this.rdoMember.CheckedChanged += new System.EventHandler(this.rdoMember_CheckedChanged);
            // 
            // rdoProduct
            // 
            this.rdoProduct.AutoSize = true;
            this.rdoProduct.Location = new System.Drawing.Point(16, 99);
            this.rdoProduct.Name = "rdoProduct";
            this.rdoProduct.Size = new System.Drawing.Size(59, 16);
            this.rdoProduct.TabIndex = 2;
            this.rdoProduct.Text = "상품별";
            this.rdoProduct.UseVisualStyleBackColor = true;
            this.rdoProduct.CheckedChanged += new System.EventHandler(this.rdoProduct_CheckedChanged);
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(81, 39);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(115, 21);
            this.dtp1.TabIndex = 3;
            this.dtp1.Visible = false;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(222, 39);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(114, 21);
            this.dtp2.TabIndex = 4;
            this.dtp2.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(202, 44);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(14, 12);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "~";
            this.lbl1.Visible = false;
            // 
            // comboProduct
            // 
            this.comboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProduct.FormattingEnabled = true;
            this.comboProduct.Location = new System.Drawing.Point(81, 96);
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(135, 20);
            this.comboProduct.TabIndex = 6;
            this.comboProduct.Visible = false;
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(81, 67);
            this.txtMember.Name = "txtMember";
            this.txtMember.Size = new System.Drawing.Size(135, 21);
            this.txtMember.TabIndex = 7;
            this.txtMember.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(798, 242);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(344, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSales);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.rdoDate);
            this.groupBox1.Controls.Add(this.rdoMember);
            this.groupBox1.Controls.Add(this.txtMember);
            this.groupBox1.Controls.Add(this.rdoProduct);
            this.groupBox1.Controls.Add(this.comboProduct);
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 127);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "판매 조회";
            // 
            // rdoSales
            // 
            this.rdoSales.AutoSize = true;
            this.rdoSales.Checked = true;
            this.rdoSales.Location = new System.Drawing.Point(16, 20);
            this.rdoSales.Name = "rdoSales";
            this.rdoSales.Size = new System.Drawing.Size(59, 16);
            this.rdoSales.TabIndex = 10;
            this.rdoSales.TabStop = true;
            this.rdoSales.Text = "판매중";
            this.rdoSales.UseVisualStyleBackColor = true;
            this.rdoSales.CheckedChanged += new System.EventHandler(this.rdoSales_CheckedChanged);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(475, 33);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(259, 12);
            this.lblMsg.TabIndex = 11;
            this.lblMsg.Text = "*체크 표시후 확인버튼 누르면 출하지시서 이동";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(659, 54);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // SalesInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(820, 418);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SalesInquiry";
            this.Text = "SalesInquiry";
            this.Load += new System.EventHandler(this.SalesInquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.RadioButton rdoMember;
        private System.Windows.Forms.RadioButton rdoProduct;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox comboProduct;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSales;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnConfirm;
    }
}