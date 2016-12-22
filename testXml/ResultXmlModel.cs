using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dayou.web.Models
{
    public class ResultXmlModel
    {
        //  <xml>
        //  <><![CDATA[SUCCESS]]></return_code>
        //  <><![CDATA[每个红包的平均金额必须在1.00元到200.00元之间.]]></return_msg>
        //  <><![CDATA[FAIL]]></result_code>
        //  <><![CDATA[MONEY_LIMIT]]></err_code>
        //  <><![CDATA[每个红包的平均金额必须在1.00元到200.00元之间.]]></err_code_des>
        //  <><![CDATA[201608223558780985]]></mch_billno>
        //  <><![CDATA[1303422501]]></mch_id>
        //  <><![CDATA[wxac221cf8e9e01bb0]]></wxappid>
        //  <><![CDATA[oGjxztzvxFceFZj-AfW5k0gxyaG0]]></re_openid>
        //  <>1</total_amount>
        //</xml>
        public string return_code { get; set; }
        //public string return_msg { get; set; }
        //public string result_code { get; set; }
        //public string err_code { get; set; }
        //public string err_code_des { get; set; }
        //public string mch_billno { get; set; }
        //public string mch_id { get; set; }
        //public string wxappid { get; set; }
        //public string re_openid { get; set; }
        //public string total_amount { get; set; }
    }
}