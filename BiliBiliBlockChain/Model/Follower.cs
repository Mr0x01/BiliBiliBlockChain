using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiliBiliBlockChain.Model
{
    public class FollowerOfficialVerify
    {
        public int type { get; set; }
        public string desc { get; set; }
    }

    public class FollowerLabel
    {
        public string path { get; set; }
    }

    public class FollowerVip
    {
        public int vipType { get; set; }
        public object vipDueDate { get; set; }
        public string dueRemark { get; set; }
        public int accessStatus { get; set; }
        public int vipStatus { get; set; }
        public string vipStatusWarn { get; set; }
        public int themeType { get; set; }
        public FollowerLabel label { get; set; }
    }

    public class FollowerList
    {
        public int mid { get; set; }
        public int attribute { get; set; }
        public int mtime { get; set; }
        public object tag { get; set; }
        public int special { get; set; }
        public string uname { get; set; }
        public string face { get; set; }
        public string sign { get; set; }
        public FollowerOfficialVerify official_verify { get; set; }
        public FollowerVip vip { get; set; }
    }

    public class Follower_Data
    {
        public List<FollowerList> list { get; set; }
        public long re_version { get; set; }
        public int total { get; set; }
    }

    public class Follower
    {
        public int code { get; set; }
        public string message { get; set; }
        public int ttl { get; set; }
        public Follower_Data data { get; set; }
    }
}
