using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiliBiliBlockChain.Model
{
    public class UserInfoLevelInfo
    {
        public int current_level { get; set; }
        public int current_min { get; set; }
        public int current_exp { get; set; }
        public int next_exp { get; set; }
    }

    public class UserInfoOfficial
    {
        public int role { get; set; }
        public string title { get; set; }
        public string desc { get; set; }
    }

    public class UserInfoOfficialVerify
    {
        public int type { get; set; }
        public string desc { get; set; }
    }

    public class UserInfoPendant
    {
        public int pid { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public int expire { get; set; }
    }

    public class UserInfoWallet
    {
        public int mid { get; set; }
        public int bcoin_balance { get; set; }
        public int coupon_balance { get; set; }
        public int coupon_due_time { get; set; }
    }

    public class UserInfoData
    {
        public bool isLogin { get; set; }
        public int email_verified { get; set; }
        public string face { get; set; }
        public UserInfoLevelInfo level_info { get; set; }
        public int mid { get; set; }
        public int mobile_verified { get; set; }
        public int money { get; set; }
        public int moral { get; set; }
        public UserInfoOfficial official { get; set; }
        public UserInfoOfficialVerify officialVerify { get; set; }
        public UserInfoPendant pendant { get; set; }
        public int scores { get; set; }
        public string uname { get; set; }
        public int vipDueDate { get; set; }
        public int vipStatus { get; set; }
        public int vipType { get; set; }
        public int vip_pay_type { get; set; }
        public int vip_theme_type { get; set; }
        public UserInfoWallet wallet { get; set; }
        public bool has_shop { get; set; }
        public string shop_url { get; set; }
        public int allowance_count { get; set; }
        public int answer_status { get; set; }
    }

    public class UserInfo
    {
        public int code { get; set; }
        public string message { get; set; }
        public int ttl { get; set; }
        public UserInfoData data { get; set; }
    }
}
