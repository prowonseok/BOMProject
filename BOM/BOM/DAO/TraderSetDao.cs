using BOM.VO;
using dllPackager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM.DAO
{
    class TraderSetDao
    {
        DBProcessor dbp = new DBProcessor(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        //거래처 등록 메서드
        /// <summary>
        /// 거래처 등록하는 메서드
        /// </summary>
        /// <param name="OffName">거래처 이름</param>
        /// <param name="OwnerName">대표자이름</param>
        /// <param name="OffAddr">대표 주소</param>
        /// <param name="mgr">담당 매니저</param>
        /// <param name="mgrMobile">매니저 번호</param>
        /// <param name="OffMobile">회사 번호</param>
        /// <returns>결과 메시지 반환</returns>
        internal string OffInsert(string OffName, string OwnerName, string OffAddr, string mgr, string mgrMobile, string OffMobile)
        {
            string sp = "Bom_JW_OffInsert";
            SqlParameter[] sqlParameters;
            int sqlParameterSize = 5;
            string result = "";            
            
            if (OffMobile != null)
            {
                sqlParameterSize++;
            }
            sqlParameters = new SqlParameter[sqlParameterSize];
            sqlParameters[0] = new SqlParameter("@OffName", OffName);
            sqlParameters[1] = new SqlParameter("@OwnerName", OwnerName);
            sqlParameters[2] = new SqlParameter("@OffAddr", OffAddr);
            sqlParameters[3] = new SqlParameter("@offMgrName", mgr);
            sqlParameters[4] = new SqlParameter("@OffMgrPhone", mgrMobile);
            if (OffMobile != null)
            {
                sqlParameters[5] = new SqlParameter("@OwnerPhone", OffMobile);
            }

            if (dbp.ExecuteParameters(sp, sqlParameters) != 0)
            {
                result = "등록성공";
            }
            else
            {
                result = "등록실패";
            }
            return result;            
        }
        /// <summary>
        /// 제품타입리스트를 반환하는 메서드
        /// </summary>
        /// <returns>제품리스트 반환 </returns>
        internal DataTable proTypeList()
        {
            DataTable proTypeList = new DataTable();
            string sp = "Bom_JW_ProType";
            try
            {
                proTypeList = dbp.ExecuteParametersDT(sp, null);
            }
            catch (Exception)
            {

                throw;
            }
            return proTypeList;
                
        }
       
        /// <summary>
        /// 거래처 목록 반환하는 메서드
        /// </summary>
        /// <returns>거래처 목록이 담긴 데이터테이블 반환</returns>
        internal DataTable OffList()
        {
            DataTable offList = new DataTable();
            string sp = "Bom_JW_OffList";

            try
            {
                offList = dbp.ExecuteParametersDT(sp, null);
                
            }
            catch (Exception)
            {
                throw;
            }
            return offList;

        }

        /// <summary>
        /// 자재를 추가하고 결과를 반환하는 메서드
        /// </summary>
        /// <param name="typeNo">자재타입 고유번호</param>
        /// <param name="MatManufactur">제조사</param>
        /// <param name="MatName">자재 이름</param>
        /// <param name="MatCost">자재 가격</param>
        /// <param name="MatLevel">자재 레벨</param>
        /// <param name="MatEA">재제 개수</param>
        /// <param name="offNo">거래처 고유번호</param>
        /// <returns>저장결과를 반환</returns>
        internal string MatInsert(int typeNo, string MatManufactur, string MatName, int MatCost, string MatLevel, int @MatEA, int offNo)
        {
            string sp = "BomJW_PMatInsert";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@MatTypeNo", typeNo);
            sqlParameters[1] = new SqlParameter("@MatManufactur", MatManufactur);
            sqlParameters[2] = new SqlParameter("@MatName", MatName);
            sqlParameters[3] = new SqlParameter("@MatCost", MatCost);
            sqlParameters[4] = new SqlParameter("@MatLevel", MatLevel);
            sqlParameters[5] = new SqlParameter("@MatEA", @MatEA);
            sqlParameters[6] = new SqlParameter("@OffNo", offNo);
            if (dbp.ExecuteParameters(sp, sqlParameters) != 0)
            {
                return "저장성공";
            }
            else
            {
                return "저장실패";
            }
        }
               
        List<MatInfoVO> matList = new List<MatInfoVO>(); 
        /// <summary>
        /// 링큐를 이용하여 자재정보를 반환하는 메서드
        /// </summary>
        /// <param name="MatName">자재이름</param>
        /// <returns>재재정보 반환</returns>
        internal ISingleResult<Bom_JW_MatInfoViewResult> LinqMatView(string MatName) 
        {
            MaterialsDataDataContext mddc = new MaterialsDataDataContext();
            
            return mddc.Bom_JW_MatInfoView(MatName);   //프로시저를 활용
        }
        /// <summary>
        /// 링큐를 이용하여 거래처 고유번호반환하는 메서드
        /// </summary>
        /// <param name="offName">거래처 이름</param>
        /// <returns>거래처 고유번호 반환</returns>
        public string GetOffNo(string offName)
        {
            MaterialsDataDataContext mddc = new MaterialsDataDataContext();

            var GetNo =
                from off in mddc.Offerer
                where off.Off_Name == offName
                select off.Off_No;
            int a = 0;
            foreach (var item in GetNo)
            {
                a = Int32.Parse(item.ToString());
            }
            return a.ToString() ;
        }
        /// <summary>
        /// 링큐를 이용하여 자재타입 고유번호 반환하는 메서드
        /// </summary>
        /// <param name="matTypeName">자재타입 이름</param>
        /// <returns>자재 고유번호 반환</returns>
        internal string GetMatTypeNo(string matTypeName)
        {            
            MaterialsDataDataContext mddc = new MaterialsDataDataContext();

            //mddc.BOM_JW_MOLLA()
            int a = 0;
            foreach (var item in mddc.BOM_JW_MOLLA(matTypeName))
            {
                a= Int32.Parse(item.Mat_Type_No.ToString());
            }
            
            return a.ToString();
        }
        /// <summary>
        /// 자재 수정하는 메서드
        /// </summary>
        /// <param name="MatName">자재이름</param>
        /// <param name="modifyOffNo">수정할 거래처번호</param>
        /// <param name="modifyMatTypeNo">수정할 자재타입 번호</param>
        /// <param name="matManufactur">수정할 제조사</param>
        /// <param name="matName">수정할 자재이름</param>
        /// <param name="matCost">수정할 단가</param>        
        internal void MatModify(string MatName, string modifyOffNo, string modifyMatTypeNo, string matManufactur, string matName, string matCost, string selectedItem)
        {
            MaterialsDataDataContext mddc = new MaterialsDataDataContext();
            if (MatName == "")
            {
                MatName = null;
            }
            if (modifyOffNo =="")
            {
                modifyOffNo = "575213"; //임의로 설정한 값
            }
            if (modifyMatTypeNo=="")
            {
                modifyMatTypeNo = "575213";
            }
            if (matManufactur == "")
            {
                matManufactur = null;
            }
            if (matName == "")
            {
                matName = null;
            }
            if (matCost == "")
            {
                matCost = "575213";
            }
            if (selectedItem == "")
            {
                selectedItem = "575213";
            }
            mddc.Bom_JW_MatUpdate(MatName, Int32.Parse(modifyOffNo), Int32.Parse(modifyMatTypeNo), matManufactur, matName, Int32.Parse(matCost), Int32.Parse(selectedItem));
        }

        internal int MatDelete(string matName)
        {
            MaterialsDataDataContext mddc = new MaterialsDataDataContext();
            string result = "";
            return mddc.Bom_JW_MatDelete(matName);
            //var dept = mddc.Materials.Where(x => x.Mat_Name == matName).SingleOrDefault();

            //if (dept != null)
            //{
            //    mddc.Materials.DeleteOnSubmit(dept);
            //    mddc.SubmitChanges();
            //    return result = "삭제 완료";
            //}
            //else
            //{
            //    return result = "삭제 실패";
            //}

            //var dept2 = from delete in mddc.Materials
            //            where delete.Mat_Name == matName
            //            select delete;
            //foreach (var item in dept2)
            //{
            //    mddc.Materials.DeleteOnSubmit(item);
            //}
            //try
            //{
            //    mddc.SubmitChanges();
            //    result = "삭제 완료";
            //}
            //catch (Exception)
            //{
            //    result = "삭제 실패";
            //    throw;
            //}
            
        }
    }
}
