using BiliBiliBlockChain.Model;
using BiliBiliBlockChain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BiliBiliBlockChain.Biz
{
    public class RequestCore
    {
        private static string TAG = "RequestCore";
        private static int maxRetryTimes = 3;
        private static volatile object lock1 = new object();
        private static volatile object reqListLock = new object();
        private static RequestCore requestCore = null;
        static List<RequestObject> reqList = new List<RequestObject>();

        private RequestCore()
        {
            ThreadStart req_start = new ThreadStart(get_req);
            Thread start_req = new Thread(req_start);
            start_req.Start();
        }

        public void AddReq(RequestObject req)
        {
            lock (reqListLock)
            {
                reqList.Add(req);
            }
        }

        public static RequestCore GetInstance()
        {
            if (requestCore == null)
            {
                lock (lock1)
                {
                    if (requestCore == null)
                    {
                        requestCore = new RequestCore();
                    }
                }
            }
            return requestCore
;
        }

        private static void get_req()
        {
            MyWebClient client = new MyWebClient();
            //WebProxy myProxy = new WebProxy("127.0.0.1", 8080);
            //client.Proxy = myProxy;
            client.Encoding = Encoding.UTF8;
            while (true)
            {
                client.Headers.Set(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36");
                Thread.Sleep(1000);
                byte[] rep = new byte[] { };
                RequestObject req = getOneTask();
                if (req != null)
                {
                    client.Headers = req.requestHeaders;
                    LogUtil.Log($"{TAG}-{req.method}-{req.url.ToString()}");
                    if (req.method.ToString().ToLower() == "get")
                    {
                        try
                        {
                            rep = client.DownloadData(req.url);
                            req.repByte = rep;
                            if (req.callBackFunc != null)
                            {
                                req.callBackFunc.Invoke(req);
                            }
                        }
                        catch (Exception e)
                        {
                            LogUtil.Log($"{TAG}-{req.method}-请求发生错误，{e.ToString()}", LogUtil.LogLevel.Error);
                            req.order = -1;
                            if (req.retryTime < maxRetryTimes)
                            {
                                req.retryTime++;
                                lock (reqListLock)
                                {
                                    reqList.Add(req);
                                }
                            }
                            else
                            {
                                LogUtil.Log($"{TAG}-{req.method}-{req.url.ToString()}丢弃", LogUtil.LogLevel.Warning);
                            }
                        }
                        req.repByte = rep;
                    }
                    else if (req.method.ToString().ToLower() == "post")
                    {
                        try
                        {
                            rep = client.UploadData(req.url, new byte[] { });
                            req.repByte = rep;
                            if (req.callBackFunc != null)
                            {
                                req.callBackFunc.Invoke(req);
                            }
                        }
                        catch (Exception e)
                        {
                            LogUtil.Log($"{TAG}-{req.method}-请求发生错误，{e.ToString()}", LogUtil.LogLevel.Error);
                            req.order = -1;
                            if (req.retryTime < maxRetryTimes)
                            {
                                req.retryTime++;
                                lock (reqListLock)
                                {
                                    reqList.Add(req);
                                }
                            }
                            else
                            {
                                LogUtil.Log($"{TAG}-{req.method}-{req.url.ToString()}丢弃", LogUtil.LogLevel.Warning);
                            }
                        }
                        req.repByte = rep;
                        try
                        {
                            req.meta.Add("rep_headers", client.ResponseHeaders);
                        }
                        catch (ArgumentException)
                        {
                            req.meta["rep_headers"] = client.ResponseHeaders;
                        }
                    }
                    else if (req.method.ToString().ToLower() == "form")
                    {
                        client.Headers.Set(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                        try
                        {
                            rep = client.UploadValues(req.url.ToString(), req.requestPara);
                            req.repByte = rep;
                            req.requestHeaders = client.ResponseHeaders;
                            if (req.callBackFunc != null)
                            {
                                req.callBackFunc.Invoke(req);
                            }
                        }
                        catch (Exception e)
                        {
                            LogUtil.Log($"{TAG}-{req.method}-请求发生错误，{e.ToString()}", LogUtil.LogLevel.Error);
                            req.order = -1;
                            if (req.retryTime < maxRetryTimes)
                            {
                                req.retryTime++;
                                lock (reqListLock)
                                {
                                    reqList.Add(req);
                                }
                            }
                            else
                            {
                                LogUtil.Log($"{TAG}-{req.method}-{req.url.ToString()}丢弃", LogUtil.LogLevel.Warning);
                            }
                        }

                        try
                        {
                            req.meta.Add("rep_headers", client.ResponseHeaders);
                        }
                        catch (ArgumentException)
                        {
                            req.meta["rep_headers"] = client.ResponseHeaders;
                        }
                    }
                }

            }

        }

        private static RequestObject getOneTask()
        {
            lock (reqListLock)
            {
                if (/*req_queue.Count > 0*/ reqList.Count > 0)
                {
                    byte[] rep = new byte[] { };
                    //RenrenRequestObject req = req_queue.Dequeue();
                    RequestObject req = null;
                    try
                    {
                        req = reqList.OrderByDescending(a => a.order).FirstOrDefault();
                    }
                    catch (KeyNotFoundException)
                    {

                    }
                    reqList.Remove(req);
                    return req;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
