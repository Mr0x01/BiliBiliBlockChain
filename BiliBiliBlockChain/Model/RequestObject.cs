using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BiliBiliBlockChain.Model
{
    public delegate void CallBackFunc(RequestObject rep);
    public enum Method
    {
        get,
        post,
        form
    }
    public class RequestObject
    {
        public Uri url { get; set; }
        public Method method { get; set; } = Method.get;
        public Dictionary<string, Object> meta
        { get; set; } = new Dictionary<string, Object>();
        public NameValueCollection requestPara { get; set; } = new NameValueCollection();
        public WebHeaderCollection requestHeaders { get; set; }
        public byte[] repByte { get; set; }
        public CallBackFunc callBackFunc { get; set; }
        public WebResponse response { get; set; }
        public int order { get; set; }//优先级
        public int retryTime { get; set; } = 0;
    }
}
