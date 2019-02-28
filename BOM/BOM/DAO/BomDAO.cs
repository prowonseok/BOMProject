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
        /// Products Table의 모든 데이터를 출력하는 프로시져
        /// </summary>
        /// <returns>ProductsTable의 내용을 List<Products>에 저장 후 반환</returns>
        internal List<Products> SelectPro()
        {
            List<Products> proLst = new List<Products>();
            string sp = "Bom_Pro_Select_Procedure";
            SqlParameter[] sqlParameters = null;
            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);

            foreach (DataRow item in dt.Rows)
            {
                proLst.Add(new Products {
                    Pro_No=Int32.Parse(item["Pro_No"].ToString()),
                    Pro_Name=item["Pro_Name"].ToString(),
                    Mat_No=Int32.Parse(item["Mat_No"].ToString()),
                    Pro_Price=Int32.Parse(item["Pro_Price"].ToString())
                });
            }
            return proLst;

        }

        /// <summary>
        /// 상품 번호를 입력받아서 해당 상품번호가 BOM Table의 부모 자재일때의 부모 자재명, 자식 자재명, 자식 자재 필요 개수 
        /// </summary>
        /// <param name="pro_No">상품 번호</param>
        /// <returns>Parameter로 보낸 상품번호가 BOM Table의 부모 자재일때의 부모 자재명, 자식 자재명, 자식 자재 필요 개수 를 DataTable로 반환</returns>
        internal DataTable SelectTreeview(int pro_No)
        {
            string sp = "BOM_Bom_Treeview_Procedure";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Pro_No", pro_No);

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);
            return dt;
        }

        /// <summary>
        ///부모 자재명을 입력받아서 BOM테이블과 JOIN 후 해당 자재를 부모로 가지고 있는 자식들의 자재명과 필요 개수 출력          
        /// </summary>
        /// <param name="child_Name">부모 자재명</param>
        /// <returns>Parameter로 보낸 자재를 부모로 가지고 있는 자식들의 자재명과 필요 개수 출력한 DataTable</returns>
        internal DataTable SelectChildTreeview(string child_Name) {
            string sp = "BOM_Bom_ChildTreeview_Procedure";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Child_Name", child_Name);

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);
            return dt;
        }

        /// <summary>
        /// BOM등록 하는 프로시져
        /// </summary>
        /// <param name="parentMatNo">부모 자재의 자재 번호</param>
        /// <param name="childMatNo">자식 자재의 자재 번호</param>
        /// <param name="childMatEA">필요 자식 자재 개수</param>
        /// <returns>등록이 성공인지 실패인지 여부를 반환</returns>
        internal bool InsertBom(string parentMatNo, string childMatNo, string childMatEA)
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
        /// BOM Table에서 부모 자재 번호와 자식 자재 번호를 매개변수 값과 비교하여 둘다 같은 경우 필요 자재 개수를 매개변수의 값으로 UPDATE
        /// </summary>
        /// <param name="pNo">부모 자재 번호</param>
        /// <param name="cNo">자식 자재 번호</param>
        /// <param name="ea">필요 자재 개수</param>
        /// <returns>Update성공 여부</returns>
        internal bool UpdateBom(int pNo, int cNo, int ea) {
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

        /// <summary>
        /// 달을 매개변수로 입력하여 제품별 해당하는 달의 전체 판매량, 참고한 년도의 수, 현재 재고를 출력 
        /// </summary>
        /// <param name="month">구하고자 하는 달</param>
        /// <returns>제품별 해당하는 달의 전체 판매량, 참고한 년도의 수, 현재 재고를 출력한 DataTable</returns>
        internal DataTable SelectProYear(int month)
        {
            string sp = "BOM_Bom_GroupYear_Select";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Cus_Order_Date_Month",month);

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);
            return dt;
        }

        /// <summary>
        /// BOM Table에서 부모 자재 번호와 자식 자재 번호를 매개변수 값과 비교하여 둘다 같은 경우 해당 데이터 DELETE
        /// </summary>
        /// <param name="pNo">부모 자재 번호</param>
        /// <param name="cNo">자식 자재 번호</param>
        /// <returns>Delete 성공 여부</returns>
        internal bool DeleteBom(int pNo, int cNo) {
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

        #region SelectBom Overloading

        /// <summary>
        /// Parameter와 특별한 조건 없이 Materials Table의 모든 데이터를 Select하는 메서드
        /// </summary>
        /// <returns> Materials Table의 내용을 DataTable에 저장 후 반환 </returns>
        internal DataTable SelectBom()
        {
            string sp = "Bom_Mat_View_Procedure";
            SqlParameter[] sqlParameters = null;

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);
            return dt;
        }

        /// <summary>
        /// Materials Table에서 원자재가 아닌 값들을 Select하는 프로시져
        /// </summary>
        /// <returns>Parameter없고 Mat_Level의 값이 0이 아닌 Materials Table의 데이터를 Select한 DataTable </returns>
        internal DataTable SelectBom(bool level_True)
        {
            string sp = "Bom_Mat_View_Procedure_No_Level_0";
            SqlParameter[] sqlParameters = null;

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);
            return dt;
        }

        /// <summary>
        /// 자식 자재는 부모 자재보다 Level값이 같거나 작은 값만 뜨며, 자신은 안뜨도록 설정
        /// </summary>
        /// <param name="mat_Level">부모 자재 레벨</param>
        /// <param name="mat_No">부모 자재 번호</param>
        /// <returns></returns>
        internal DataTable SelectBom(int mat_Level, int mat_No)
        {
            string sp = "Bom_Mat_View_Procedure_PLevel";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@Mat_Level", mat_Level);
            sqlParameters[1] = new SqlParameter("@Mat_No", mat_No);

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);
            return dt;
        }

        /// <summary>
        /// 정전개시 BOM Table에서 매개변수로 보낸 자재 번호를 부모 자재로 가지는 자식 자재에 대한 정보와 필요 개수를 받아옴 
        /// 역전개시 BOM Table에서 매개변수로 보낸 자재 번호를 자식노드로 가지는 부모 노드에 대한 정보를 받아옴
        /// </summary>
        /// <param name="mat_No">자재 번호</param>
        /// <param name="procedure">프로시져명</param>
        /// <returns></returns>
        internal DataTable SelectBom(int mat_No, string procedure)
        {
            List<Materials> matLst = new List<Materials>();
            string sp = procedure;
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Mat_No", mat_No);

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);

            return dt;
        }

        #endregion

        /// <summary>
        /// Customers_Order Table에서 판매 완료된 제품들을 Products Table과 조인하여 판매량을 가져옴
        /// </summary>
        /// <returns></returns>
        internal DataTable SelectOrder() {
            string sp = "BOM_Bom_ProStatistics";
            SqlParameter[] sqlParameters = null;

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);
            return dt;
        }

        /// <summary>
        /// Customers_Order Table에서 판매 완료된 제품들을 Products Table과 조인하여 제품별로 월별 판매량을 가져옴
        /// </summary>
        /// <returns></returns>
        internal DataTable SelectDateOrder()
        {
            string sp = "BOM_Bom_ProDateStatistics";
            SqlParameter[] sqlParameters = null;

            DataTable dt = con.ExecuteParametersDT(sp, sqlParameters);
            return dt;
        }


    }
}
