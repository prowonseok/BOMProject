using BOM.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BOM.BUS.Sales
{
    public partial class AddreesForm : Form
    {
       
        List<AddressVO> addrList;
        string selectAddr = ""; //선택한주소 출하지시서 폼으로 

        int totalCount = 0; //페이징 > 전체 데이터 갯수
        int totalPage; // 페이징 > 전체 페이지
        int page = 1; // > 페이징 > 페이지
        int distinction = 0; //호출된 메서드 구분
        public AddreesForm(int distinction)
        {
            this.distinction = distinction;
            InitializeComponent();

            addrList = new List<AddressVO>();
        }        
        
        private void button1_Click(object sender, EventArgs e) //주소 검색 클릭
        {            
            if (txtSearchAddr.Text == "")
            {
                MessageBox.Show("주소입력 하세요");
            }
            else
            {
                addrList.Clear();
                dgvAddr.DataSource = null;
                XmlDocument doc = xmldocument();

                //주소 검색
                SearchAddr(doc);
                //페이징 구현
                Paging(doc);
            }
        }

        private void AddrView() //검색결과를 한번더 그리드뷰에 출력하는 메서드
        {            
            dgvAddr.DataSource = addrList;
            dgvAddr.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvAddr.AutoResizeColumns();
            dgvAddr.AutoResizeRows();
            dgvAddr.DataSource = addrList;
            dgvAddr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAddr.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvAddr.Columns[0].Width = 55;
            dgvAddr.Columns[0].HeaderText = "지번";
            dgvAddr.Columns[1].HeaderText = "지명";
        }
        /// <summary>
        /// XML을 이용하여 데이터갯수를 파악하여 페이징을 만드는 메서드
        /// </summary>
        /// <param name="doc">API에서 가져온 데이터 XML</param>
        private void Paging(XmlDocument doc) 
        {            
            XmlNodeList xmltotalCount = doc.DocumentElement.SelectNodes("/NewAddressListResponse/cmmMsgHeader");
            foreach (XmlNode item in xmltotalCount)
            {
                try
                {
                    if (item.SelectSingleNode("totalCount").InnerText == "")
                    {
                        MessageBox.Show("검색된 주소결과가 없습니다");
                        return;
                    }
                    else
                    {
                        totalCount = Int32.Parse(item.SelectSingleNode("totalCount").InnerText);
                        totalPage = totalCount / 10;
                        if (totalCount % 10 > 0)
                        {
                            totalPage++;
                        }
                        lblTest.Text = page + " ~ " + totalPage;
                        AddrView();

                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("검색된 주소결과가 없습니다");
                    lblTest.Text = "";
                    return;

                }

            }
            
        }
        /// <summary>
        /// 공공데이터 포털에 주소API를 이용하여 주소검색을하고 검색결과를 가져오는 메서드
        /// </summary>
        /// <returns>API에서 받은 데이터를 XML형식으로 만든 변수</returns>
        private XmlDocument xmldocument() 
        {
            string serverUrl = "http://openapi.epost.go.kr/postal/retrieveNewAdressAreaCdSearchAllService/retrieveNewAdressAreaCdSearchAllService/getNewAddressListAreaCdSearchAll?ServiceKey=jwwy5dPFIMUMXJHkr2SEzG4v%2BH9OQHKzRCHg0B9cy%2B1ycgHLgWGpQU7HFCCCvp78YqiGeLpyLv5p6N8KCWkHVg%3D%3D&countPerPage=10&currentPage=" + page + "&srchwrd=" + txtSearchAddr.Text;

            HttpWebRequest request = WebRequest.Create(serverUrl) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            string statusCode = response.StatusCode.ToString();
            string xml = string.Empty;

            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
            xml = streamReader.ReadToEnd();
            streamReader.Close();
            stream.Close();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);            
            return doc;
        }
        /// <summary>
        /// 그리드뷰에 XML형태로된 데이터를 AddressVO객체화하여 출력
        /// </summary>
        /// <param name="doc">XML형태로된 주소 데이터</param>
        private void SearchAddr(XmlDocument doc) 
        {
            addrList.Clear();
            XmlNodeList xmlAddrList = doc.DocumentElement.SelectNodes("/NewAddressListResponse/newAddressListAreaCdSearchAll");
            foreach (XmlNode item in xmlAddrList)
            {
                try
                {
                    addrList.Add(new AddressVO
                    {
                        ZipNo = Int32.Parse(item.SelectSingleNode("zipNo").InnerText),
                        NameAddr = "도로명: " + item.SelectSingleNode("lnmAdres").InnerText + "\r구주소: " + item.SelectSingleNode("rnAdres").InnerText
                    });
                }
                catch (NullReferenceException)
                {
                    return;
                }
            }
            AddrView();
        }      
        /// <summary>
        /// 엔터누를시 주소검색버튼 활성화시키는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearchAddr_KeyUp(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null,null);
            }
        }
        
        /// <summary>
        /// 저장된 주소를 출하지시서 폼으로 넘기면서 출하지시서폼 띄우는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e) 
        {           
            if (selectAddr != "")
            {
                if (distinction ==1)
                {
                    Shipment ship = (Shipment)Owner;
                    ship.Lbltest.Text = "";
                    ship.Lbltest.Text = selectAddr;
                    this.Close();
                }
                else
                {
                    TraderSet ts = (TraderSet)Owner;
                    ts.TextBoxText.Text = "";
                    ts.TextBoxText.Text = selectAddr.Substring(0, selectAddr.IndexOf("구주소"));
                    this.Close();
                }                
            }
            else
            {
                this.Close();
            }            
        }       
        /// <summary>
        /// 페이징 구현후 다음페이지를 나타내는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e) // 다음페이지
        {
            if (page< totalPage)
            {
                addrList.Clear();
                dgvAddr.DataSource = null;
                page++;
                SearchAddr(xmldocument());                
                lblTest.Text = page + " ~ " + totalPage;
            }
            else
            {
                MessageBox.Show("마지막 페이지");
            }
        }
        /// <summary>
        /// 페이징 구현후 이전페이지를 나타내는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPre_Click(object sender, EventArgs e) //이전 페이지
        {
            if (page > 1)
            {
                addrList.Clear();
                dgvAddr.DataSource = null;
                page--;
                SearchAddr(xmldocument());                
                lblTest.Text = page + " ~ " + totalPage;
            }
            else
            {
                MessageBox.Show("첫번째 페이지");
            }
        }        
        /// <summary>
        /// 셀클릭하여 클릭한 주소의 값 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAddr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectAddr = dgvAddr.Rows[e.RowIndex].Cells[1].Value.ToString();         
        }

        private void AddreesForm_Load(object sender, EventArgs e)
        {
            dgvAddr.Font = new Font("맑은고딕", 9);
        }
    }
}
