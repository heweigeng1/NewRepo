using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testEf.Data;
using testEf.Extention;

namespace testEf
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db=new SmartTownEntities())
            {
                var data = db.UserInfo.ToList();
            }
            var str = DateTime.Now;
            for (int i = 0; i < 5000; i++)
            {
                Lambda();
            }
            var end = DateTime.Now;
            Console.WriteLine($"{end - str}");
            //var str2 = DateTime.Now;
            //for (int i = 0; i < 5000; i++)
            //{
            //    ExLambda();
            //}
            //var end2 = DateTime.Now;
            //Console.WriteLine($"{end2 - str2}");
            Console.ReadKey();
        }
        public static List<UserInfo> Lambda()
        {
            using (var db = new SmartTownEntities())
            {
                var data = db.UserInfo.Where(c => c.Email.Contains("a"));
                if (true)
                {
                    data = data.Where(c => c.CreateTime < DateTime.Now);
                }
                if (true)
                {
                    data = data.Where(c => c.Telephone.Contains("1"));
                }
                if (true)
                {
                    data = data.Where(c => c.Name.Contains("a"));
                }
                return data.ToList();
            }
        }
        public static List<UserInfo> ExLambda() {
            using (var db = new SmartTownEntities())
            {
                var oLamadaExtention = new LamadaExtention<UserInfo>();
                oLamadaExtention.GetExpression("Email", "a", ExpressionType.Equal);
                //var data = db.UserInfo.Where(c => c.Email.Contains("a"));
                if (true)
                {
                    // data = data.Where(c => c.CreateTime < DateTime.Now);
                    oLamadaExtention.GetExpression("CreateTime", DateTime.Now, ExpressionType.LessThan);
                }
                if (true)
                {
                    oLamadaExtention.GetExpression("Telephone", "1", ExpressionType.Contains);
                }
                if (true)
                {
                    oLamadaExtention.GetExpression("Name", "a", ExpressionType.Contains);
                }
                var lambda= oLamadaExtention.GetLambda();
                var data = db.UserInfo.AsQueryable().Where(lambda);
                return data.ToList();
            }
        }
    }
}
