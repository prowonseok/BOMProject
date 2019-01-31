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
            string sp = "Bom_JW_ProNameSelect2";
            ProductsList = new SalesDao().ComboProDuctList(sp);

            foreach (var item in ProductsList)
            {
                comboProduct.Items.Add(item.ProductName);
            }          
        }

        private void comboProduct_DropDownClosed(object sender, EventArgs e)
        {
            lblPrice.Text = ProductsList[comboProduct.SelectedIndex].ProductPrice;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChainge_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (CheckPrice(txtChaingePrice.Text))
            //    {
            //        new SalesDao().PriceUpdate(); 
            //    }
            //    MessageBox.Show("변경 성공");
            //}
            //catch (Exception)
            //{                
            //    throw;
            //}
        }

        //private bool CheckPrice(string text)
        //{
        //    bool check = false;
        //    if (!string.IsNullOrEmpty(text) )
        //    {

        //    }
        //}
    }
}
