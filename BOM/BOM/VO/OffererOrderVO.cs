using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.VO
{
    class OffererOrderVO
    {
        private int off_Order_No;
        public int Off_Order_No
        {
            get { return off_Order_No; }
            set { off_Order_No = value; }
        }

        private int off_Order_OrderNo;
        public int Off_Order_OrderNo
        {
            get { return off_Order_OrderNo; }
            set { off_Order_OrderNo = value; }
        }

        private int mat_No;
        public int Mat_No
        {
            get { return mat_No; }
            set { mat_No = value; }
        }

        private int off_Order_EA;
        public int Off_Order_EA
        {
            get { return off_Order_EA; }
            set { off_Order_EA = value; }
        }

        private int off_No;
        public int Off_No
        {
            get { return off_No; }
            set { off_No = value; }
        }

        private DateTime off_Date;
        public DateTime Off_Date
        {
            get { return off_Date; }
            set { off_Date = value; }
        }

        public OffererOrderVO(int off_Order_No, int off_Order_OrderNo, int mat_No, int off_Order_EA, int off_No, DateTime off_Date)
        {
            Off_Order_No = off_Order_No;
            Off_Order_OrderNo = off_Order_OrderNo;
            Mat_No = mat_No;
            Off_Order_EA = off_Order_EA;
            Off_No = off_No;
            Off_Date = off_Date;
        }
    }
}