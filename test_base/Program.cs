using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_base
{
    class Program
    {
        static void Main(string[] args)
        {
            snapped sp = new snapped();
            sp.testsnappend();
            Console.WriteLine("=======================");
            sp.testActive();
            Console.ReadKey();
        }
    }
}
