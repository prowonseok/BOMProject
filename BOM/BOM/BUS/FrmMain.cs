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
using System.Drawing.Text;
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

        private void BtnBOM_Click(object sender, EventArgs e)
        {
            button3.FlatAppearance.BorderSize = 1;
            BtnBOM.FlatAppearance.BorderSize = 3;
            btnSales.FlatAppearance.BorderSize = 1;
            btnManage.FlatAppearance.BorderSize = 1;
            FrmBomInfoControl fbic = new FrmBomInfoControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(fbic);
            //FrmBomInfo fbi = new FrmBomInfo();
            //fbi.ShowDialog();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            button3.FlatAppearance.BorderSize = 1;
            BtnBOM.FlatAppearance.BorderSize = 1;
            btnSales.FlatAppearance.BorderSize = 1;
            btnManage.FlatAppearance.BorderSize = 3;
            Managements.FrmManageMain fmanagemain = new Managements.FrmManageMain();
            fmanagemain.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            button3.FlatAppearance.BorderSize = 1;
            BtnBOM.FlatAppearance.BorderSize = 1;
            btnSales.FlatAppearance.BorderSize = 3;
            btnManage.FlatAppearance.BorderSize = 1;
            btnSales1.Visible = btnSi.Visible = btnchp.Visible = btnma.Visible = true;
            btnBomAdd.Visible = btnBomSearch.Visible = btnBomMatEstimating.Visible = btnProMatEstimating.Visible = false;
            //한줄더
            Sales.FrmSalesMain fsalesmain = new Sales.FrmSalesMain();
            fsalesmain.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Test();
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            //MessageBox.Show(Application.StartupPath);
            privateFonts.AddFontFile(Application.StartupPath + @"\Font\NanumSquareRoundB.ttf");
            Font font = new Font(privateFonts.Families[0], 14f);
            btnSi.Font = btnchp.Font = btnma.Font = button7.Font = btnSales1.Font = button3.Font = BtnBOM.Font = btnSales.Font = btnManage.Font = btnBomAdd .Font = btnBomSearch.Font = btnBomMatEstimating.Font = btnProMatEstimating.Font = font;

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
            button3.FlatAppearance.BorderSize = 3;
            BtnBOM.FlatAppearance.BorderSize = 1;
            btnSales.FlatAppearance.BorderSize = 1; 
            btnManage.FlatAppearance.BorderSize = 1;

            FrmMainControl fmc = new FrmMainControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(fmc);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSales1_Click(object sender, EventArgs e)
        {
            lblFunctionName.Text = "판매 조회";
            FrmSalesInquiryControl fs = new FrmSalesInquiryControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(fs);
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            ChaingePrice cp = new ChaingePrice();
            cp.Show();
        }

        private void btnchp_Click(object sender, EventArgs e)
        {
            TraderSet ts = new TraderSet();
            ts.Show();
        }

        private void btnma_Click(object sender, EventArgs e)
        {
            lblFunctionName.Text = "매출 조회";
            FrmRevenueStatusControl fr = new FrmRevenueStatusControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(fr);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblFunctionName.Text = "출하 지시서";
            Shipment sh = new Shipment();
            sh.Show();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            txtTimer.Text = DateTime.Now.ToLongTimeString();

        }

        private void btnBomAdd_Click(object sender, EventArgs e)
        {

        }
    }
}