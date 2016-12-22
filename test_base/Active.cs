using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_base
{
    public class Active
    {
        decimal value { get; set; }
        public string name { get; set; }
        public Active()
        {
            name = "active构造函数赋值";
            Console.WriteLine("父类构造函数");
            Console.WriteLine(name+"active");
        }
        public Active(int id)
        {
            name = "带参数的构造函数";
            Console.WriteLine(name);
        }
        public virtual void testActive()
        {
            Console.WriteLine(name+"父类");
        }
    }
}
