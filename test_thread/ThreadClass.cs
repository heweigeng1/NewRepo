
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace test_thread
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class ThreadClass
    {
        public void A()
        {
            Console.Write("A");
        }
        public void B()
        {
            Console.Write("B");
        }
        public void C(object state)
        {
            Console.Write("C");
        }
        public void D(string msg)
        {
            Console.Write(msg);
        }
        public string E(string str)
        {
            return str+" ";
        }
        public int F(int start,int end)
        {
            int sum = default(int);
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }
        public void For1000(string msg,int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(msg);
            }
        }
        public void ParameC(User user)
        {
            Console.WriteLine(user.Name+$":{user.Age++}");
        }
        public void ThreadStartTest1(Action action, int thCount)
        {
            for (int i = 0; i < thCount; i++)
            {
                Thread th = new Thread(new ThreadStart(action));
                th.Start();
            }
        }
        public void Test2(Action<User> action,User user, int thCount)
        {
            for (int i = 0; i < thCount; i++)
            {
                var th=new Thread(new ParameterizedThreadStart(obj => action(user)));
                th.Start(user);
            }
        }
        public void ThreadPoolTest(int count)
        {
            for (int i = 0; i < count; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(C));
            }
        }
    }
}
