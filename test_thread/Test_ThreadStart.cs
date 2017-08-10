using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace test_thread
{
    public class Test_ThreadStart
    {
        public void Demo1()
        {
            var thc = new ThreadClass();
            thc.ThreadStartTest1(thc.A, 10);
            thc.ThreadStartTest1(thc.B, 10);
        }
        public void ThInfo()
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.WriteLine("获取线程的信息!");
            var th = Thread.CurrentThread;
            Console.WriteLine($"ID:{th.ManagedThreadId}");
            Console.WriteLine($"NAME:{th.Name}");
            Console.WriteLine($"IsAlive:{th.IsAlive}");
            Console.WriteLine($"IsBackground:{th.IsBackground}");
            Console.WriteLine($"ThreadState:{th.ThreadState}");
        }
        public void ParameTh()
        {
            var thc = new ThreadClass();
            var user = new User { Name = "tom", Age = 18 };
            thc.Test2(thc.ParameC,user , 10);
        }
    }
}
