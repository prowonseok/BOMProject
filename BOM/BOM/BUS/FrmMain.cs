using BOM.BUS.BOM;
using BOM.BUS.Managements;
using BOM.BUS.Managements.Controls;
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
using System.Threading;
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
            btnBomMain.Location = new Point(0, 224);
            btnBomAdd.Location = new Point(0, 253);
            btnBomSearch.Location = new Point(0, 282);
            btnBomMatEstimating.Location = new Point(0, 311);
            btnProMatEstimating.Location = new Point(0, 340);
            btnSales.Location = new Point(0, 370);
            btnManage.Location = new Point(0, 443);

            FrmBomInfoControl fbic = new FrmBomInfoControl();
            btnDateInsert.Controls.Clear();
            btnDateInsert.Controls.Add(fbic);
            btnBomMain.Visible = true;
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
            button7.Visible = false;
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            //button3.FlatAppearance.BorderSize = 1;
            //BtnBOM.FlatAppearance.BorderSize = 1;
            //btnSales.FlatAppearance.BorderSize = 1;
            //btnManage.FlatAppearance.BorderSize = 3;
            //Managements.FrmManageMain fmanagemain = new Managements.FrmManageMain();
            //fmanagemain.ShowDialog();
            button3.Location = new Point(0, 79);
            BtnBOM.Location = new Point(0, 151);
            btnSales.Location = new Point(0, 226);
            btnManage.Location = new Point(0, 300);
            btnBomMain.Visible = false;
            btnBomAdd.Visible = false;
            btnBomMatEstimating.Visible = false;
            btnBomSearch.Visible = false;
            btnProMatEstimating.Visible = false;
            btnSales1.Visible = false;
            btnSi.Visible = false;
            btnchp.Visible = false;
            btnma.Visible = false;
            button6.Visible = true;
            button5.Visible = true;
            button4.Visible = true;
            button1.Visible = true;
            button7.Visible = false;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            btnSales1.Location = new Point(0, 297);
            btnSi.Location = new Point(0, 326);
            btnchp.Location = new Point(0, 355);
            btnma.Location = new Point(0, 384);
            button7.Location = new Point(0, 413);
            btnSales.Location = new Point(0, 224);
            btnManage.Location = new Point(0, 443);

            
            btnSales1.Visible = btnSi.Visible = btnchp.Visible = btnma.Visible = button7.Visible = true;
            btnBomAdd.Visible = btnBomSearch.Visible = btnBomMatEstimating.Visible = btnProMatEstimating.Visible = btnBomMain.Visible= false;
            button1.Visible = button4.Visible = button5.Visible = button6.Visible = false;
            //한줄더
            //Sales.FrmSalesMain fsalesmain = new Sales.FrmSalesMain();
            //fsalesmain.ShowDialog();
        }

       
        private void FrmMain_Load(object sender, EventArgs e)
        {            
            FrmMainControl fmc = new FrmMainControl();
            btnDateInsert.Controls.Clear();
            btnDateInsert.Controls.Add(fmc);

            btnBomMain.ForeColor = btnSi.ForeColor = btnchp.ForeColor = btnma.ForeColor = button7.ForeColor = btnSales1.ForeColor = btnBomAdd.ForeColor =btnBomSearch.ForeColor = btnBomMatEstimating.ForeColor = btnProMatEstimating.ForeColor = Color.White;
            button3.ForeColor = BtnBOM.ForeColor = btnSales.ForeColor = btnManage.ForeColor = Color.White;

            btnBomMain.ForeColor = btnSi.ForeColor = btnchp.ForeColor = btnma.ForeColor = button7.ForeColor = btnSales1.ForeColor = btnBomAdd.ForeColor = btnBomSearch.ForeColor = btnBomMatEstimating.ForeColor = btnProMatEstimating.ForeColor =  Color.White;
            button1.ForeColor = button4.ForeColor = button5.ForeColor = button6.ForeColor = Color.White;
            button3.ForeColor =BtnBOM.ForeColor = btnSales.ForeColor = btnManage.ForeColor = Color.White;

            do
            {
                btnBomMain.ForeColor = btnSi.ForeColor = btnchp.ForeColor = btnma.ForeColor = button7.ForeColor = btnSales1.ForeColor = btnBomAdd.ForeColor = btnBomSearch.ForeColor = btnBomMatEstimating.ForeColor = btnProMatEstimating.ForeColor = Color.White;
                button3.ForeColor = BtnBOM.ForeColor = btnSales.ForeColor = btnManage.ForeColor = Color.White;


                foreach (var item in Controls)
                {
                    if (item.GetType().ToString() == "System.Windows.Forms.Button")
                    {
                        ((Button)item).BackColor = Color.Silver;
                    }
                }

            } while (false);
                    
            btnBomMain.Visible = false;
            btnBomAdd.Visible = false;
            btnBomMatEstimating.Visible = false;
            btnBomSearch.Visible = false;
            btnProMatEstimating.Visible = false;
            btnSales1.Visible = false;
            btnSi.Visible = false;
            btnchp.Visible = false;
            btnma.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            button4.Visible = false;
            button1.Visible = false;
            button7.Visible = false;

        }

        //private void Test()
        //{
        //    salesList.Clear();
        //    dgvMainSales.DataSource = null;
        //    DataTable dataTable = dbp.ExecuteParametersDT("Bom_JW_MainSelect_Procedure", null);
        //    foreach (DataRow item in dataTable.Rows)
        //    {
        //        salesList.Add(new Cus_OrderVO
        //        {
        //            OrderNo = Int32.Parse(item["Cus_Order_OrderNo"].ToString()),
        //            CusID = item["Cus_ID"].ToString(),
        //            OrderContants = item["Pro_Name"].ToString() + ", " + item["Cus_Order_EA"].ToString() + " 개",
        //            OrderDate = DateTime.Parse(item["Cus_Order_Date"].ToString())
        //        });                
        //    }

        //    dgvMainSales.DataSource = salesList;
        //    //dgvMainSales.AutoResizeColumns();
        //    dgvMainSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    dgvMainSales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        //    dgvMainSales.Columns[0].Width = 70;
        //    dgvMainSales.Columns[1].Width = 80;
        //    dgvMainSales.Columns[3].Width = 150;
        //    dgvMainSales.Columns[0].HeaderText = "주문번호";
        //    dgvMainSales.Columns[1].HeaderText = "고객명";
        //    dgvMainSales.Columns[2].HeaderText = "주문내용";
        //    dgvMainSales.Columns[3].HeaderText = "주문날짜";

        //}

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
        

        


        private void button3_Click(object sender, EventArgs e)
        {
            
            btnSales.Location = new Point(0, 224);
            btnManage.Location = new Point(0, 297);
            button3.FlatAppearance.BorderSize = 3;
            BtnBOM.FlatAppearance.BorderSize = 1;
            btnSales.FlatAppearance.BorderSize = 1; 
            btnManage.FlatAppearance.BorderSize = 1;
            btnSales1.Visible = btnSi.Visible = btnchp.Visible = btnma.Visible = button7.Visible = btnBomAdd.Visible = btnBomSearch.Visible = btnBomMatEstimating.Visible = btnProMatEstimating.Visible = btnBomMain.Visible = false;
            FrmMainControl fmc = new FrmMainControl();
            btnDateInsert.Controls.Clear();
            btnDateInsert.Controls.Add(fmc);
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
            FrmBomMatEstimating fmec = new FrmBomMatEstimating();
            fmec.ShowDialog();
        }

        /// <summary>
        /// 소요량 예측 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProMatEstimating_Click(object sender, EventArgs e)
        {
            lblFunctionName.Text = sender.ToString().Substring(sender.ToString().LastIndexOf('t') + 2);

            FrmBomProEstimatingControl fbpe = new FrmBomProEstimatingControl();
            btnDateInsert.Controls.Clear();
            btnDateInsert.Controls.Add(fbpe);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSales1_Click(object sender, EventArgs e)
        {
            lblFunctionName.Text = "판매 조회";
            FrmSalesInquiryControl fs = new FrmSalesInquiryControl();
            btnDateInsert.Controls.Clear();
            btnDateInsert.Controls.Add(fs);
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
            btnDateInsert.Controls.Clear();
            btnDateInsert.Controls.Add(fr);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblFunctionName.Text = "출하 지시서";
            Shipment sh = new Shipment();
            sh.Show();

        }


        private void CurrentTime()
        {
            
            //timer2_Tick(null, null);
            //txtTimer.Text = DateTime.Now.ToLongTimeString();
            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {

            //txtTimer.Text = DateTime.Now.ToLongTimeString();


            //txtTimer.Text = DateTime.Now.ToLongTimeString();

        }

        /// <summary>
        /// BOM 메인 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBomMain_Click(object sender, EventArgs e)
        {
            lblFunctionName.Text = sender.ToString().Substring(sender.ToString().LastIndexOf('t')+2);
            FrmBomInfoControl fbic = new FrmBomInfoControl();
            btnDateInsert.Controls.Clear();
            btnDateInsert.Controls.Add(fbic);

        }
        private void button5_Click(object sender, EventArgs e)
        {
            CtrlOrderMain com = new CtrlOrderMain();
            btnDateInsert.Controls.Clear();
            btnDateInsert.Controls.Add(com);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CtrlMatMain cmm = new CtrlMatMain();
            btnDateInsert.Controls.Clear();
            btnDateInsert.Controls.Add(cmm);
            cmm.btnMatAdd_Click(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CtrlProducts cpd = new CtrlProducts();
            btnDateInsert.Controls.Clear();
            btnDateInsert.Controls.Add(cpd);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CtrlMatMain cmm = new CtrlMatMain();
            btnDateInsert.Controls.Clear();
            btnDateInsert.Controls.Add(cmm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataInsertForm d = new DataInsertForm();
            d.Show();
        }
    }
}