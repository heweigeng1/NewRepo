using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOG4NET
{
    class Program
    {

        public static void Main(string[] args)
        {
            Testlog();
            Console.WriteLine("日志记录完毕。");
            Console.Read();
        }
        public static void Testlog()
        {
            var log = LogManager.GetLogger("FileLogger");
            try
            {
                throw new Exception("istest");
            }
            catch (Exception ex)
            {
                log.Info(ex.ToString());
                log.Error("test", ex);
            }
        }
    }
    
}
