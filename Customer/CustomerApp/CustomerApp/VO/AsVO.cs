using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.VO
{
    class AsVO
    {
        private int asNo;

        public int AsNo
        {
            get { return asNo; }
            set { asNo = value; }
        }

        private int orderNo;

        public int OrderNo
        {
            get { return orderNo; }
            set { orderNo = value; }
        }

        private int empNo;

        public int EmpNo
        {
            get { return empNo; }
            set { empNo = value; }
        }

        private int proNo;

        public int ProNo
        {
            get { return proNo; }
            set { proNo = value; }
        }

        private string asContent;

        public string AsContent
        {
            get { return asContent; }
            set { asContent = value; }
        }

        private string asPrice;

        public string AsPrice
        {
            get { return asPrice; }
            set { asPrice = value; }
        }

        private DateTime asStartDate;

        public DateTime AsStartDate
        {
            get { return asStartDate; }
            set { asStartDate = value; }
        }

        private string asEndDate;

        public string AsEndDate
        {
            get { return asEndDate; }
            set { asEndDate = value; }
        }

        private int cusNo;

        public int CusNo
        {
            get { return cusNo; }
            set { cusNo = value; }
        }

        private string proName;

        public string ProName
        {
            get { return proName; }
            set { proName = value; }
        }

        private string cusName;

        public string CusName
        {
            get { return cusName; }
            set { cusName = value; }
        }

        private string empName;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
    }
}
