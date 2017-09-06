using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace test_thread
{
    public class TaskDemo
    {
        public ThreadClass tsclass = new ThreadClass();
        public TaskClass TaskTest = new TaskClass();
        public void Demo()
        {
            TaskTest.Test2(tsclass.B, 10);
        }
        public void Demo1()
        {
            TaskTest.Test(tsclass.A, 10);
            Console.ReadKey();
        }
        public void Demo2(string msg)
        {
            TaskTest.Test3(tsclass.D, msg);
        }
        public void TestWait(string msg, int count)
        {
            TaskTest.Wait(tsclass.For1000, msg, count);
        }
        public void NoWait(string msg, int count)
        {
            TaskTest.NoWait(tsclass.For1000, msg, count);
        }
        public void WaitAll(string msg, int count)
        {
            TaskTest.WaitAll(tsclass.D, msg, count);
        }
        public Task WhenAll(string msg, int count)
        {
            return TaskTest.WhenAll(tsclass.D, msg, count);
        }
        public string Result(string str)
        {
            return TaskTest.Result(() => tsclass.E(str));
        }
        public async Task<int> GetSumAsync(int start,int end)
        {
            return await TaskTest.GetSumAsync(() => tsclass.F(start, end));
        }
    }
}
