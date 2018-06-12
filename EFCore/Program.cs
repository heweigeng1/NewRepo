using EFCore.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Newtonsoft.Json;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            AddUserLog();
            using (var db = new FristContext())
            {
                var data = db.Users.Include(user => user.UserLog).ToList();
                var users = from user in data
                            select new
                            {
                                user.UserLog,
                                user.UserName,
                                user.Creatime,
                            };
                Console.WriteLine(JsonConvert.SerializeObject(users));
            }
            Console.ReadKey();
        }

        private static void AddUserLog()
        {
            using (var db = new FristContext())
            {
                var user = db.Users.FirstOrDefault();
                db.UserLogs.Add(new UserLog
                {
                    Id = Guid.NewGuid(),
                    LogDec = "我的登录",
                    LoginTime = DateTime.Now,
                    UId = user.Id,
                });
                db.SaveChanges();
            }
        }

        private static bool AddUser()
        {
            using (var db = new FristContext())
            {
                db.Users.Add(new User
                {
                    Id = Guid.NewGuid(),
                    Creatime = DateTime.Now,
                    UserName = "用户"
                });
                return db.SaveChanges() > 0;
            }
        }
    }
}
