using System;

namespace 里式替换原则
{
    class Program
    {
        static void Main(string[] args)
        {
            new B(new A()).Test();
            Console.ReadKey();
        }
    }
    public class F
    {
        public virtual  void Console()
        {
            System.Console.WriteLine("F");
        }
    }
    public class A : F
    {
        public override void Console()
        {
            System.Console.WriteLine("A");
        }
    }
    public class B : F
    {
        F _f;
        public B(F f)
        {
            _f = f;
        }
        public void Test()
        {
            _f.Console();
        }
    }
}
