using BiliBiliBlockChain.Biz;
using BiliBiliBlockChain.Model;
using BiliBiliBlockChain.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiliBiliBlockChain
{
    public partial class MainForm : Form
    {
        public static TextBox logBox1;
        public static PictureBox faceBox1;
        private AuthUtil authUtil;
        private RequestCore requestCore;
        public MainForm()
        {
            InitializeComponent();
            authUtil = AuthUtil.getInstance();
            requestCore = RequestCore.GetInstance();
        }

        private void MainForm_Loaded(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            logBox1 = logBox;
            faceBox1 = headImg;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginBroswerFrame loginBroswerFrame = new LoginBroswerFrame();
            loginBroswerFrame.ShowDialog();
        }

        private void userIdBlockStartBtn_Click(object sender, EventArgs e)
        {
            if (!authUtil.isLogin)
            {
                MessageBox.Show("未登录");
            }
            else
            {
                RequestObject requestObject = new RequestObject();
                Uri followerUrl = new Uri($"https://api.bilibili.com/x/relation/followers?vmid={userIdTextbox.Text}&pn=1&ps=50&order=desc&jsonp=jsonp");
                requestObject.url = followerUrl;
                WebHeaderCollection webHeader = new WebHeaderCollection();
                webHeader.Add(HttpRequestHeader.Cookie, authUtil.cookieString);
                requestObject.requestHeaders = webHeader;
                requestObject.method = Method.get;
                requestObject.callBackFunc = BlockChainCore.FetchFollowerList;
                requestObject.meta["page"] = 1;
                requestObject.meta["userId"] = userIdTextbox.Text;
                requestCore.AddReq(requestObject);
            }

        }

        private void AboutTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HeadImg_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
