using CustomerApp.VO;
using dllPackager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        private ImageConverter im = new ImageConverter();
        
        List<ProductVO> proList = new List<ProductVO>();

        public List<ProductVO> SelectAll()
        {
            proList.Clear();

            string sp = "SelectAllPro";
            var proDataTable = db.ExecuteParametersDT(sp, null);

            foreach (DataRow row in proDataTable.Rows)
            {
                int proNo = int.Parse(row["Pro_No"].ToString());
                List<string> matList = new List<string>();
                ProductVO product = new ProductVO()
                {
                    No = proNo,
                    Name = row["Pro_Name"].ToString(),
                    MatNo = int.Parse(row["Mat_No"].ToString()),
                    Price = int.Parse(row["Pro_Price"].ToString()),
                    Image = (Image)im.ConvertFrom(row["Pro_Img_Image"]),
                    MatList = GetMatList(proNo, matList)
                };
                proList.Add(product);
            }
            return proList;
        }

        private List<string> GetMatList(int proNo, List<string> matList)
        {
            string sp = "SelectProDetail";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("Pro_No", proNo);
            var matDataTable = db.ExecuteParametersDT(sp, sqlParameters);

            foreach (DataRow row in matDataTable.Rows)
            {
                matList.Add(row["Mat_Name"].ToString());
            }
            return matList;
        }
    }
}
