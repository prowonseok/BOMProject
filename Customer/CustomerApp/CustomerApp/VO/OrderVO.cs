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


        private int orderCusId;

        public int OrderCusId
        {
            get { return orderCusId; }
            set { orderCusId = value; }
        }

        private int orderProNo; 

        public int OrderProNo
        {
            get { return orderProNo; }
            set { orderProNo = value; }
        }

        private DateTime orderDate;

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        private int orderPrice;

        public int OrderPrice
        {
            get { return orderPrice; }
            set { orderPrice = value; }
        }

        private int orderEa;

        public int OrderEa
        {
            get { return orderEa; }
            set { orderEa = value; }
        }

        private int empNo;

        public int EmpNo
        {
            get { return empNo; }
            set { empNo = value; }
        }

    }
}
