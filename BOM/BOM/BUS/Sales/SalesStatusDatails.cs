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

namespace BOM.BUS.Sales
{
    public partial class SalesStatusDatails : Form
    {
        DBProcessor dbp;
        int thisContantsIndex;
        string productsName;
        public SalesStatusDatails(int contantsIndex)
        {
            InitializeComponent();
            dbp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            thisContantsIndex = contantsIndex;
        }
        
        private void SalesStatusDatails_Load(object sender, EventArgs e)
        {
            if (thisContantsIndex == -1)
            {

            }
            else
            {
                SalesInfo();                
                if (Int32.Parse(lblProEA.Text.Replace(" 개", "")) > Int32.Parse(lblProductCount.Text.Replace(" 개", "")))
                {
                    btn1.Enabled = true;
                }
            }                       
        }
        /// <summary>
        /// 주문내역을 상세하게 보여주는 메서드
        /// </summary>
        private void SalesInfo()
        {            
            DataTable dataTable = dbp.ExecuteParametersDT("Bom_JW_ProSelect2_Procedure", null);
            lblOrderNo.Text = dataTable.Rows[thisContantsIndex]["Cus_Order_OrderNo"].ToString();
            productsName = lblCusID.Text = dataTable.Rows[thisContantsIndex]["Cus_ID"].ToString();
            lblProName.Text = dataTable.Rows[thisContantsIndex]["Pro_Name"].ToString();
            lblProEA.Text = dataTable.Rows[thisContantsIndex]["Cus_Order_EA"].ToString() + " 개";
            int price = Int32.Parse(dataTable.Rows[thisContantsIndex]["Cus_Order_Price"].ToString());
            lblDate.Text = (DateTime.Parse(dataTable.Rows[thisContantsIndex]["Cus_Order_Date"].ToString()).ToShortDateString()).ToString();
            lblEmpName.Text = dataTable.Rows[thisContantsIndex]["Emp_Name"].ToString();
            if (dataTable.Rows[thisContantsIndex]["Mat_No"].ToString() == "")
            {
                lblProductCount.Text = "0" + " 개";
            }
            else
            {
                lblProductCount.Text = dataTable.Rows[thisContantsIndex]["Mat_No"].ToString() + " 개";
            }
            
            lblPhone.Text = dataTable.Rows[thisContantsIndex]["Cus_Phone"].ToString();
            lblAddr.Text = dataTable.Rows[thisContantsIndex]["Cus_Addr"].ToString();
            lblOrderPrice.Text = String.Format("{0:##,##0}", price) + " 원";
        }
        /// <summary>
        /// 출하지시에 필요한 주문번호를 넘겨주면서 출하지시폼을 띄워주는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e)
        {
            Shipment s = new Shipment(Int32.Parse(lblOrderNo.Text), lblCusID.Text); 
            s.Show();
        }
    }
}
