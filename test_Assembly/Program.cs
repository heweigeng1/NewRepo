using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = AssemblyUtils.ObjToSortedDictionary(new WxUnifiedOrderModel
            {
                appid = "asdfsf",
                attach = "测试",
                body = "boooooody",
                mch_id = "1",
                nonce_str = "2",
                notify_url = "3",
                out_trade_no = "4",
                sign = "5",
                spbill_create_ip = "6",
                total_fee = 0,
                trade_type = "7",
            });
            data.Remove("sign");
            string str = data.SortedDictionaryToString();
            string xml = data.SortedDictionaryToXml();
            Console.WriteLine(str);
            string signxml = xml.Replace("</xml>", $@"<sign>{123123}</sign></xml>");
            Console.WriteLine(signxml);
            Console.ReadKey();
        }
    }
}
