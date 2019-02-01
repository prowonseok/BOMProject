using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.VO
{
    class Cus_OrderVO
    {
        //보류 쓰이지않으면 삭제
        private int orderNo;
        private string cusID;        
        private string orderContants;
        private DateTime orderDate;

        public int OrderNo { get => orderNo; set => orderNo = value; }
        public string CusID { get => cusID; set => cusID = value; }
        public string OrderContants { get => orderContants; set => orderContants = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
    }
}
