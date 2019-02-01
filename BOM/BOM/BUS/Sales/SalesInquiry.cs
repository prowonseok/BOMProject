using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOM.DAO;
using BOM.VO;

namespace BOM.BUS.Sales
{
    public partial class SalesInquiry : Form
    {
        List<ProductsListVO> lst2 = new List<ProductsListVO>();
        List<SalesVO> lst = new List<SalesVO>();
        public SalesInquiry()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtMember.Visible = false;
            comboProduct.Visible = false;
            if (rdoDate.Checked == true)
            {
                dtp1.Visible = dtp2.Visible = lbl1.Visible = true;
            }
            else
            {
                dtp1.Visible = dtp2.Visible = lbl1.Visible = false;
            }            
        }

        private void rdoMember_CheckedChanged(object sender, EventArgs e)
        {
            dtp1.Visible = dtp2.Visible = lbl1.Visible = false;
            comboProduct.Visible = false;
            if (rdoMember.Checked == true)
            {
                txtMember.Visible = true;
            }
            else
            {
                txtMember.Visible = false;
            }
        }

        private void rdoProduct_CheckedChanged(object sender, EventArgs e)
        {
            txtMember.Visible = false;
            dtp1.Visible = dtp2.Visible = lbl1.Visible = false;
            if (rdoProduct.Checked == true)
            {
                comboProduct.Visible = true;
            }
            else
            {
                comboProduct.Visible = false;
            }
            string sp2 = "Bom_JW_ProNameSelect2";
            lst2 = new SalesDao().ComboProDuctList(sp2);
            foreach (var item in lst2)
            {
                comboProduct.Items.Add(item.ProductName);
            }
        }

        
        
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = ""; //조회할 데이터 변수
            string search2 = ""; //조회할 데이터 변수
            string sp = ""; //사용할 저장 프로시저 변수
            string parameter1 = ""; // 프로시저 파라메터 변수
            string parameter2 = ""; // 프로시저 파라메터 변수

            if (rdoDate.Checked ==true)
            {
                sp = "Bom_JW_DateSelect Procedure";
                parameter1 = "@Date1";
                parameter2 = "@Date2";

                search = dtp1.Value.ToShortDateString();
                search2 = dtp2.Value.ToShortDateString();
            }
            else if(rdoMember.Checked == true)
            {
                parameter1 = "@CustomersName";
                sp = "Bom_JW_CusSelect Procedure";
                search = txtMember.Text;
            }
            else if(rdoProduct.Checked == true)
            {
                parameter1 = "@ProductsName";
                sp = "Bom_JW_ProSelect Procedure";
                search = comboProduct.Text;
            }
            try
            {
                lst.Clear();
                lst = new SalesDao().SalesSelect(sp, search, search2, parameter1, parameter2);

                dataGridView1.DataSource = lst;
                
                MessageBox.Show("Test");
            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }   
        }

        private void SalesInquiry_Load(object sender, EventArgs e)
        {

        }
    }
}
