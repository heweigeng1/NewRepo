using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GdpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (GdpStatisticEntities db=new GdpStatisticEntities())
            {
                var data = db.Areas.OrderBy(c => c.Name).ThenBy(c => c.AreaCode).ThenBy(c=>c.CreatedTime).ToList();
                foreach (var d in data)
                {
                    Console.WriteLine($"{d.Name}-{d.AreaCode}-{d.CreatedTime}");
                }
                Console.ReadKey();
            }
        }
    }
}
