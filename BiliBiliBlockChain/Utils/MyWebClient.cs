using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BiliBiliBlockChain.Utils
{
    public class MyWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = (HttpWebRequest)base.GetWebRequest(address);
            request.Timeout = 10 * 60 * 1000;
            request.AllowAutoRedirect = false;
            return request;
        }

        protected override WebResponse GetWebResponse(WebRequest request)
        {
            try
            {
                HttpWebResponse rep = (HttpWebResponse)base.GetWebResponse(request);
                return rep;
            }
            catch (WebException e)
            {
                return e.Response;
            }
        }
    }
}
