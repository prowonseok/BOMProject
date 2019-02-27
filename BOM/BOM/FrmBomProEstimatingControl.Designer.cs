namespace BOM
{
    partial class FrmBomProEstimatingControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblSecondMonth = new System.Windows.Forms.Label();
            this.lblFirstMonth = new System.Windows.Forms.Label();
            this.dgvEst2 = new System.Windows.Forms.DataGridView();
            this.dgvEst = new System.Windows.Forms.DataGridView();
            this.btnEstimating = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnPro = new System.Windows.Forms.Button();
            this.cbbProducts = new System.Windows.Forms.ComboBox();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.chartDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSecondMonth
            // 
            this.lblSecondMonth.AutoSize = true;
            this.lblSecondMonth.Location = new System.Drawing.Point(539, 260);
            this.lblSecondMonth.Name = "lblSecondMonth";
            this.lblSecondMonth.Size = new System.Drawing.Size(0, 12);
            this.lblSecondMonth.TabIndex = 21;
            // 
            // lblFirstMonth
            // 
            this.lblFirstMonth.AutoSize = true;
            this.lblFirstMonth.Location = new System.Drawing.Point(539, 30);
            this.lblFirstMonth.Name = "lblFirstMonth";
            this.lblFirstMonth.Size = new System.Drawing.Size(0, 12);
            this.lblFirstMonth.TabIndex = 20;
            // 
            // dgvEst2
            // 
            this.dgvEst2.AllowUserToAddRows = false;
            this.dgvEst2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEst2.Location = new System.Drawing.Point(35, 279);
            this.dgvEst2.MultiSelect = false;
            this.dgvEst2.Name = "dgvEst2";
            this.dgvEst2.ReadOnly = true;
            this.dgvEst2.RowTemplate.Height = 23;
            this.dgvEst2.Size = new System.Drawing.Size(591, 212);
            this.dgvEst2.TabIndex = 19;
            // 
            // dgvEst
            // 
            this.dgvEst.AllowUserToAddRows = false;
            this.dgvEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEst.Location = new System.Drawing.Point(35, 45);
            this.dgvEst.MultiSelect = false;
            this.dgvEst.Name = "dgvEst";
            this.dgvEst.ReadOnly = true;
            this.dgvEst.RowTemplate.Height = 23;
            this.dgvEst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEst.Size = new System.Drawing.Size(591, 212);
            this.dgvEst.TabIndex = 18;
            // 
            // btnEstimating
            // 
            this.btnEstimating.Location = new System.Drawing.Point(500, 4);
            this.btnEstimating.Name = "btnEstimating";
            this.btnEstimating.Size = new System.Drawing.Size(126, 23);
            this.btnEstimating.TabIndex = 17;
            this.btnEstimating.Text = "판매 예측";
            this.btnEstimating.UseVisualStyleBackColor = true;
            this.btnEstimating.Click += new System.EventHandler(this.btnEstimating_Click);
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(263, 4);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(126, 23);
            this.btnYear.TabIndex = 16;
            this.btnYear.Text = "년도별 판매량";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // btnPro
            // 
            this.btnPro.Location = new System.Drawing.Point(35, 4);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(117, 23);
            this.btnPro.TabIndex = 15;
            this.btnPro.Text = "제품별 판매량";
            this.btnPro.UseVisualStyleBackColor = true;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // cbbProducts
            // 
            this.cbbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProducts.FormattingEnabled = true;
            this.cbbProducts.Location = new System.Drawing.Point(330, 44);
            this.cbbProducts.Name = "cbbProducts";
            this.cbbProducts.Size = new System.Drawing.Size(121, 20);
            this.cbbProducts.TabIndex = 14;
            this.cbbProducts.SelectedIndexChanged += new System.EventHandler(this.cbb_SelectedIndexChanged);
            // 
            // cbbYear
            // 
            this.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(505, 44);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(121, 20);
            this.cbbYear.TabIndex = 13;
            this.cbbYear.SelectedIndexChanged += new System.EventHandler(this.cbb_SelectedIndexChanged);
            // 
            // chartDate
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDate.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDate.Legends.Add(legend3);
            this.chartDate.Location = new System.Drawing.Point(35, 70);
            this.chartDate.Name = "chartDate";
            this.chartDate.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartDate.Series.Add(series3);
            this.chartDate.Size = new System.Drawing.Size(591, 421);
            this.chartDate.TabIndex = 12;
            this.chartDate.Text = "chart1";
            this.chartDate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChartDate_MouseMove);
            // 
            // chartPro
            // 
            chartArea4.Name = "ChartArea1";
            this.chartPro.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartPro.Legends.Add(legend4);
            this.chartPro.Location = new System.Drawing.Point(35, 43);
            this.chartPro.Name = "chartPro";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "s1";
            this.chartPro.Series.Add(series4);
            this.chartPro.Size = new System.Drawing.Size(591, 448);
            this.chartPro.TabIndex = 11;
            this.chartPro.Text = "chart1";
            this.chartPro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChartPro_MouseMove);
            // 
            // FrmBomProEstimatingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSecondMonth);
            this.Controls.Add(this.lblFirstMonth);
            this.Controls.Add(this.dgvEst2);
            this.Controls.Add(this.dgvEst);
            this.Controls.Add(this.btnEstimating);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.btnPro);
            this.Controls.Add(this.cbbProducts);
            this.Controls.Add(this.cbbYear);
            this.Controls.Add(this.chartDate);
            this.Controls.Add(this.chartPro);
            this.Name = "FrmBomProEstimatingControl";
            this.Size = new System.Drawing.Size(659, 626);
            this.Load += new System.EventHandler(this.FrmBomProEstimatingControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecondMonth;
        private System.Windows.Forms.Label lblFirstMonth;
        private System.Windows.Forms.DataGridView dgvEst2;
        private System.Windows.Forms.DataGridView dgvEst;
        private System.Windows.Forms.Button btnEstimating;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.ComboBox cbbProducts;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPro;
    }
}
