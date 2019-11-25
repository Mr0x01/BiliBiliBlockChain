using BiliBiliBlockChain.Biz;
using BiliBiliBlockChain.Model;
using BiliBiliBlockChain.Utils;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace BiliBiliBlockChain
{
    public partial class LoginBroswerFrame : Form
    {
        private AuthUtil authUtil;
        private MainForm mainForm;
        private static RequestCore requestCore = RequestCore.GetInstance();
        public LoginBroswerFrame()
        {
            InitializeComponent();
            authUtil = AuthUtil.getInstance();
            mainForm = new MainForm();
        }

        private void LoginBroswerFrame_Load(object sender, EventArgs e)
        {
            LogUtil.Log("启动登录窗口");
            loginBroswer.Navigated += LoginBroswer_Navigated;
            loginBroswer.ScriptErrorsSuppressed = true;
            loginBroswer.WebBrowserShortcutsEnabled = false;
            loginBroswer.IsWebBrowserContextMenuEnabled = false;
            loginBroswer.Navigating += LoginBroswer_Navigating;
            loginBroswer.Navigate(new Uri("https://passport.bilibili.com/ajax/miniLogin/minilogin"));
        }

        private void LoginBroswer_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            if (e.Url.AbsolutePath != "blank")
            {
                if (e.Url.ToString().Contains("https://passport.biligame.com/crossDomain?"))
                {
                    //登陆成功
                    NameValueCollection param = HttpUtility.ParseQueryString(e.Url.Query);
                    if (param != null && param.Count == 6)
                    {
                        LogUtil.Log("登陆成功");
                        authUtil.bili_jct = param["bili_jct"];
                        authUtil.DedeUserID = param["DedeUserID"];
                        authUtil.DedeUserID__ckMd5 = param["DedeUserID__ckMd5"];
                        authUtil.SESSDATA = param["SESSDATA"];
                        authUtil.Expires = param["Expires"];
                        StringBuilder cookieString = new StringBuilder();
                        cookieString.Append("bili_jct=").Append(HttpUtility.UrlEncode(param["bili_jct"])).Append("; ");
                        cookieString.Append("DedeUserID=").Append(HttpUtility.UrlEncode(param["DedeUserID"])).Append("; ");
                        cookieString.Append("DedeUserID__ckMd5=").Append(HttpUtility.UrlEncode(param["DedeUserID__ckMd5"])).Append("; ");
                        cookieString.Append("SESSDATA=").Append(HttpUtility.UrlEncode(param["SESSDATA"]));
                        authUtil.cookieString = cookieString.ToString();
                        authUtil.isLogin = true;
                        RequestObject requestObject = new RequestObject();
                        Uri followerUrl = new Uri($"https://api.bilibili.com/x/web-interface/nav");
                        requestObject.url = followerUrl;
                        WebHeaderCollection webHeader = new WebHeaderCollection();
                        webHeader.Add(HttpRequestHeader.Cookie, authUtil.cookieString);
                        requestObject.requestHeaders = webHeader;
                        requestObject.method = Method.get;
                        requestObject.callBackFunc = BlockChainCore.FetchLoginUserInfoCallBack;
                        requestCore.AddReq(requestObject);
                        MessageBox.Show("登陆成功");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("登陆失败，请重试。");
                        loginBroswer.Navigate(new Uri("https://passport.bilibili.com/ajax/miniLogin/minilogin"));
                    }
                }
                else
                {
                    HttpWebRequest myRequest = (HttpWebRequest)HttpWebRequest.Create(e.Url);
                    myRequest.Headers.Add(HttpRequestHeader.ContentEncoding, "utf-8");
                    myRequest.Headers.Add(HttpRequestHeader.Upgrade, "1");
                    myRequest.Headers.Add("Sec-Fetch-Site", "none");
                    myRequest.Headers.Add("Sec-Fetch-Mode", "navigate");
                    myRequest.Headers.Add("Sec-Fetch-User", "?1");
                    myRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
                    myRequest.Headers.Add("Pragma", "no-cache");
                    myRequest.Headers.Add("Cache-Control", "no-cache");
                    myRequest.Headers.Add("Accept-Language", "zh-CN,zh;q=0.9,ja;q=0.8");
                    myRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36";
                    myRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3";
                    //WebProxy myProxy = new WebProxy("127.0.0.1", 8080);
                    //myRequest.Proxy = myProxy;
                    HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                    loginBroswer.DocumentStream = myResponse.GetResponseStream();
                }
            }
        }

        private void LoginBroswer_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {



        }
    }
}
