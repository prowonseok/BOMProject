using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.VO
{
    class CartVO
    {
        private int cartNo;

        public int CartNo
        {
            get { return cartNo; }
            set { cartNo = value; }
        }

        private int cusNo;

        public int CusNo
        {
            get { return cusNo; }
            set { cusNo = value; }
        }

        private int saveNo;

        public int SaveNo
        {
            get { return saveNo; }
            set { saveNo = value; }
        }


        private int proNo;

        public int ProNo
        {
            get { return proNo; }
            set { proNo = value; }
        }

        private int saveEA;

        public int SaveEA
        {
            get { return saveEA; }
            set { saveEA = value; }
        }

        private int totalPrice;

        public int TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        private DateTime cartDate;

        public DateTime CartDate
        {
            get { return cartDate; }
            set { cartDate = value; }
        }

        private string cusName;

        public string CusName
        {
            get { return cusName; }
            set { cusName = value; }
        }

        private string proName;

        public string ProName
        {
            get { return proName; }
            set { proName = value; }
        }
    }
}
