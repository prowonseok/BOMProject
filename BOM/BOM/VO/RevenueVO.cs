using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.VO
{
    class RevenueVO
    {
        private int orderNo;
        private DateTime orderDate;
        private string orderPrice;

        public int OrderNo { get => orderNo; set => orderNo = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public string OrderPrice { get => orderPrice; set => orderPrice = value; }
    }
}
