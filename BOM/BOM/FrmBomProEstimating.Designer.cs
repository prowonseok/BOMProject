namespace BOM
{
    partial class FrmBomProEstimating
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.cbbProducts = new System.Windows.Forms.ComboBox();
            this.btnPro = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnEstimating = new System.Windows.Forms.Button();
            this.dgvEst = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPro
            // 
            chartArea3.Name = "ChartArea1";
            this.chartPro.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPro.Legends.Add(legend3);
            this.chartPro.Location = new System.Drawing.Point(12, 51);
            this.chartPro.Name = "chartPro";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "s1";
            this.chartPro.Series.Add(series3);
            this.chartPro.Size = new System.Drawing.Size(591, 448);
            this.chartPro.TabIndex = 0;
            this.chartPro.Text = "chart1";
            this.chartPro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartPro_MouseMove);
            // 
            // chartDate
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDate.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDate.Legends.Add(legend4);
            this.chartDate.Location = new System.Drawing.Point(12, 78);
            this.chartDate.Name = "chartDate";
            this.chartDate.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDate.Series.Add(series4);
            this.chartDate.Size = new System.Drawing.Size(591, 421);
            this.chartDate.TabIndex = 1;
            this.chartDate.Text = "chart1";
            this.chartDate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartDate_MouseMove);
            // 
            // cbbYear
            // 
            this.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(482, 52);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(121, 20);
            this.cbbYear.TabIndex = 2;
            this.cbbYear.SelectedIndexChanged += new System.EventHandler(this.cbbProducts_SelectedIndexChanged);
            // 
            // cbbProducts
            // 
            this.cbbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProducts.FormattingEnabled = true;
            this.cbbProducts.Location = new System.Drawing.Point(307, 52);
            this.cbbProducts.Name = "cbbProducts";
            this.cbbProducts.Size = new System.Drawing.Size(121, 20);
            this.cbbProducts.TabIndex = 3;
            this.cbbProducts.SelectedIndexChanged += new System.EventHandler(this.cbbProducts_SelectedIndexChanged);
            // 
            // btnPro
            // 
            this.btnPro.Location = new System.Drawing.Point(12, 12);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(117, 23);
            this.btnPro.TabIndex = 4;
            this.btnPro.Text = "제품별 판매량";
            this.btnPro.UseVisualStyleBackColor = true;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(240, 12);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(126, 23);
            this.btnYear.TabIndex = 5;
            this.btnYear.Text = "년도별 판매량";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // btnEstimating
            // 
            this.btnEstimating.Location = new System.Drawing.Point(477, 12);
            this.btnEstimating.Name = "btnEstimating";
            this.btnEstimating.Size = new System.Drawing.Size(126, 23);
            this.btnEstimating.TabIndex = 6;
            this.btnEstimating.Text = "생산 예측";
            this.btnEstimating.UseVisualStyleBackColor = true;
            this.btnEstimating.Click += new System.EventHandler(this.btnEstimating_Click);
            // 
            // dgvEst
            // 
            this.dgvEst.AllowUserToAddRows = false;
            this.dgvEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEst.Location = new System.Drawing.Point(12, 87);
            this.dgvEst.Name = "dgvEst";
            this.dgvEst.RowTemplate.Height = 23;
            this.dgvEst.Size = new System.Drawing.Size(591, 412);
            this.dgvEst.TabIndex = 7;
            // 
            // FrmBomProEstimating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 587);
            this.Controls.Add(this.dgvEst);
            this.Controls.Add(this.btnEstimating);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.btnPro);
            this.Controls.Add(this.cbbProducts);
            this.Controls.Add(this.cbbYear);
            this.Controls.Add(this.chartDate);
            this.Controls.Add(this.chartPro);
            this.Name = "FrmBomProEstimating";
            this.Text = "FrmBomProEstimating";
            this.Load += new System.EventHandler(this.FrmBomProEstimating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPro;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDate;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.ComboBox cbbProducts;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnEstimating;
        private System.Windows.Forms.DataGridView dgvEst;
    }
}