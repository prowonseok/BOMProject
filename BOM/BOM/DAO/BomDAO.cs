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

        /// <summary>
        /// Select한 결과(DataTable)를 List<Materials>에 저장하는 경우 유효성 검사를 하는 메서드
        /// </summary>
        /// <param name="matLst"></param>
        /// <param name="dt"></param>
        private static void DataTableValidation(List<Materials> matLst, DataTable dt)
        {
            foreach (DataRow item in dt.Rows)
            {
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
            DataTableValidation(matLst, dt);
            return matLst;
        }


        /// <summary>
        /// Parameter없고 Mat_Level의 값이 0이 아닌 Materials Table의 데이터를 Select하는 메서드
        /// </summary>
        /// <returns> List<Materials>형식을 반환(Select한 값들을 저장한 List) </returns>
        public List<Materials> SelectBom2() {
            List<Materials> matLst = new List<Materials>(); //Select한 값들을 저장할 Collection

            string sp = "Bom_Mat_View_Procedure_No_Level_0"; 
            SqlParameter[] sqlParameters = null;

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);
            DataTableValidation(matLst, dt);
            return matLst;
        }

        /// <summary>
        /// Parameter와 특별한 조건 없이 Materials Table의 모든 데이터를 Select하는 메서드
        /// </summary>
        /// <returns> List<Materials>형식을 반환(Select한 값들을 저장한 List) </returns>
        public List<Materials> SelectBom()
        {
            List<Materials> matLst = new List<Materials>();//Select한 값들을 저장할 Collection

            string sp = "Bom_Mat_View_Procedure"; 
            SqlParameter[] sqlParameters = null;

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);
            DataTableValidation(matLst, dt);
            return matLst;
        }
        
        /// <summary>
        /// BOM등록 하는 메서드
        /// </summary>
        /// <param name="parentMatNo">부모 자재의 자재 번호</param>
        /// <param name="childMatNo">자식 자재의 자재 번호</param>
        /// <param name="childMatEA">필요 자식 자재 개수</param>
        /// <returns>등록이 성공인지 실패인지 여부를 반환</returns>
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

        /// <summary>
        /// 정전개시 BOM Table에서 매개변수로 보낸 자재 번호를 부모 자재로 가지는 자식 자재에 대한 정보와 필요 개수를 받아옴 
        /// 역전개시 BOM Table에서 매개변수로 보낸 자재 번호를 자식노드로 가지는 부모 노드에 대한 정보를 받아옴
        /// </summary>
        /// <param name="mat_No">자재 번호</param>
        /// <param name="procedure">프로시져명</param>
        /// <returns></returns>
        public DataTable SelectBom4(int mat_No, string procedure)
        {
            List<Materials> matLst = new List<Materials>();
            string sp = procedure;
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Mat_No", mat_No);

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);

            return dt;
        }

        /// <summary>
        /// BOM Table에서 부모 자재 번호와 자식 자재 번호를 매개변수 값과 비교하여 둘다 같은 경우 필요 자재 개수를 매개변수의 값으로 UPDATE
        /// </summary>
        /// <param name="pNo">부모 자재 번호</param>
        /// <param name="cNo">자식 자재 번호</param>
        /// <param name="ea">필요 자재 개수</param>
        /// <returns></returns>
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
