using BOM.DAO;
using BOM.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOM.BUS.Sales
{
    public partial class RevenueStatus : Form
    {
        
        RevenueDao rd;
        DataTable dt;
        List<RevenueVO> revenueList = new List<RevenueVO>();
        List<RevenueVO> comparisonRevenueList = new List<RevenueVO>();
        public RevenueStatus()
        {
            InitializeComponent();
            rd = new RevenueDao();
            dt = new DataTable();
            //revenueList = new List<RevenueVO>();
            //comparisonRevenueList = new List<RevenueVO>();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string startDate = "";
            string endDate = "";
            if (rdoDate.Checked)
            {                
                startDate = dtpStart.Value.ToShortDateString();
                endDate = dtpEnd.Value.AddDays(1).ToShortDateString();
                RevenueSearch(startDate, endDate);
                //chartRevenue.Series.Clear();
                ChartView(revenueList, "날짜", 0);
            }
            else
            {                
                
            }
        }

        private void RevenueSearch(string startDate, string endDate) //매출 조회하는 기능
        {
            revenueList.Clear();
            grdRevenue.DataSource = null;
            revenueList = rd.Revenue(startDate, endDate);

            grdRevenue.DataSource = revenueList;
            grdRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdRevenue.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            if (grdRevenue.Columns[0].HeaderText.Length != 4)
            {
                grdRevenue.Columns[0].HeaderText = "주문번호";
                grdRevenue.Columns[0].Width = 80;
                grdRevenue.Columns[1].HeaderText = "주문 날짜";
                grdRevenue.Columns[2].HeaderText = "주문 가격";
            }            
        }
        

        private void ChartView(List<RevenueVO> List,string ChartSeriesName, int ChartSeriesNo) //차트에 데이터 표시하는 메서드
        {
            if (List.Count !=0)
            {
                chartRevenue.Series.Add(ChartSeriesName);
                //chartRevenue.Series[ChartSeriesNo].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                chartRevenue.Series[ChartSeriesNo].Points.AddXY(0, 0);

                double Accumulated = 0;//누적 금액            
                foreach (var item in List)
                {
                    Accumulated += Double.Parse(item.OrderPrice.Replace(",", "").Replace(" 원", "").ToString());
                    chartRevenue.Series[ChartSeriesNo].Points.AddXY(0, Accumulated);
                }
                chartRevenue.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
                chartRevenue.ChartAreas[0].AxisX.IsMarginVisible = false; //x축 값 0부터 표현 
            }
            else
            {
               // MessageBox.Show("리스트가 비어있음 ");
            }
        }

        private void RevenueStatus_Load(object sender, EventArgs e)
        {            
                       
            foreach (var item in new SalesDao().ProList()) //상품별 조회에 아이템 추가
            {
                comboProduct.Items.Add(item.ProductName);
            }

            DateTime DateAdd; //
            dtpStart.Value = dtpComparison1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateAdd = dtpEnd.Value = dtpComparison2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            DateAdd.AddDays(1);
            RevenueSearch(dtpStart.Value.ToShortDateString(), DateAdd.ToShortDateString());

            chartRevenue.Series.Clear();
            ChartView(revenueList, "날짜", 0);
        }

        private void rdoDate_CheckedChanged(object sender, EventArgs e)
        {
            lbl2.Visible = label3.Visible = dtpStart.Visible = dtpEnd.Visible = dtpComparison1.Enabled = dtpComparison2.Enabled = btnComparison.Enabled = true;            
            label6.Visible = comboProduct.Visible = false;
        }

        private void rdoProduct_CheckedChanged(object sender, EventArgs e)
        {
            lbl2.Visible = label3.Visible = dtpStart.Visible = dtpEnd.Visible = dtpComparison1.Enabled = dtpComparison2.Enabled = btnComparison.Enabled = false;            
            label6.Visible = comboProduct.Visible = true;
        }

        private void btnComparison_Click(object sender, EventArgs e)
        {
            string comStartDate = dtpComparison1.Value.ToShortDateString();
            string comEndDate = dtpComparison2.Value.ToShortDateString();
            
            comparisonRevenueList = rd.Revenue(comStartDate, comEndDate);
            ChartView(comparisonRevenueList, "비교날짜", 1);

            try
            {
                var error = chartRevenue.Series[1]; //에러를 발생시켜 캐치문 실행
                //chartRevenue.Series.Clear();
               // ChartView(revenueList, "날짜", 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                ChartView(comparisonRevenueList, "비교 날짜", 1);
            }
        }
    }
}

