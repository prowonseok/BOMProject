using dllPackager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
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
        public SalesStatusDatails(int contantsIndex)
        {
            InitializeComponent();

            dbp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            thisContantsIndex = contantsIndex;
        }

        private void SalesStatusDatails_Load(object sender, EventArgs e)
        {
            DataTable dataTable = dbp.ExecuteParametersDT("Bom_JW_ProSelect2_Procedure", null);

            lblOrderNo.Text =  dataTable.Rows[thisContantsIndex]["Cus_Order_OrderNo"].ToString();
            lblCusID.Text = dataTable.Rows[thisContantsIndex]["Cus_ID"].ToString();
            lblProName.Text = dataTable.Rows[thisContantsIndex]["Pro_Name"].ToString();
            lblProEA.Text = dataTable.Rows[thisContantsIndex]["Cus_Order_EA"].ToString()+" 개";
            lblOrderPrice.Text = dataTable.Rows[thisContantsIndex]["Cus_Order_Price"].ToString()+ " 원";
            lblDate.Text = (DateTime.Parse(dataTable.Rows[thisContantsIndex]["Cus_Order_Date"].ToString()).ToShortDateString()).ToString();
            lblEmpName.Text = dataTable.Rows[thisContantsIndex]["Emp_Name"].ToString();

            
        }
    }
}
