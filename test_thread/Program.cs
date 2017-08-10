using System;
using System.Threading;

namespace test_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Test_ThreadStart();
            test.ParameTh();
            //test.Demo1();
            //test.ThInfo();
            Console.ReadKey();
        }
    }
}