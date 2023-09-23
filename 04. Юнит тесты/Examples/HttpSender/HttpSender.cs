using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Example8
{
    public class HttpSender
    {
        public string SendRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.UseDefaultCredentials = true;
            request.ContentLength = 0;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode.ToString().ToLower() == "ok")
            {
                Stream content = response.GetResponseStream();
                StreamReader contentReader = new StreamReader(content);
                string result = contentReader.ReadToEnd();
                return result;
            }
            return "";
        }
    }
}
