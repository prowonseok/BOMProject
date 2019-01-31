using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CustomerApp.VO;

namespace CustomerApp.DAO
{
    class SearchAddr
    {
        private string statusCode = string.Empty;
        private List<SearchAddrResult> result = new List<SearchAddrResult>();
        public string StatusCode { get => statusCode; set => statusCode = value; }

        internal List<SearchAddrResult> Search(string searchType, string searchTxt)
        {
            string apiKey = ConfigurationManager.AppSettings["apiKey"];
            string apiPath = "http://openapi.epost.go.kr/postal/retrieveNewAdressAreaCdService/retrieveNewAdressAreaCdService/getNewAddressListAreaCd?ServiceKey=" + apiKey + "&searchSe=" + searchType + "&srchwrd=" + searchTxt;
            var request = (HttpWebRequest)WebRequest.Create(apiPath);
            var response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var responseStream = response.GetResponseStream();
                var reader = new StreamReader(responseStream, Encoding.UTF8);
                string xmlContents = reader.ReadToEnd();
                reader.Close();

                var doc = new XmlDocument();
                doc.LoadXml(xmlContents);

                result.Clear();

                var root = doc.DocumentElement.SelectNodes("newAddressListAreaCd");

                foreach (XmlNode item in root)
                {
                    SearchAddrResult addrResult = new SearchAddrResult()
                    {
                        Addr = item.SelectSingleNode("lnmAdres").InnerText,
                        Post = item.SelectSingleNode("zipNo").InnerText
                    };

                    result.Add(addrResult);
                }
            }
            return result;
        }
    }
}
