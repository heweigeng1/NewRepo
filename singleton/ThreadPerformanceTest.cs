using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace singleton
{
    public  class ThreadPerformanceTest
    {
        private int _testCount;
        private DateTime strTime;
        private DateTime endTime;
        private int thcount=0;
       
        public void Execute(Action<int> action,Action<string> rollBack,int testCount)
        {
            _testCount = testCount;
            strTime = DateTime.Now;
            List<Thread> list = new List<Thread>();
            for (int i = 0; i < testCount; i++)
            {
                var th = new Thread(new ThreadStart(() =>
                {
                    action(i);
                }));
                th.Start();
                list.Add(th);
            }
            foreach (var item in list)
            {
                while (item.IsAlive)
                {
                    Thread.Sleep(10);
                }
                thcount++;
            }
            rollBack(Writh());
            Console.ReadKey();
        }
        public string Writh()
        {
            endTime = DateTime.Now;
            string msg = $"要求执行次数{_testCount}总共执行次数{thcount},消耗时间{endTime-strTime}";
            Console.WriteLine(msg);
            return msg;
        }
    }
}
