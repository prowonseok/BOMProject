using BOM.BUS.BOM;
using BOM.BUS.Sales;
using BOM.VO;
using dllPackager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOM.BUS
{
    public partial class FrmMain : Form
    {
        DBProcessor dbp;
        List<Cus_OrderVO> salesList;

        public FrmMain()
        {
            InitializeComponent();
            dbp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            salesList = new List<Cus_OrderVO>();
        }

        /// <summary>
        /// BOM 관리 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBOM_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FrmBomInfoControl fbic = new FrmBomInfoControl();
            panel1.Controls.Add(fbic);

            btnBomAdd.Visible = true;
            btnBomMatEstimating.Visible = true;
            btnBomSearch.Visible = true;
            btnProMatEstimating.Visible = true;
            btnSales1.Visible = false;
            btnSi.Visible = false;
            btnchp.Visible = false;
            btnma.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            button4.Visible = false;
            button1.Visible = false;
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Managements.FrmManageMain fmanagemain = new Managements.FrmManageMain();
            fmanagemain.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Sales.FrmSalesMain fsalesmain = new Sales.FrmSalesMain();
            fsalesmain.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Test();      
            
        }

        private void Test()
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

        private void button1_Click(object sender, EventArgs e)
        {
            ////AddreesForm ad = new AddreesForm(2);
            //ad.Owner = this;
            //ad.Show();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            Test();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            Test();
        }

        private void 상품관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMainControl fmc = new FrmMainControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(fmc);
        }

        private void btnBomAdd_Click(object sender, EventArgs e)
        {
            FrmBomAdd fba = new FrmBomAdd();
            fba.ShowDialog();
        }

        /// <summary>
        /// BOM조회 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBomSearch_Click(object sender, EventArgs e)
        {
            FrmBomDetailInfo fbdi = new FrmBomDetailInfo();
            fbdi.ShowDialog();
        }

        /// <summary>
        /// 생산 예측 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBomMatEstimating_Click(object sender, EventArgs e)
        {
            FrmBomMatEstimating fme = new FrmBomMatEstimating();
            fme.ShowDialog();
        }

        /// <summary>
        /// 소요량 예측 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProMatEstimating_Click(object sender, EventArgs e)
        {

            FrmBomProEstimatingControl fbpe = new FrmBomProEstimatingControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(fbpe);
        }
    }
}