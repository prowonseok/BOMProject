using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.VO
{
    class ProductsListVO
    {
        private string productName;
        private string productPrice;
        private DateTime productDate;

        public string ProductName { get => productName; set => productName = value; }
        public string ProductPrice { get => productPrice; set => productPrice = value; }
        public DateTime ProductDate { get => productDate; set => productDate = value; }
    }
}
