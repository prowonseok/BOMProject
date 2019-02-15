using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.VO
{
    class OrderVO
    {
        private int orderNo;

        public int OrderNo
        {
            get { return orderNo; }
            set { orderNo = value; }
        }

        private int order_OrderNo;

        public int Order_OrderNo
        {
            get { return order_OrderNo; }
            set { order_OrderNo = value; }
        }

        private string proName; 

        public string ProName
        {
            get { return proName; }
            set { proName = value; }
        }

        private DateTime orderDate;

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private int ea;

        public int EA
        {
            get { return ea; }
            set { ea = value; }
        }

        private string empName;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        private int empNo;

        public int EmpNo
        {
            get { return empNo; }
            set { empNo = value; }
        }


        private int cusNo;

        public int CusNo
        {
            get { return cusNo; }
            set { cusNo = value; }
        }

        private int proNo;

        public int ProNo
        {
            get { return proNo; }
            set { proNo = value; }
        }

    }
}
