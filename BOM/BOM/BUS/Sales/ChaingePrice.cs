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

namespace BOM.BUS.Sales
{
    public partial class ChaingePrice : Form
    {
        List<ProductsListVO> productsList = new List<ProductsListVO>();

          
        public ChaingePrice()
        {
            InitializeComponent();
        }

        private void ChaingePrice_Load(object sender, EventArgs e) //
        {
            PriceView();
        }

        private void PriceView() //Price폼에 상품 목록 불러오는 메서드
        {
            
            productsList.Clear();
            productsList = new SalesDao().ProList();
            comboProduct.Items.Clear();
            foreach (var item in productsList)
            {
                comboProduct.Items.Add(item.ProductName);
            }
        }
        int comboProSelectedIndex = 0;
        private void comboProduct_DropDownClosed(object sender, EventArgs e) // 콤보박스에서 상품 선택시 가격, 정보 표시하는 메서드
        {
            comboProSelectedIndex = comboProduct.SelectedIndex;
            int price = Int32.Parse(productsList[comboProSelectedIndex].ProductPrice);
            lblPrice.Text = String.Format("{0:##,##0}", price) + " 원";// 0>0
            lblDate.Text = productsList[comboProduct.SelectedIndex].ProductDate.ToShortDateString(); 

        }

        private void btnExit_Click(object sender, EventArgs e) // 단가변경 폼 종료
        {
            this.Close();
        }

        private void btnChainge_Click(object sender, EventArgs e) // 단가 변경하는 메서드
        {            
            int IndexNo = new SalesDao().ProNo(comboProduct.Items[comboProSelectedIndex].ToString()); //제품번호            
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

        private bool CheckPrice(string text) //공백이나 숫자 이외의 값 입력 검출하는 메서드
        {
            bool checkResult = false;

            int.TryParse(text, out int result);
            if ( !string.IsNullOrEmpty(text) )
            {                
                checkResult = true;
            }
            else
            {
                MessageBox.Show("빈칸이나,숫자이외의 값을 저장할수 없습니다.");
            }           
            return checkResult;

          
        }

        SalesExcelDao se;
        private void txtChaingePrice_TextChanged(object sender, EventArgs e)
        {
            if (txtChaingePrice.Text.Length > 9)
            {
                return;
            }
            else
            {
                if (txtChaingePrice.Text == "")
                {
                    label4.Text = "";

                }
                else
                {
                    if (CheckPrice(txtChaingePrice.Text))
                    {
                        se = new SalesExcelDao();
                        try
                        {
                            label4.Text = se.NumToString(Int32.Parse(txtChaingePrice.Text));
                        }
                        catch (FormatException)
                        {
                           
                            txtChaingePrice.Text = "";
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }  
        }
    }
}
