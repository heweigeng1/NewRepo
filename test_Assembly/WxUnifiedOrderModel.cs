using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Assembly
{
    /// <summary>
    /// 统一下单 参数 (APP支付model)
    /// </summary>
    public class WxUnifiedOrderModel
    {
        /// <summary>
        /// 微信开放平台审核通过的应用APPID
        /// </summary>
        public string appid { get; set; }
        /// <summary>
        /// 附加数据，在查询API和支付通知中原样返回，该字段主要用于商户携带订单的自定义数据
        /// </summary>
        public string attach { get; set; }
        /// <summary>
        /// 商品描述交易字段格式根据不同的应用场景按照以下格式： APP——需传入应用市场上的APP名字-实际商品名称，天天爱消除-游戏充值。
        /// </summary>
        public string body { get; set; }
        /// <summary>
        /// 微信支付分配的商户号
        /// </summary>
        public string mch_id { get; set; }
        /// <summary>
        /// 随机字符串，不长于32位。推荐随机数生成算法
        /// </summary>
        public string nonce_str { get; set; }
        /// <summary>
        /// 接收微信支付异步通知回调地址，通知url必须为直接可访问的url，不能携带参数。
        /// </summary>
        public string notify_url { get; set; }
        /// <summary>
        /// 商户系统内部订单号，要求32个字符内，只能是数字、大小写字母_-|*@ ，且在同一个商户号下唯一。详见商户订单号
        /// </summary>
        public string out_trade_no { get; set; }
        /// <summary>
        /// 用户端实际ip
        /// </summary>
        public string spbill_create_ip { get; set; }
        /// <summary>
        /// 订单总金额，单位为分
        /// </summary>
        public int total_fee { get; set; }
        /// <summary>
        /// 支付类型 APP
        /// </summary>
        public string trade_type { get; set; }
        /// <summary>
        /// 签名
        /// </summary>
        public string sign { get; set; }
    }
    
}
