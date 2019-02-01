using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.VO
{
    class Products
    {
        private int pro_No;
        private int Mat_No;
        private int Pro_Price;
        private string pro_Name;
        private string pro_Spec;
        private int pro_Img_No;
        private DateTime pro_ChangePriceDate;

        public int Pro_No { get => pro_No; set => pro_No = value; }
        public int Mat_No1 { get => Mat_No; set => Mat_No = value; }
        public int Pro_Price1 { get => Pro_Price; set => Pro_Price = value; }
        public string Pro_Name { get => pro_Name; set => pro_Name = value; }
        public string Pro_Spec { get => pro_Spec; set => pro_Spec = value; }
        public int Pro_Img_No { get => pro_Img_No; set => pro_Img_No = value; }
        public DateTime Pro_ChangePriceDate { get => pro_ChangePriceDate; set => pro_ChangePriceDate = value; }
    }
}
