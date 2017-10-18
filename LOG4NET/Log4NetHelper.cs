using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace LOG4NET
{

    public class LOG4NET
    {
        public static readonly ILog loginfo = LogManager.GetLogger("loginfo");
        public static readonly ILog logerror = LogManager.GetLogger("logerror");
        public static Regex htmlTagReg = new Regex(@"<\w+>|</\w+>", RegexOptions.IgnoreCase);

        public static void SetConfig()
        {
            //log4net.Config.DOMConfigurator.Configure();
            XmlConfigurator.Configure();
        }
        public static void SetConfig(FileInfo configFile)
        {
            //log4net.Config.DOMConfigurator.Configure(configFile);
            XmlConfigurator.Configure(configFile);
        }

        public static void Log(string info)
        {
            //if (!loginfo.IsInfoEnabled) return;
            //if (HttpContext.Current != null)
            //{
            //    string url = HttpContext.Current.Request.Url.ToString();
            //    loginfo.Info("访问地址：" + (htmlTagReg.Match(url).Success ? HttpUtility.HtmlEncode(url) : url)
            //                 + "<br />\r\nIP 地  址："
            //                 + HttpContext.Current.Request.UserHostAddress
            //                 + "<br />\r\n日志内容：<span style=\"color:green\">"
            //                 + info + "</span>");
            //}
            //else
            loginfo.Info("访问地址：系统<br />\r\nIP 地  址：N/A <br />\r\n日志内容：<span style=\"color:green\">" + info + "</span>");
        }



        public static void Logmsg(string info)
        {
            if (!loginfo.IsInfoEnabled) return;
            loginfo.Info("日志内容：<span style=\"color:green\">" + info + "</span>");
        }


        private static string AppendLog(NameValueCollection nameValueCollection)
        {
            var stringBuilder = new StringBuilder();
            foreach (var o in nameValueCollection)
            {
                stringBuilder.AppendLine(o.ToString());
                stringBuilder.AppendLine("<br />");
            }
            return stringBuilder.ToString();
        }

        public static void Error(string error, Exception exception)
        {
            //if (logerror.IsErrorEnabled)
            //    if (HttpContext.Current != null)
            //    {
            //        string url = HttpContext.Current.Request.Url.ToString();
            //        logerror.Error("访问地址：" + (htmlTagReg.Match(url).Success ? HttpUtility.HtmlEncode(url) : url) + "<br />\r\nIP 地  址：" + HttpContext.Current.Request.UserHostAddress + "<br />\r\n错误内容：<span style=\"color:red\">" + error + "</span>", exception);
            //    }
            //    else
            logerror.Error("访问地址：系统<br />\r\nIP 地  址：N/A <br />\r\n错误内容：<span style=\"color:red\">" + error + "</span>", exception);
        }
    }
}
