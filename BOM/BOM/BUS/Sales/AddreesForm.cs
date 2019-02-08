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
       
        List<Address> addrList; 
        public AddreesForm()
        {
            InitializeComponent();

            addrList = new List<Address>();
        }
        int totalCount = 0;
        int totalPage;
        int page = 1;
        //int startPage = 0;
        //int endPage = 0;
        //int pagecount=10;
        private void button1_Click(object sender, EventArgs e)
        {
            addrList.Clear();
            dgvAddr.DataSource = null;
            XmlDocument doc = xmldocument();

            //주소 검색
            SearchAddr(doc);
            //페이징 구현
            Paging(doc);            
        }

        private void AddrView()
        {            
            dgvAddr.DataSource = addrList;
            dgvAddr.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvAddr.AutoResizeColumns();
            dgvAddr.AutoResizeRows();
            dgvAddr.DataSource = addrList;
        }

        private void Paging(XmlDocument doc)
        {            
            XmlNodeList xmltotalCount = doc.DocumentElement.SelectNodes("/NewAddressListResponse/cmmMsgHeader");
            foreach (XmlNode item in xmltotalCount)
            {
                totalCount = Int32.Parse(item.SelectSingleNode("totalCount").InnerText);

            }
            totalPage = totalCount / 10;
            if (totalCount % 10 > 0)
            {
                totalPage++;
            }
            lblTest.Text = page + " ~ " + totalPage;
            AddrView();            
            //startPage = ((page - 1) / pagecount) * pagecount + 1;
            //endPage = startPage + pagecount - 1;
        }

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

        private void SearchAddr(XmlDocument doc) // 그리드뷰에 검색한 주소 표현
        {
            
            XmlNodeList xmlAddrList = doc.DocumentElement.SelectNodes("/NewAddressListResponse/newAddressListAreaCdSearchAll");
            foreach (XmlNode item in xmlAddrList)
            {
                addrList.Add(new Address
                {
                    ZipNo = Int32.Parse(item.SelectSingleNode("zipNo").InnerText),
                    NameAddr = "구주소: " + item.SelectSingleNode("rnAdres").InnerText + "\r도로명: " + item.SelectSingleNode("lnmAdres").InnerText
                });
            }
            AddrView();

        }

        private void AddreesForm_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSearchAddr_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null,null);
            }
        }
        string  selectAddr = "";
        private void button1_Click_1(object sender, EventArgs e)
        {
            Shipment ship = (Shipment)Owner;
            ship.Lbltest.Text = selectAddr;
            this.Close();
        }

        

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
        
        private void dgvAddr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectAddr = dgvAddr.Rows[e.RowIndex].Cells[1].Value.ToString();
         
        }
    }
}
