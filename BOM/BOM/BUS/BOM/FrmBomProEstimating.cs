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
        List<string> proLst; //판매중인 제품들을 저장할 Collection

        DataTable dt2; //현재 달(월)에 대한 판매정보 저장하는 DataTable
        DataTable dt3; //현재 달(월)+1 달(월)에 대한 판매정보 저장하는 DataTable

        Point? previousPos = null; //null을 가질 수 있는 Point타입의 변수
        ToolTip myToolTip = new ToolTip();

        /// <summary>
        /// 생성자
        /// </summary>
        public FrmBomProEstimating()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 폼이 Load될때 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBomProEstimating_Load(object sender, EventArgs e)
        {
            #region 원형 그래프
            bDao = new DAO.BomDAO();

            chartPro.Titles.Add("제품별 판매량");
            dt = bDao.SelectOrder();
            proLst = new List<string>();

            cbbProducts.Items.Add("전체");

            foreach (DataRow item in dt.Rows)
            {
                chartPro.Series["s1"].Points.AddXY(item["Pro_Name"].ToString(), item["판매량"].ToString()); //chartPro Series["s1"]에 제품과 판매량을 등록
                proLst.Add(item["Pro_Name"].ToString()); //제품들을 proLst Collection에 저장
                cbbProducts.Items.Add(item["Pro_Name"].ToString()); //제품별로 보기 위한 ComboBox에 제품명 저장
            }
            #endregion

            #region 막대 그래프
            chartDate.Titles.Add("년도별 판매량");
            dt = bDao.SelectDateOrder();
            for (int i = 2016; i < DateTime.Now.Year + 1; i++)
            {
                cbbYear.Items.Add(i);
            }
            cbbProducts.Text = "전체";
            cbbYear.Text = "2019"; 
            #endregion

            //최초에 제품별 판매량을 화면에 출력
            btnPro_Click(null,null);
        }
        
        /// <summary>
        /// chartPro 위에서 마우스로 그래프를 가리키면 툴팁을 발생시키는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">현재 마우스의 위치 좌표</param>
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
        
        /// <summary>
        /// chartDate 위에서 마우스로 그래프를 가리키면 툴팁을 발생시키는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">현재 마우스의 위치</param>
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
                var yValue = ((DataPoint)hit.Object).YValues[0];
                myToolTip.Show("판매량 : " + yValue+"개",chartDate,new Point(position.X+10,position.Y));
            }
        }
        
        /// <summary>
        /// ComboBox의 값이 변경될 때 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartDate.Series.Clear();
            if (cbbProducts.Text=="전체")
            {
                foreach (var item in proLst)
                {   //ComboBox의 Text가 "전체"일 경우 PC전부를 Series에 추가
                    chartDate.Series.Add(item);
                }
            }
            else
            {
                //전체가 아닐 경우 선택된 제품만 Series에 추가
                chartDate.Series.Add(cbbProducts.Text);
            }


            foreach (DataRow item in dt.Rows)
            {
                if (item["YEAR"].ToString()==cbbYear.Text)
                {
                    if (cbbProducts.Text=="전체")
                    {
                        chartDate.Series[item["Pro_Name"].ToString()].Points.AddXY(item["MONTH"].ToString(), Int32.Parse(item["COUNT"].ToString()));
                    }
                    else
                    {
                        if (item["Pro_Name"].ToString() == cbbProducts.Text)
                        {
                            chartDate.Series[item["Pro_Name"].ToString()].Points.AddXY(item["MONTH"].ToString(), Int32.Parse(item["COUNT"].ToString()));
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 제품별 판매량 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPro_Click(object sender, EventArgs e)
        {
            #region Visible처리
            chartPro.Visible = true;
            chartDate.Visible = false;
            cbbProducts.Visible = false;
            cbbYear.Visible = false;
            dgvEst.Visible = false;
            dgvEst2.Visible = false;
            lblFirstMonth.Visible = false;
            lblSecondMonth.Visible = false; 
            #endregion
        }

        /// <summary>
        /// 년도별 판매량 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYear_Click(object sender, EventArgs e)
        {
            #region Visible처리
            chartPro.Visible = false;
            chartDate.Visible = true;
            cbbProducts.Visible = true;
            cbbYear.Visible = true;
            dgvEst.Visible = false;
            dgvEst2.Visible = false;
            lblFirstMonth.Visible = false;
            lblSecondMonth.Visible = false; 
            #endregion
        }

        /// <summary>
        /// 판매 예측 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstimating_Click(object sender, EventArgs e)
        {
            #region Visible처리
            dgvEst.Visible = true;
            dgvEst2.Visible = true;
            chartPro.Visible = false;
            chartDate.Visible = false;
            cbbProducts.Visible = false;
            cbbYear.Visible = false;
            lblFirstMonth.Visible = true;
            lblSecondMonth.Visible = true; 
            #endregion

            int firstMonth = DateTime.Now.Month;
            int secondMonth = 0;
            //12월 일 경우 다음 달이 1월로 지정
            if (firstMonth == 12)
            {
                secondMonth = 1;
            }
            else
            {
                secondMonth = firstMonth + 1;
            }

            dt2 = bDao.SelectProYear(firstMonth);
            dt3 = bDao.SelectProYear(secondMonth);

            GridviewCompute(dt2);
            GridviewCompute(dt3);

            dgvEst.DataSource = dt2;
            dgvEst2.DataSource = dt3;

            DisplayGridview(dgvEst);
            DisplayGridview(dgvEst2);
            lblFirstMonth.Text = DateTime.Now.Month + "월 판매 정보";
            lblSecondMonth.Text = DateTime.Now.Month + 1 + "월 판매 정보";
        }

        /// <summary>
        /// Gridview를 입력받아 Columns들에 대한 연산을 실행
        /// </summary>
        /// <param name="dt">연산을 실행 할 Gridview</param>
        private void GridviewCompute(DataTable dt)
        {
            dt.Columns.Add("평균 판매량");
            dt.Columns.Add("필요 안전재고량");

            foreach (DataRow item in dt.Rows)
            {
                item["평균 판매량"] = Int32.Parse(item["SALES"].ToString()) / Int32.Parse(item["YEAR"].ToString());
                if (Int32.Parse(item["평균 판매량"].ToString()) >= Int32.Parse(item["EA"].ToString()))
                {
                    item["필요 안전재고량"] = Int32.Parse(item["평균 판매량"].ToString()) - Int32.Parse(item["EA"].ToString());
                }
                else
                {
                    item["필요 안전재고량"] = 0;
                }
            }
            
        }

        /// <summary>
        /// 출력한 그리드뷰에 대해 설정하는 메서드
        /// </summary>
        /// <param name="gridView">출력정보를 수정할 Gridview</param>
        private void DisplayGridview(DataGridView gridView)
        {
            gridView.Columns.RemoveAt(2);
            gridView.Columns.RemoveAt(1);

            gridView.Columns[0].HeaderText = "제품명";
            gridView.Columns[1].HeaderText = "현재 재고";

            gridView.Columns[3].Width = 130;
            gridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            gridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
    }
}
