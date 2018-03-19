using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //普通类
            var nsc = new NosingletonClass();
            var nsc1 = new NosingletonClass();
            Console.WriteLine(nsc.Equals(nsc1));

            //c# 单例1 
            var sc1 = SingletonClass.Instance;
            var sc2 = SingletonClass.Instance;
            Console.WriteLine(sc1.Equals(sc2));

           
            int num = 0;
            for (int i = 0; i < 100; i++)
            {
                var sc3 = SingletonClass.Instance;
                if (sc1 != sc3)
                {
                    num++;
                }
            }
            Console.WriteLine(num);
            
            for (int i = 0; i < 1000; i++)
            {
                Thread th = new Thread(new ThreadStart(() =>
                {
                    var sc3 = SingletonClass.Instance;
                    if (sc1!=sc3)
                    {
                        num++;
                    }
                }));
                th.Start();
            }
            Console.WriteLine(num);

            //var nolook = NoLookSingletonClass.Instance();
            //var nolook1 = NoLookSingletonClass.Instance();
            //Console.WriteLine(nolook.Equals(nolook1));
            //for (int i = 0; i < 100; i++)
            //{
            //    var nolook2 = NoLookSingletonClass.Instance();
            //    if (nolook != nolook2)
            //    {
            //        num++;
            //    }
            //}
            //Console.WriteLine(num);
            //for (int i = 0; i < 10000; i++)
            //{
            //    Thread th1 = new Thread(new ThreadStart(() =>
            //    {
            //        if (NoLookSingletonClass.Instance()!= NoLookSingletonClass.Instance())
            //        {
            //            num++;
            //        }
            //    }));
            //    th1.Start();
            //    NoLookSingletonClass.Destroy();
            //}
            //Console.WriteLine(num);
            for (int i = 0; i < 10000; i++)
            {
                Thread th = new Thread(new ThreadStart(() =>
                {
                    if (LookSingletonClass.Instance()!=LookSingletonClass.Instance())
                    {
                        num++;
                    }
                }));
                th.Start();
                LookSingletonClass.Destroy();
            }
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
