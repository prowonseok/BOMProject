using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BOM
{
    public partial class FrmBomProEstimating : Form
    {
        DAO.BomDAO bDao;
        DataTable dt;
        List<string> proLst;
        public FrmBomProEstimating()
        {
            InitializeComponent();
            
        }

        private void FrmBomProEstimating_Load(object sender, EventArgs e)
        {
            #region 원형 그래프
            bDao = new DAO.BomDAO();
            chartPro.Titles.Add("제품별 판매량");
            dt = bDao.SelectOrder();
            proLst = new List<string>();

            foreach (DataRow item in dt.Rows)
            {
                chartPro.Series["s1"].Points.AddXY(item["Pro_Name"].ToString(), item["판매량"].ToString());
                proLst.Add(item["Pro_Name"].ToString());
            }
            #endregion

            chartDate.Titles.Add("년도별 판매량");
            dt = bDao.SelectDateOrder();
            for (int i = 2016; i < DateTime.Now.Year+1; i++)
            {
                cbbYear.Items.Add(i);
            }
            cbbYear.Text = "2019";


        }

        Point? previousPos = null; //null을 가질 수 있는 Point타입의 변수
        ToolTip myToolTip = new ToolTip();

        private void chartPro_MouseMove(object sender, MouseEventArgs e)
        {
            Point position = e.Location; //현재 마우스 포인터의 좌표 저장
            if (previousPos.HasValue&&position==previousPos)
            { 
                //좌표가 변경되지 않았을 때
                return;
            }

            myToolTip.RemoveAll();
            previousPos = position;

            var hit = chartPro.HitTest(position.X, position.Y, ChartElementType.DataPoint);

            if (hit.ChartElementType==ChartElementType.DataPoint)
            {
                var pNum = ((DataPoint)hit.Object).YValues[0];
                var pc = proLst[hit.PointIndex];
                myToolTip.Show("\""+pc + "\"제품의 판매량은 "+pNum + "개 입니다", chartPro,new Point(position.X+10,position.Y+15)); 
            }
        }

        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartDate.Series.Clear();
            foreach (var item in proLst)
            {
                //PC들을 Series에 추가
                chartDate.Series.Add(item);
            }
            foreach (DataRow item in dt.Rows)
            {
                if (item["YEAR"].ToString() == cbbYear.Text)
                {
                    chartDate.Series[item["Pro_Name"].ToString()].Points.AddXY(item["MONTH"].ToString(), Int32.Parse(item["COUNT"].ToString()));
                }
            }
        }

        private void chartDate_MouseMove(object sender, MouseEventArgs e)
        {
            Point position = e.Location;
            if (previousPos.HasValue&&position==previousPos)
            {
                return;
            }
            myToolTip.RemoveAll();

            var hit = chartDate.HitTest(position.X, position.Y, ChartElementType.DataPoint);
            if (hit.ChartElementType==ChartElementType.DataPoint)
            {
                //var xValue = ((DataPoint)hit.Object).AxisLabel;
                //var xValue = Int32.Parse(hit.PointIndex.ToString())+1;
                var yValue = ((DataPoint)hit.Object).YValues[0];

                //myToolTip.Show(xValue + "판매량 : " + yValue+"개",chartDate,new Point(position.X+10,position.Y));
                myToolTip.Show("판매량 : " + yValue+"개",chartDate,new Point(position.X+10,position.Y));
            }
        }
    }
}
