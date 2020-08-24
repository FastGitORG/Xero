using System.IO;
using System.Net;
using System.Text;

namespace Xero.Util.Net
{
    class HttpGet
    {
        public static string Get(string url, string headerKey, string headerValue, int timeout = 10000, string userAgent = null)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            request.UserAgent = userAgent;
            request.Timeout = timeout;
            if (!string.IsNullOrEmpty(headerKey) && !string.IsNullOrEmpty(headerValue))
            {
                request.Headers.Add(headerKey + ":" + headerValue);
            }

            var resp = (HttpWebResponse)request.GetResponse();
            var rs = resp.GetResponseStream();
            var sr = new StreamReader(rs, Encoding.GetEncoding("utf-8"));
            string retString = sr.ReadToEnd();

            sr.Close();
            rs.Close();

            return retString;
        }

        public static string Get(string url, int timeout = 10000, string userAgent = null) => Get(url, "", "", timeout, userAgent);
    }
}
