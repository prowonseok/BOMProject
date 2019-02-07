using CustomerApp.VO;
using dllPackager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.DAO
{
    class ProductsDAO
    {
        private static string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        private DBProcessor db = new DBProcessor(conStr);

        public List<ProductVO> SelectAllPro()
        {
            var proList = new List<ProductVO>();
            string sp = "SelectAllPro";
            var dataTable = db.ExecuteParametersDT(sp, null);
            foreach (DataRow row in dataTable.Rows)
            {
                ImageConverter im = new ImageConverter();

                ProductVO product = new ProductVO()
                {
                    No = int.Parse(row["Pro_No"].ToString()),
                    Name = row["Pro_Name"].ToString(),
                    MatNo = int.Parse(row["Mat_No"].ToString()),
                    Price = int.Parse(row["Pro_Price"].ToString()),
                    Image = (Image)im.ConvertFrom(row["Pro_Img_Image"])
                };
                proList.Add(product);
            }
            return proList;
        }
    }
}
