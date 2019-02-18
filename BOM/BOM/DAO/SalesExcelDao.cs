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
                int addPrice = 0; // 총 금액
                String oldStr = ","; // 문자열로 이뤄진 가격을 인트값으로 변경하기위한 변수
                String newStr = ""; //문자열로 이뤄진 가격을 인트값으로 변경하기위한 변수                
                wb = excelApp.Workbooks.Open(ExcelPath); // 엑셀 파일열기 없으면 만드는건 추가예정 
                ws = wb.Worksheets.get_Item(1) as Excel.Worksheet; //워크시트 선택            
                ws.Cells[3, 8] = orderInfoList[0]; //주문 번호
                ws.Cells[8, 8] = orderInfoList[1]; //출하 날짜
                //ws.Cells[4, 10] = OrderInfoList[2]; //고객명
                ws.Cells[4, 10] = orderInfoList[3]; //담당자
                //ws.Cells[3, 1] = OrderInfoList[4]; //고객 전화번호
                ws.Cells[9, 3] = orderInfoList[5]; //고객 주소

                
                for (int i = 0; i < productList.Count; i++)
                {
                    ws.Cells[i + 13, 2] = productList[i].ProName;
                    ws.Cells[i + 13, 7] = productList[i].ProEa;
                    ws.Cells[i + 13, 8] = productList[i].ProPrice;
                    addPrice += Int32.Parse(productList[i].ProPrice.Replace(oldStr, newStr).TrimEnd('원').ToString());                    
                }
                ws.Cells[10,2] = "      금 액 : " + NumToString(addPrice) +"              "+ @"(\"+String.Format("{0:##,##0}", addPrice) +")";

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
        } //엑셀에 데이터 저장하는 메서드
        private static void ReleaseExcelObject(object obj) //엑셀 사용이 끝나면 엑셀 메모리를 다 지위주는 메서드
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
        public string NumToString(Int64 HanglePrice) // 숫자로된 금액을 한글로 바꿔주는 메서드
        {
            string HAmt = ""; // 한글로 변환된 변수
            string EAmt = ""; //바꿀 가격 변수
            Int64 KLen = 0; // 하나씩 필터링 할 때 필요한 변수
            Int64 ELen = 0; // 바꿀 가격의 길이
            
            int k = 0;
            string W = ""; string Y = "";

            try
            {

                EAmt = HanglePrice.ToString();
                ELen = EAmt.Length;
                k = 0;
                for (int j = 0; j < ELen; j++)
                {
                    KLen = Convert.ToInt64(EAmt.Substring(j, 1)); // 1부터 0까지 한글로 필터링
                    switch (KLen)
                    {
                        case 1:
                            W = "일";
                            break;
                        case 2:
                            W = "이";
                            break;
                        case 3:
                            W = "삼";
                            break;
                        case 4:
                            W = "사";
                            break;
                        case 5:
                            W = "오";
                            break;
                        case 6:
                            W = "육";
                            break;
                        case 7:
                            W = "칠";
                            break;
                        case 8:
                            W = "팔";
                            break;
                        case 9:
                            W = "구";
                            break;
                        case 0:
                            W = "영";
                            break;
                    }
                    switch (ELen) //금액 단위를 한글로 필터링
                    {
                        case 10:
                            Y = "십억천백십만천백십원";
                            break;
                        case 9:
                            Y = "억천백십만천백십원";
                            break;
                        case 8:
                            Y = "천백십만천백십원";
                            break;
                        case 7:
                            Y = "백십만천백십원";
                            break;
                        case 6:
                            Y = "십만천백십원";
                            break;
                        case 5:
                            Y = "만천백십원";
                            break;
                        case 4:
                            Y = "천백십원";
                            break;
                        case 3:
                            Y = "백십원";
                            break;
                        case 2:
                            Y = "십원";
                            break;
                        case 1:
                            Y = "원";
                            break;
                    }

                    if (W != "영")  // 0이 아닐경우 Y선택된값에서 
                    {
                        HAmt = HAmt + (W + Y.Substring(k, 1)); //한글로 단위 필터링된 값을 k자리수부터 1길이까지 변환
                    }

                    if (Y.Substring(k, 1) == "억")
                    {
                        if (W == "영")
                        {
                            HAmt = HAmt + "억";
                        }
                    }
                    else if (Y.Substring(k, 1) == "만")
                    {
                        if (W == "영")
                        {
                            HAmt = HAmt + "만";
                        }
                    }
                    else if (Y.Substring(k, 1) == "원")
                    {
                        if (W == "영")
                        {
                            HAmt = HAmt + "원";
                        }
                    }

                    k = k + 1;
                }

                HAmt = HAmt + "정";

            }
            catch (Exception ee)
            {
                throw ee;
            }
            return HAmt;

        }
    }
}
