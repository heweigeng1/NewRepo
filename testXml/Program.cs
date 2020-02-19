using dayou.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace testXml
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml = "<xml><return_code><![CDATA[SUCCESS]]></return_code><return_msg><![CDATA[每个红包的平均金额必须在1.00元到200.00元之间.]]></return_msg><result_code><![CDATA[FAIL]]></result_code><err_code><![CDATA[MONEY_LIMIT]]></err_code><err_code_des><![CDATA[每个红包的平均金额必须在1.00元到200.00元之间.]]></err_code_des><mch_billno><![CDATA[201608229342349493]]></mch_billno><mch_id><![CDATA[1303422501]]></mch_id><wxappid><![CDATA[wxac221cf8e9e01bb0]]></wxappid><re_openid><![CDATA[oGjxztzvxFceFZj-AfW5k0gxyaG0]]></re_openid><total_amount>1</total_amount></xml>";
            //xml = xml.Replace("<xml>", "<?xml version='1.0'?><ResultXmlModel> ");
            //xml = xml.Replace("</xml>", "</ResultXmlModel>");
            //var v=   XmlToObject.Deserialize(typeof(ResultXmlModel), xml) as ResultXmlModel;
            //var v = XmlToObject.Serializer(typeof(ResultXmlModel), new ResultXmlModel { return_code = "123" });
            ResultXmlModel b = XmlToObject.Deserialize(typeof(ResultXmlModel), xml) as ResultXmlModel;
            //if (b != null)
            //{
            //    Console.WriteLine(b.return_code);
            //}
            //else
            //{
            //    Console.WriteLine("error");
            //}
            new XDocumentDemo().Test1(xml, "return_msg");
            Console.ReadKey();
        }
    }
}
