using BOM.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace BOM.DAO
{
    class SalesExcelDao
    {
        public string WriteExcelData(List<string> orderInfoList ,List<ShipmentVO> productList, string filePath)
        {
            string Ex;
            Excel.Application excelApp = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;
            string ExcelPath = @"C:\Users\GDI-11\Desktop\출하지시서.xlsx";
            try
            {
                excelApp = new Excel.Application();

                wb = excelApp.Workbooks.Open(ExcelPath); // 엑셀 파일열기 없으면 만드는건 추가예정 
                ws = wb.Worksheets.get_Item(1) as Excel.Worksheet; //워크시트 선택            
                ws.Cells[3, 8] = orderInfoList[0]; //주문 번호
                ws.Cells[8, 8] = orderInfoList[1]; //출하 날짜
                                                   // ws.Cells[4, 10] = OrderInfoList[2]; //고객명
                ws.Cells[4, 10] = orderInfoList[3]; //담당자
                //ws.Cells[3, 1] = OrderInfoList[4]; //고객 전화번호
                ws.Cells[9, 3] = orderInfoList[5]; //고객 주소
                for (int i = 0; i < productList.Count; i++)
                {
                    ws.Cells[i + 12, 2] = productList[i].ProName;
                    ws.Cells[i + 12, 7] = productList[i].ProEa;
                    ws.Cells[i + 12, 8] = productList[i].ProPrice;
                }

                if (filePath != null)
                {                    
                    wb.SaveCopyAs(filePath);// 새로운경로, 파일이름 변경시                    
                }
                else
                {
                    wb.Save();// 그대로 저장
                }        
                
                wb.Close(); 
                excelApp.Quit();                
            }
            catch (Exception ex)
            {               
                return Ex = ex.Message;
            }
            finally
            {
                ReleaseExcelObject(ws);
                ReleaseExcelObject(wb);
                ReleaseExcelObject(excelApp);
            }
            return Ex = "명세서 저장 완료";
        }
        private static void ReleaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
