using CustomerApp.VO;
using dllPackager;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

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
            try
            {
                var proDataTable = db.ExecuteParametersDT(sp, null);
                foreach (DataRow row in proDataTable.Rows)
                {
                    int proNo = int.Parse(row["Pro_No"].ToString());
                    ProductVO product = new ProductVO()
                    {
                        No = proNo,
                        Name = row["Pro_Name"].ToString(),
                        MatNo = int.Parse(row["Mat_No"].ToString()),
                        Price = int.Parse(row["Pro_Price"].ToString()),
                        Image = (Image)im.ConvertFrom(row["Pro_Img_Image"]),
                        MatList = GetMatList(proNo)
                    };
                    proList.Add(product);
                }
                return proList;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        //private List<string> GetMatList(int proNo, List<string> matList)
        //{
        //    string sp = "SelectProDetail";
        //    SqlParameter[] proInfo = new SqlParameter[1];
        //    proInfo[0] = new SqlParameter("Pro_No", proNo);
        //    var matDataTable = db.ExecuteParametersDT(sp, proInfo);

        //    foreach (DataRow row in matDataTable.Rows)
        //    {
        //        matList.Add(row["Mat_Type_Category"].ToString());
        //        matList.Add(row["Mat_Name"].ToString());
        //    }
        //    return matList;
        //}

        private string GetMatList(int proNo)
        {
            string matList = string.Empty;
            string sp = "SelectProDetail";
            SqlParameter[] proInfo = new SqlParameter[1];
            proInfo[0] = new SqlParameter("Pro_No", proNo);
            var matDataTable = db.ExecuteParametersDT(sp, proInfo);

            matList = matDataTable.Rows[0]["Pro_Spec"].ToString();
            //foreach (DataRow row in matDataTable.Rows)
            //{
                
            //    //matList.Add(row["Mat_Name"].ToString());
            //}
            return matList;
        }

        public int GetProCount(int proNo)
        {
            try
            {
                int proCount;

                string sp = "SelectProCount";
                SqlParameter[] proInfo = new SqlParameter[1];
                proInfo[0] = new SqlParameter("Pro_No", proNo);
                var dataTable = db.ExecuteParametersDT(sp, proInfo);

                proCount = int.Parse(dataTable.Rows[0]["Mat_EA"].ToString());

                return proCount;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
