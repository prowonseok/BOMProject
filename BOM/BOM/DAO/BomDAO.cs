using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOM.VO;

namespace BOM.DAO
{
    class BomDAO
    {
        private DBConnection con;

        public BomDAO() {
            con = new DBConnection();
        }

        public List<Materials> SelectBom() {
            List<Materials> matLst = new List<Materials>();

            string sp = "Bom_Mat_View_Procedure";
            SqlParameter[] sqlParameters = null;

            DataTable dt = con.ExecuteSelect(sp, sqlParameters);

            foreach (DataRow item in dt.Rows)
            {
                matLst.Add(new Materials
                {
                    Mat_No=Int32.Parse(item["Mat_No"].ToString()),
                    Mat_Name=item["Mat_Name"].ToString(),
                    Mat_Level=Int32.Parse(item["Mat_Level"].ToString())
                    }
                );
            }
            return matLst;
        }
    }
}
