using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BiliBiliBlockChain.Utils
{
    public class AuthUtil
    {
        private static volatile object singleLock = new object();
        private static AuthUtil authUtil;

        public CookieContainer cookieContainer = new CookieContainer();
        public string cookieString = "";
        public string DedeUserID = "";
        public string DedeUserID__ckMd5 = "";
        public string SESSDATA = "";
        public string Expires = "";
        public string bili_jct = "";
        public bool isLogin = false;
        public string currentUserId = "";
        public string currentUserName = "";

        private AuthUtil() { }

        public static AuthUtil getInstance()
        {
            if (authUtil == null)
            {
                lock (singleLock)
                {
                    if (authUtil == null)
                    {
                        authUtil = new AuthUtil();
                    }
                }
            }
            return authUtil;
        }
    }
}
