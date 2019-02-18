using BOM.DAO;
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
        public RevenueStatus()
        {
            InitializeComponent();
            rd = new RevenueDao();
            dt = new DataTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string startDate = "";
            string endDate = "";

            DateTime a = DateTime.Now.AddDays(2);

            startDate = dtpStart.Value.ToShortDateString();
            endDate = dtpEnd.Value.ToShortDateString();
            dt = rd.Revenue(startDate, endDate);                        

            grdRevenue.DataSource = dt;

            int aa= 0;
            double aaa = 0;
            chartRevenue.Series[0].Points.AddXY(0,0);
            foreach (DataRow item in dt.Rows)
            {
                aa++;
                aaa += Double.Parse(item["Cus_Order_Price"].ToString());
                chartRevenue.Series[0].Points.AddXY(Double.Parse(aa.ToString()), aaa);
                
            }
            chartRevenue.Series["Series1"].AxisLabel = " ";

        }

        private void RevenueStatus_Load(object sender, EventArgs e)
        {

        }
    }
}
