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
        public async Task<string> SendRequest(string url)
        {
            var httpClient = new HttpClient();
                        
            var response = await httpClient.GetAsync(url);
            if (response.StatusCode.ToString().ToLower() == "ok")
            {
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
            return "";
        }
    }
}
