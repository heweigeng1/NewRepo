using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_CodeFrist.Model;

namespace test_CodeFrist
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<testContext>());//如果有冲突了则删除重建
            InsertDestination();
        }
        private static void InsertDestination()
        {
            var destination = new Destination
            {
                Country = "Indonesia",
                Description = "EcoTourism at its best in exquisite Bali",
                Name = "Bali"
            };
            Trip tp = new Trip { StrDate = DateTime.Now, EndDate = DateTime.Now, CostUSD = 9 };
            using (var context = new testContext())
            {
                context.Destinations.Add(destination);
                context.Trips.Add(tp);
                context.SaveChanges();
            }
        }
    }
}
