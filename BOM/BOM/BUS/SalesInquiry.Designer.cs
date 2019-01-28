namespace BOM.BUS
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Location = new System.Drawing.Point(44, 47);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(59, 16);
            this.rdoDate.TabIndex = 0;
            this.rdoDate.TabStop = true;
            this.rdoDate.Text = "날짜별";
            this.rdoDate.UseVisualStyleBackColor = true;
            this.rdoDate.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoMember
            // 
            this.rdoMember.AutoSize = true;
            this.rdoMember.Location = new System.Drawing.Point(44, 74);
            this.rdoMember.Name = "rdoMember";
            this.rdoMember.Size = new System.Drawing.Size(59, 16);
            this.rdoMember.TabIndex = 1;
            this.rdoMember.TabStop = true;
            this.rdoMember.Text = "회원별";
            this.rdoMember.UseVisualStyleBackColor = true;
            this.rdoMember.CheckedChanged += new System.EventHandler(this.rdoMember_CheckedChanged);
            // 
            // rdoProduct
            // 
            this.rdoProduct.AutoSize = true;
            this.rdoProduct.Location = new System.Drawing.Point(44, 100);
            this.rdoProduct.Name = "rdoProduct";
            this.rdoProduct.Size = new System.Drawing.Size(59, 16);
            this.rdoProduct.TabIndex = 2;
            this.rdoProduct.TabStop = true;
            this.rdoProduct.Text = "상품별";
            this.rdoProduct.UseVisualStyleBackColor = true;
            this.rdoProduct.CheckedChanged += new System.EventHandler(this.rdoProduct_CheckedChanged);
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(109, 42);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(115, 21);
            this.dtp1.TabIndex = 3;
            this.dtp1.Visible = false;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(250, 42);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(114, 21);
            this.dtp2.TabIndex = 4;
            this.dtp2.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(230, 47);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(14, 12);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "~";
            this.lbl1.Visible = false;
            // 
            // comboProduct
            // 
            this.comboProduct.FormattingEnabled = true;
            this.comboProduct.Location = new System.Drawing.Point(109, 96);
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(121, 20);
            this.comboProduct.TabIndex = 6;
            this.comboProduct.Visible = false;
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(109, 69);
            this.txtMember.Name = "txtMember";
            this.txtMember.Size = new System.Drawing.Size(100, 21);
            this.txtMember.TabIndex = 7;
            this.txtMember.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(604, 266);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(573, 414);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // SalesInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 449);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMember);
            this.Controls.Add(this.comboProduct);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.rdoProduct);
            this.Controls.Add(this.rdoMember);
            this.Controls.Add(this.rdoDate);
            this.Name = "SalesInquiry";
            this.Text = "SalesInquiry";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}