using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.VO
{
    class ProductVO
    {
        private int proNo;

        public int No
        {
            get { return proNo; }
            set { proNo = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int matNo;

        public int MatNo
        {
            get { return matNo; }
            set { matNo = value; }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private Image image;

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

    }
}
