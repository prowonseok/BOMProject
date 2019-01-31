using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.VO
{
    class SalesVO
    {      
        private int orderNo; // 주문번호
        private string cusID; //회원아이디
        private string empID; //담당자
        private string pro_No; // 상품이름
        private int price; //판매 가격
        private int ea; //판매 개수
        private DateTime orderDate; //주문날짜
        private string orderComplete; //판매 상태

        public int OrderNo { get => orderNo; set => orderNo = value; }
        public string CusID { get => cusID; set => cusID = value; }
        public string EmpID { get => empID; set => empID = value; }
        public string Pro_No { get => pro_No; set => pro_No = value; }
        public int Price { get => price; set => price = value; }
        public int Ea { get => ea; set => ea = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public string OrderComplete { get => orderComplete; set => orderComplete = value; }
    }
}
