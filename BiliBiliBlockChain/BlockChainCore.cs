using BiliBiliBlockChain.Biz;
using BiliBiliBlockChain.Model;
using BiliBiliBlockChain.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BiliBiliBlockChain
{
    public class BlockChainCore
    {
        private static RequestCore requestCore = RequestCore.GetInstance();
        private static AuthUtil authUtil = AuthUtil.getInstance();
        public static void FetchFollowerList(RequestObject req)
        {
            string re = Encoding.UTF8.GetString(req.repByte);
            int page = (int)req.meta["page"];
            var followerObject = JsonConvert.DeserializeObject<Follower>(re);
            for (int i = 0; i < followerObject.data.list.Count; i++)
            {
                int uid = followerObject.data.list[i].mid;
                RequestObject requestObject = new RequestObject();
                Uri followerUrl = new Uri($"https://api.bilibili.com/x/relation/modify");
                requestObject.url = followerUrl;
                WebHeaderCollection webHeader = new WebHeaderCollection();
                webHeader.Add(HttpRequestHeader.Cookie, authUtil.cookieString);
                requestObject.requestHeaders = webHeader;
                requestObject.method = Method.form;
                NameValueCollection paras = new NameValueCollection();
                paras.Add("fid", uid.ToString());
                paras.Add("act", "5");
                paras.Add("re_src", "11");
                paras.Add("jsonp", "jsonp");
                paras.Add("csrf", authUtil.bili_jct);
                requestObject.requestPara = paras;
                requestObject.callBackFunc = BlockUserCallBack;
                requestCore.AddReq(requestObject);
            }
        }

        public static void BlockUserCallBack(RequestObject req)
        {
            string re = Encoding.UTF8.GetString(req.repByte);
            //{"code":-111,"message":"csrf 校验失败","ttl":1}
            //{"code":0,"message":"0","ttl":1}
            JObject result = JObject.Parse(re);
        }
    }
}
