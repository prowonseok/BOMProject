using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOM.VO;
using dllPackager;
using System.Configuration;
using BOM.BUS.Sales;
using System.Windows.Media;
using BOM.BUS;

namespace BOM
{
    public partial class FrmMainControl : UserControl
    {
        DBProcessor dbp;
        List<Cus_OrderVO> salesList;
        public FrmMainControl()
        {
            InitializeComponent();
            dbp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            salesList = new List<Cus_OrderVO>();

            
        }

        private void FrmMainControl_Load(object sender, EventArgs e)
        {
            dgvMainSales.Font = new Font("맑은고딕", 9);
            RealTiemSales();
        }
        /// <summary>
        /// 판매현황을 데이터 그리드뷰에 표현
        /// </summary>
        private void RealTiemSales()
        {
            salesList.Clear();
            dgvMainSales.DataSource = null;
            DataTable dataTable = dbp.ExecuteParametersDT("Bom_JW_MainSelect_Procedure", null);
            foreach (DataRow item in dataTable.Rows)
            {
                salesList.Add(new Cus_OrderVO
                {
                    OrderNo = Int32.Parse(item["Cus_Order_OrderNo"].ToString()),
                    CusID = item["Cus_ID"].ToString(),
                    OrderContants = item["Pro_Name"].ToString() + ", " + item["Cus_Order_EA"].ToString() + " 개",
                    OrderDate = DateTime.Parse(item["Cus_Order_Date"].ToString())
                });
            }
            dgvMainSales.DataSource = salesList;
            //dgvMainSales.AutoResizeColumns();
            dgvMainSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMainSales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvMainSales.Columns[0].Width = 70;
            dgvMainSales.Columns[1].Width = 80;
            dgvMainSales.Columns[3].Width = 150;
            dgvMainSales.Columns[0].HeaderText = "주문번호";
            dgvMainSales.Columns[1].HeaderText = "고객명";
            dgvMainSales.Columns[2].HeaderText = "주문내용";
            dgvMainSales.Columns[3].HeaderText = "주문날짜";

        }
        /// <summary>
        /// 그리드뷰에 판매중인 셀클릭시 상세폼을 띄워주는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMainSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

            }
            else
            {
                SalesStatusDatails ssd = new SalesStatusDatails(e.RowIndex);
                ssd.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RealTiemSales();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            txtTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RealTiemSales();
        }
    }
}
