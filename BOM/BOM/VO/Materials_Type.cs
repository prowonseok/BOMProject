using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.VO
{
    class Materials_Type
    {
        int mat_Type_No;
        public int Mat_Type_No
        {
            get { return mat_Type_No; }
            set { mat_Type_No = value; }
        }

        private string mat_Type_Category;
        public string Mat_Type_Category
        {
            get { return mat_Type_Category; }
            set { mat_Type_Category = value; }
        }

        public Materials_Type(int mat_Type_No, string mat_Type_Category)
        {
            Mat_Type_No = mat_Type_No;
            Mat_Type_Category = mat_Type_Category;
        }
    }
}
