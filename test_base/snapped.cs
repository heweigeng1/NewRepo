using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_base
{
    public class snapped : Active
    {

        public snapped():base(1)
        {
            Console.WriteLine(base.name + "子类构造函数");
        }

        public void testsnappend()
        {
            Console.WriteLine(this.name);
            base.name = "父类的属性";
            Console.WriteLine("在这里修改name的值");
            base.testActive();
            this.testActive();
        }
        public override void testActive()
        {
            Console.WriteLine(name + "子类");
        }
    }
}