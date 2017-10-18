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
        static void Main(string[] args)
        {
            //testlog();
            LOG4NET.Log("aaaaa");
            Console.ReadLine();
        }
        public static void testlog()
        {
            try
            {
                throw new Exception("istest");
            }
            catch (Exception ex)
            {
                LOG4NET.Log(ex.ToString());
               // logger.Error(ex.ToString());
            }
        }
    }
    
}
