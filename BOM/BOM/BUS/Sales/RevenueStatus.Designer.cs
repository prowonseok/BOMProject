namespace BOM.BUS.Sales
{
    partial class RevenueStatus
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grdRevenue = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lbl2 = new System.Windows.Forms.Label();
            this.tt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpComparison2 = new System.Windows.Forms.DateTimePicker();
            this.dtpComparison1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoProduct = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.comboProduct = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnComparison = new System.Windows.Forms.Button();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grdRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRevenue
            // 
            this.grdRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRevenue.Location = new System.Drawing.Point(27, 47);
            this.grdRevenue.Name = "grdRevenue";
            this.grdRevenue.RowTemplate.Height = 23;
            this.grdRevenue.Size = new System.Drawing.Size(483, 131);
            this.grdRevenue.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(435, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "~";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(242, 18);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(155, 21);
            this.dtpEnd.TabIndex = 13;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(60, 18);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(156, 21);
            this.dtpStart.TabIndex = 12;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(28, 27);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(29, 12);
            this.lbl2.TabIndex = 11;
            this.lbl2.Text = "날짜";
            // 
            // tt
            // 
            chartArea1.Name = "ChartArea1";
            this.tt.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.tt.Legends.Add(legend1);
            this.tt.Location = new System.Drawing.Point(31, 234);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(483, 218);
            this.tt.TabIndex = 29;
            this.tt.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "예상 순수익 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = "asd\\";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 12);
            this.label4.TabIndex = 35;
            this.label4.Text = "~";
            // 
            // dtpComparison2
            // 
            this.dtpComparison2.Location = new System.Drawing.Point(278, 207);
            this.dtpComparison2.Name = "dtpComparison2";
            this.dtpComparison2.Size = new System.Drawing.Size(155, 21);
            this.dtpComparison2.TabIndex = 34;
            // 
            // dtpComparison1
            // 
            this.dtpComparison1.Location = new System.Drawing.Point(96, 207);
            this.dtpComparison1.Name = "dtpComparison1";
            this.dtpComparison1.Size = new System.Drawing.Size(156, 21);
            this.dtpComparison1.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "비교 날짜";
            // 
            // rdoProduct
            // 
            this.rdoProduct.AutoSize = true;
            this.rdoProduct.Location = new System.Drawing.Point(6, 41);
            this.rdoProduct.Name = "rdoProduct";
            this.rdoProduct.Size = new System.Drawing.Size(87, 16);
            this.rdoProduct.TabIndex = 36;
            this.rdoProduct.Text = "상품별 매출";
            this.rdoProduct.UseVisualStyleBackColor = true;
            this.rdoProduct.CheckedChanged += new System.EventHandler(this.rdoProduct_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDate);
            this.groupBox1.Controls.Add(this.rdoProduct);
            this.groupBox1.Location = new System.Drawing.Point(523, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 64);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "매출 유형";
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Checked = true;
            this.rdoDate.Location = new System.Drawing.Point(6, 19);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(87, 16);
            this.rdoDate.TabIndex = 37;
            this.rdoDate.TabStop = true;
            this.rdoDate.Text = "날짜별 매출";
            this.rdoDate.UseVisualStyleBackColor = true;
            this.rdoDate.CheckedChanged += new System.EventHandler(this.rdoDate_CheckedChanged);
            // 
            // comboProduct
            // 
            this.comboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProduct.FormattingEnabled = true;
            this.comboProduct.Location = new System.Drawing.Point(541, 282);
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(121, 20);
            this.comboProduct.TabIndex = 38;
            this.comboProduct.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 39;
            this.label6.Text = "상품 조회";
            this.label6.Visible = false;
            // 
            // btnComparison
            // 
            this.btnComparison.Location = new System.Drawing.Point(439, 205);
            this.btnComparison.Name = "btnComparison";
            this.btnComparison.Size = new System.Drawing.Size(75, 23);
            this.btnComparison.TabIndex = 40;
            this.btnComparison.Text = "조회";
            this.btnComparison.UseVisualStyleBackColor = true;
            this.btnComparison.Click += new System.EventHandler(this.btnComparison_Click);
            // 
            // chartRevenue
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend2);
            this.chartRevenue.Location = new System.Drawing.Point(168, 152);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(300, 300);
            this.chartRevenue.TabIndex = 41;
            this.chartRevenue.Text = "chart1";
            // 
            // RevenueStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(672, 463);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.btnComparison);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpComparison2);
            this.Controls.Add(this.dtpComparison1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tt);
            this.Controls.Add(this.grdRevenue);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lbl2);
            this.Name = "RevenueStatus";
            this.Text = "                                                                                 " +
    "                                                                       ";
            this.Load += new System.EventHandler(this.RevenueStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdRevenue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.DataVisualization.Charting.Chart tt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpComparison2;
        private System.Windows.Forms.DateTimePicker dtpComparison1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.ComboBox comboProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnComparison;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
    }
}