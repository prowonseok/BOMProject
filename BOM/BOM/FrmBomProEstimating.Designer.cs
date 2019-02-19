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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDate)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPro
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPro.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPro.Legends.Add(legend1);
            this.chartPro.Location = new System.Drawing.Point(0, 51);
            this.chartPro.Name = "chartPro";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chartPro.Series.Add(series1);
            this.chartPro.Size = new System.Drawing.Size(437, 448);
            this.chartPro.TabIndex = 0;
            this.chartPro.Text = "chart1";
            this.chartPro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartPro_MouseMove);
            // 
            // chartDate
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDate.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDate.Legends.Add(legend2);
            this.chartDate.Location = new System.Drawing.Point(473, 51);
            this.chartDate.Name = "chartDate";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDate.Series.Add(series2);
            this.chartDate.Size = new System.Drawing.Size(591, 448);
            this.chartDate.TabIndex = 1;
            this.chartDate.Text = "chart1";
            this.chartDate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartDate_MouseMove);
            // 
            // cbbYear
            // 
            this.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(943, 25);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(121, 20);
            this.cbbYear.TabIndex = 2;
            this.cbbYear.SelectedIndexChanged += new System.EventHandler(this.cbbYear_SelectedIndexChanged);
            // 
            // FrmBomProEstimating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 587);
            this.Controls.Add(this.cbbYear);
            this.Controls.Add(this.chartDate);
            this.Controls.Add(this.chartPro);
            this.Name = "FrmBomProEstimating";
            this.Text = "FrmBomProEstimating";
            this.Load += new System.EventHandler(this.FrmBomProEstimating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPro;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDate;
        private System.Windows.Forms.ComboBox cbbYear;
    }
}