using System;

namespace 状态模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Chlid().test1();
            Console.ReadKey();
        }
    }

    public class Base1
    {
        protected string u1 { get; set; }
        public void test1()
        {
            Console.WriteLine(u1);
        }
    }
    public class Chlid : Base1
    {
        public Chlid()
        {
            base.u1 = "base1";
        }
    }
}
