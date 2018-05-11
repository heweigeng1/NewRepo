using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace operatorDemo
{
    class Program
    {
        public class Tbb
        {
            public int id { get; set; }
            public string name { get; set; }
            static void Main(string[] args)
            {
                int? num1, num2;
                num2 = null;
                List<int?> list = new List<int?>();
                var obj = new List<Tbb> { new Tbb { id = 0, name = "aaa" } };
                var tbb = obj.FirstOrDefault(c => c.id > 0);
                num1 = tbb == null ? default(int?) : tbb.id;
                Console.WriteLine(num1);
                Console.ReadLine();

            }
        }
    }
}
