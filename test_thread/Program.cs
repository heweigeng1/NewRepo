using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            var tsclass = new ThreadClass();
            //var test = new Test_ThreadStart();
            //test.ThreadPool1();
            //test.ParameTh();
            //test.Demo1();
            //test.ThInfo();
            //new TaskDemo().Demo1();
            //new TaskDemo().Demo2("test");

            //new TaskDemo().TestWait("a", 1000);
            //Console.WriteLine("over1");
            //new TaskDemo().TestWait("b", 1000);
            //Console.WriteLine("over2");
            //new TaskDemo().NoWait("c", 1000);
            //Console.WriteLine("over3");
            //new TaskDemo().NoWait("d", 1000);

            //new TaskDemo().WaitAll("a", 100);
            //Console.WriteLine("[end]");
            //new TaskDemo().WaitAll("b", 100);
            //Console.WriteLine("[over]");
            //Task[] tasks = new Task[2];
            //tasks[0] = new TaskDemo().WhenAll("a", 100);
            //Console.WriteLine("[1]");
            //tasks[1] = new TaskDemo().WhenAll("b", 100);
            //Console.WriteLine("[2]");
            //Task.WaitAll(tasks);
            //Console.WriteLine("over");
            //Task task = new TaskDemo().WhenAll("are u ok?", 100);
            //Task.WaitAny(task);
            //Console.WriteLine(task.IsCompleted);
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("完成");

            //for (int i = 0; i < 100; i++)
            //{
            //    string str1 = "";
            //    string str2 = "";
            //    str1 = new TaskDemo().Result("hello");
            //    str2 = new TaskDemo().Result("world");
            //    Console.WriteLine(str1 + str2);
            //}

           var sum= new TaskDemo().GetSumAsync(10, 100);
            Console.WriteLine(5);
            Console.WriteLine(sum.Result);
            Console.ReadKey();
        }
    }
}