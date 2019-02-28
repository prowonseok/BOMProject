using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //날짜별로 판매내역 조회
        {            
            txtMember.Visible = false;
            comboProduct.Visible = false;
            lblMsg.Visible = false;
            btnConfirm.Visible = false;
            if (rdoDate.Checked == true)
            {
                dtp1.Visible = dtp2.Visible = lbl1.Visible = true;
            }
            else
            {
                dtp1.Visible = dtp2.Visible = lbl1.Visible = false;
            }            
        }

        private void rdoMember_CheckedChanged(object sender, EventArgs e) // 회원별로 판매내역 조회
        {
            comboProduct.Items.Clear();
            dtp1.Visible = dtp2.Visible = lbl1.Visible = false;
            comboProduct.Visible = false;
            lblMsg.Visible = false;
            btnConfirm.Visible = false;
            if (rdoMember.Checked == true)
            {
                txtMember.Visible = true;
            }
            else
            {
                txtMember.Visible = false;
            }
        }

        private void rdoProduct_CheckedChanged(object sender, EventArgs e) //상품별로 판매내역 조회
        {
            comboProduct.Items.Clear();
            txtMember.Visible = false;
            dtp1.Visible = dtp2.Visible = lbl1.Visible = false;
            lblMsg.Visible = false;
            btnConfirm.Visible = false;
            if (rdoProduct.Checked == true)
            {
                comboProduct.Visible = true;
            }
            else
            {
                comboProduct.Visible = false;
            }
            
            lst2 = new SalesDao().ProList();
            foreach (var item in lst2)
            {
                comboProduct.Items.Add(item.ProductName);
                
            }
        }

        private void rdoSales_CheckedChanged(object sender, EventArgs e) //판매중인 내역 조회
        {
            lblMsg.Visible = true;
            btnConfirm.Visible = true;
            txtMember.Visible = false;
            dtp1.Visible = dtp2.Visible = lbl1.Visible = false;
            comboProduct.Visible = false;   
        }

        private void btnSearch_Click(object sender, EventArgs e)//클릭시 선택한 라디오버튼에 대한 정보를 출력하는 메서드
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
                search2 = dtp2.Value.AddDays(1).ToShortDateString();
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
            else if (rdoSales.Checked == true)
            {
                sp = "Bom_JW_Sales_Procedure";
            }           
            try
            {
                lst.Clear();
                
                if ((lst = new SalesDao().SalesSelect(sp, search, search2, parameter1, parameter2)).Count != 0)
                {
                    dataGridView1.DataSource = lst;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                }
                else
                {
                    dataGridView1.DataSource = lst;
                    MessageBox.Show("조건에 맞는 데이터가 없습니다");
                }                
            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            dataGridView1.Columns[0].HeaderText = "체크";
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].HeaderText = "주문번호";
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].HeaderText = "고객명";
            dataGridView1.Columns[3].HeaderText = "담당자";
            dataGridView1.Columns[4].HeaderText = "상품명";
            dataGridView1.Columns[5].HeaderText = "주문가격";
            dataGridView1.Columns[6].HeaderText = "개수";
            dataGridView1.Columns[7].HeaderText = "주문날짜";
            dataGridView1.Columns[8].HeaderText = "주문상태";

        }                 

        private void btnConfirm_Click(object sender, EventArgs e) //라디오버튼 판매중일때 그리드뷰 셀 체크한 목록 출하지시서로 정보 넘겨주면서 폼띄워주는 메서드
        {
            int NoCheckCount = 0; // 체크목록 없을경우 예외처리에 필요한 변수
            int checkRowIndex = 0;// 체크된 로우의 인덱스 값
            int numOfRepit = 0; // 로우 반복횟수.
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                numOfRepit++;                
                if (Convert.ToBoolean(item.Cells[0].Value))
                {
                    NoCheckCount++;                    
                }               
            }
            checkRowIndex = Int32.Parse(dataGridView1.Rows[checkRowIndex].Cells[1].Value.ToString());
            if (NoCheckCount == 0)
            {
                MessageBox.Show("체크한 목록이 없습니다.");
                return;
            }
            else
            {
                Shipment s = new Shipment(checkRowIndex);
                s.Show();
            }
            NoCheckCount = 0;

        }   

        private void SalesInquiry_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dataGridView1.Columns.Add(chk);
            btnSearch_Click(null, null);
            dataGridView1.Font = new Font("맑은고딕", 9);


        }
        
    }
}
