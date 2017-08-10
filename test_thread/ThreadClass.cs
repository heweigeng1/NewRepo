
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
    }
}
