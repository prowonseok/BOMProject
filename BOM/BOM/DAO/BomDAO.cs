using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOM.VO;
using dllPackager;

namespace BOM.DAO
{
    class BomDAO
    {
        private DBProcessor con;

        public BomDAO() {
            con = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        }
        public List<Products> SelectPro()
        {
            List<Products> proLst = new List<Products>();
            string sp = "Bom_Pro_View_Procedure";
            SqlParameter[] sqlParameters = null;
            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);

            foreach (DataRow item in dt.Rows)
            {
                proLst.Add(new Products {
                    Pro_No=Int32.Parse(item["Pro_No"].ToString()),
                    Pro_Name=item["Pro_Name"].ToString(),
                    Mat_No=Int32.Parse(item["Mat_No"].ToString())
                });
            }
            return proLst;

        }
        public DataTable SelectBom4(int mat_No, string procedure) {
            List<Materials> matLst = new List<Materials>();

            string sp = procedure;
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Mat_No",  mat_No);

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);
            
            return dt;
        }
        public bool Selectchildnode(string child_Name)
        {
            string sp = "BOM_Bom_ChiledNode_Procedure";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Child_Name", child_Name);

            if (con.ExecuteParametersDT(sp, sqlParameters).Rows.Count>0) 
            {
                return true; //자식의 자식이 있다
            }
            else
            {
                return false; //없다
            }
            
        }
        public DataTable SelectTreeview(int pro_No)
        {
            string sp = "BOM_Bom_Treeview_Procedure";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Pro_No", pro_No);

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);
            return dt;
        }
        public DataTable SelectChildTreeview(string child_Name) {
            string sp = "BOM_Bom_ChildTreeview_Procedure";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Child_Name", child_Name);

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);
            return dt;
        }
        public List<Materials> SelectBom3(int mat_Level, int mat_No) {
            List<Materials> matLst = new List<Materials>();

            string sp = "Bom_Mat_View_Procedure_PLevel";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@Mat_Level", mat_Level);
            sqlParameters[1] = new SqlParameter("@Mat_No", mat_No);

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);

            foreach (DataRow item in dt.Rows)
            {
                //재사용성을 위해 NULL값 허용인 값들을 NULL로 설정
                string mat_Manufactur = null;
                int cost = 0;
                int ea = 0;
                int off_No = 0;
                if (!string.IsNullOrEmpty(item["Mat_Manufactur"].ToString()))
                {
                    mat_Manufactur = item["Mat_Manufactur"].ToString();
                }
                if (!string.IsNullOrEmpty(item["Mat_Cost"].ToString()))
                {
                    cost = Int32.Parse(item["Mat_Cost"].ToString());
                }
                if (!string.IsNullOrEmpty(item["Mat_EA"].ToString()))
                {
                    ea = Int32.Parse(item["Mat_EA"].ToString());
                }
                if (!string.IsNullOrEmpty(item["Off_No"].ToString()))
                {
                    off_No = Int32.Parse(item["Off_No"].ToString());
                }
                matLst.Add(new Materials
                {
                    Mat_No = Int32.Parse(item["Mat_No"].ToString()),
                    Mat_Type_No = Int32.Parse(item["Mat_Type_No"].ToString()),
                    Mat_Manufactur = mat_Manufactur,
                    Mat_Name = item["Mat_Name"].ToString(),
                    Mat_Cost = cost,
                    Mat_Level = Int32.Parse(item["Mat_Level"].ToString()),
                    Mat_Ea = ea,
                    Off_No = off_No
                }
                );
            }
            return matLst;
        }
        public List<Materials> SelectBom2() {
            List<Materials> matLst = new List<Materials>();

            string sp = "Bom_Mat_View_Procedure_No_Level_0";
            SqlParameter[] sqlParameters = null;

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);

            foreach (DataRow item in dt.Rows)
            {
                //재사용성을 위해 NULL값 허용인 값들을 NULL로 설정
                string mat_Manufactur = null;
                int cost = 0;
                int ea = 0;
                int off_No = 0;
                if (!string.IsNullOrEmpty(item["Mat_Manufactur"].ToString()))
                {
                    mat_Manufactur = item["Mat_Manufactur"].ToString();
                }
                if (!string.IsNullOrEmpty(item["Mat_Cost"].ToString()))
                {
                    cost = Int32.Parse(item["Mat_Cost"].ToString());
                }
                if (!string.IsNullOrEmpty(item["Mat_EA"].ToString()))
                {
                    ea = Int32.Parse(item["Mat_EA"].ToString());
                }
                if (!string.IsNullOrEmpty(item["Off_No"].ToString()))
                {
                    off_No = Int32.Parse(item["Off_No"].ToString());
                }
                matLst.Add(new Materials
                {
                    Mat_No = Int32.Parse(item["Mat_No"].ToString()),
                    Mat_Type_No = Int32.Parse(item["Mat_Type_No"].ToString()),
                    Mat_Manufactur = mat_Manufactur,
                    Mat_Name = item["Mat_Name"].ToString(),
                    Mat_Cost = cost,
                    Mat_Level = Int32.Parse(item["Mat_Level"].ToString()),
                    Mat_Ea = ea,
                    Off_No = off_No
                }
                );
            }
            return matLst;
        }
        public List<Materials> SelectBom() {
            List<Materials> matLst = new List<Materials>();

            string sp = "Bom_Mat_View_Procedure";
            SqlParameter[] sqlParameters = null;

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);

            foreach (DataRow item in dt.Rows)
            {
                //재사용성을 위해 NULL값 허용인 값들을 NULL로 설정
                string mat_Manufactur = null;
                int cost=0;
                int ea=0;
                int off_No=0;
                if (!string.IsNullOrEmpty(item["Mat_Manufactur"].ToString()))
                {
                    mat_Manufactur = item["Mat_Manufactur"].ToString();
                }
                if (!string.IsNullOrEmpty(item["Mat_Cost"].ToString()))
                {
                    cost = Int32.Parse(item["Mat_Cost"].ToString());
                }
                if (!string.IsNullOrEmpty(item["Mat_EA"].ToString()))
                {
                    ea = Int32.Parse(item["Mat_EA"].ToString());
                }
                if (!string.IsNullOrEmpty(item["Off_No"].ToString()))
                {
                    off_No = Int32.Parse(item["Off_No"].ToString());
                }
                matLst.Add(new Materials
                {
                    Mat_No=Int32.Parse(item["Mat_No"].ToString()),
                    Mat_Type_No=Int32.Parse(item["Mat_Type_No"].ToString()),
                    Mat_Manufactur=mat_Manufactur,
                    Mat_Name=item["Mat_Name"].ToString(),
                    Mat_Cost=cost,
                    Mat_Level=Int32.Parse(item["Mat_Level"].ToString()),
                    Mat_Ea=ea,
                    Off_No=off_No
                    }
                );
            }
            return matLst;
        }
        public bool InsertBom(string parentMatNo, string childMatNo, string childMatEA)
        {
            string sp = "Bom_Bom_Insert_Procedure";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@BOM_ParentNo", Int32.Parse(parentMatNo));
            sqlParameters[1] = new SqlParameter("@BOM_ChildNo", Int32.Parse(childMatNo));
            sqlParameters[2] = new SqlParameter("@BOM_ChildEA", Int32.Parse(childMatEA));

            bool result = false;
            if (con.ExecuteParameters(sp, sqlParameters) != -1)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public bool UpdateBom(int pNo, int cNo, int ea) {
            string sp = "BOM_Bom_Update_Procedure";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@BOM_ParentNo", pNo);
            sqlParameters[1] = new SqlParameter("@BOM_ChildNo", cNo);
            sqlParameters[2] = new SqlParameter("@BOM_ChildEA", ea);
            bool result = false;
            if (con.ExecuteParameters(sp,sqlParameters) !=-1)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public bool DeleteBom(int pNo, int cNo) {
            string sp = "BOM_Bom_Delete_Procedure";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@BOM_ParentNo", pNo);
            sqlParameters[1] = new SqlParameter("@BOM_ChildNo", cNo);

            bool result = false;
            if (con.ExecuteParameters(sp, sqlParameters) !=-1)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
