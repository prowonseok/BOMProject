using BOM.DAO;
using BOM.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOM.BUS
{
    public partial class ChaingePrice : Form
    {
        List<ProductsListVO> ProductsList = new List<ProductsListVO>();
          
        public ChaingePrice()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void ChaingePrice_Load(object sender, EventArgs e)
        {
            PriceView();
        }

        private void PriceView() //Price폼에 상품가격 표시
        {
            string sp = "Bom_JW_ProNameSelect2";
            ProductsList.Clear();
            ProductsList = new SalesDao().ComboProDuctList(sp);
            comboProduct.Items.Clear();
            foreach (var item in ProductsList)
            {
                comboProduct.Items.Add(item.ProductName);
            }
        }

        private void comboProduct_DropDownClosed(object sender, EventArgs e) // 콤보박스에서 상품선택시 가격표시
        {            
            int price = Int32.Parse(ProductsList[comboProduct.SelectedIndex].ProductPrice);
            lblPrice.Text = String.Format("{0:##,##0}", price) + " 원";// 0>0
            lblDate.Text = ProductsList[comboProduct.SelectedIndex].ProductDate.ToShortDateString(); 

        }

        private void btnExit_Click(object sender, EventArgs e) // 단가변경 폼 종료
        {
            this.Close();
        }

        private void btnChainge_Click(object sender, EventArgs e) // 단가 변경
        {
            int IndexNo = comboProduct.SelectedIndex+1;
            try
            {
                if (CheckPrice(txtChaingePrice.Text))
                {
                    if (new SalesDao().PriceUpdate(IndexNo, Int32.Parse(txtChaingePrice.Text)))
                    {
                        MessageBox.Show("변경 성공");
                        PriceView();
                    }
                    else
                    {
                        MessageBox.Show("저장 실패");
                    }                    
                }                
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool CheckPrice(string text) //공백이나 숫자 이외의 값 입력 검출
        {
            bool checkResult = false;

            int.TryParse(text, out int result);
            if ( !string.IsNullOrEmpty(text) && result!=0)
            {                
                checkResult = true;
            }
            else
            {
                MessageBox.Show("빈칸이나,숫자이외의 값을 저장할수 없습니다.");
            }           
            return checkResult;

          
        }
    }
}
