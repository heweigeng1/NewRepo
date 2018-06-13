using EFCore.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddUser();
            //AddUserLog();
            //AddLog();
            强制转换();
            //var user = ThenIncludeSelect();
            //Console.WriteLine(JsonConvert.SerializeObject(user));
            Console.ReadKey();
        }

        private static void AddLog()
        {
            using (var db=new FristContext())
            {
                var userlog = db.AllLogs.FirstOrDefault();
                db.Logs.Add(new Log
                {
                    Id = Guid.NewGuid(),
                    Message = "我是日志",
                    UserLogId = userlog.Id,
                });
                db.SaveChanges();
            }
        }
        private static AllLog 强制转换()
        {
            using (var db = new FristContext())
            {
                var data = db.AllLogs
                         .Include(allLogs => (allLogs as UserLog).Logs)
                         .FirstOrDefault();
                return data;
            }
        }
        private static User SelectUser()
        {
            using (var db = new FristContext())
            {
                return db.Users.Include(user => user.UserLog).FirstOrDefault();
            }
        }
        private static User ThenIncludeSelect() {
            using (var db=new FristContext())
            {
              var data=  db.Users
                    .Include(user => user.UserLog)
                        .ThenInclude(userlog => userlog.Logs).FirstOrDefault();
                return data;
            }
        }

        private static void AddUserLog()
        {
            using (var db = new FristContext())
            {
                var user = db.Users.FirstOrDefault();
                db.AllLogs.Add(new UserLog
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
                    Name = "用户",
                    Pason=new Pason(),
                });
                return db.SaveChanges() > 0;
            }
        }
    }
}
