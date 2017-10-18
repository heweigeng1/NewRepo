using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test_thread
{
    public class TaskClass
    {
        public void Test(Action action, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Task.Factory.StartNew(action);
            }
        }
        public void Test2(Action action, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Task task = new Task(action);
                task.Start();
            }
        }
        /// <summary>
        /// 带参数
        /// </summary>
        /// <param name="action"></param>
        /// <param name="msg"></param>
        public void Test3(Action<string> action, string msg)
        {
            Task task = new Task(obj => action(msg), msg);
            task.Start();
        }
        public void Test4()
        {
            Task task = new Task(() =>
            {
                Console.WriteLine("其实这个Task的构造函数参数是一个action");
            });
            task.Start();
        }
        public void Wait(Action<string, int> action, string msg, int count)
        {
            Task task = new Task(() => action(msg, count));
            task.Start();
            task.Wait();
        }
        public void NoWait(Action<string, int> action, string msg, int count)
        {
            Task task = new Task(() => action(msg, count));
            task.Start();
        }
        public void WaitAll(Action<string> action, string msg, int count)
        {
            Task[] tasks = new Task[count];
            for (int i = 0; i < count; i++)
            {
                tasks[i] = Task.Factory.StartNew(() => action(msg));
            }
            Task.WaitAll(tasks);
        }
        public Task WhenAll(Action<string> action, string msg, int count)
        {
            Task[] tasks = new Task[count];
            for (int i = 0; i < count; i++)
            {
                tasks[i] = Task.Factory.StartNew(() => action(msg));
            }
            return Task.WhenAll(tasks);
        }
        public string Result(Func<string> func)
        {
            Task<string> task = new Task<string>(func);
            task.Start();
            return task.Result;
        }
        public async Task<int> GetSumAsync(Func<int> func)
        {
            Console.WriteLine(1);
            int sum = await Task.Run(func);
            Console.WriteLine(3);
            Console.WriteLine(4);
            return sum;
        }
    }
}
