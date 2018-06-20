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
            //AS转换();
            //var user = ThenIncludeSelect();
            //Console.WriteLine(JsonConvert.SerializeObject(user));
            //var user = 显式加载.Load1();
            //var user2 = 显式加载.Load2();
            //var users = ClientEvaluation.SelectUser2();
            //跟踪与非跟踪查询.Select();


            //DateTime strtime1 = DateTime.Now;
            //for (int i = 0; i < 10000; i++)
            //{
            //    var u0 = 跟踪与非跟踪查询.Update();
            //}
            //DateTime endtime1 = DateTime.Now;
            //Console.WriteLine($"{endtime1}-{strtime1}={endtime1-strtime1}");
            //for (int i = 0; i < 10000; i++)
            //{
            //    var u1 = 跟踪与非跟踪查询.UpdateAsNoTracking();
            //}
            //var endtime2 = DateTime.Now;
            //Console.WriteLine($"{endtime2}-{endtime1}={endtime2 - endtime1}");
            //var u2 = 跟踪与非跟踪查询.NoTrackingSelect2();
            //var u3 = 跟踪与非跟踪查询.Select2();
            //var u4 = 原生Sql查询.Select1();
            //var u5 = 原生Sql查询.Select2();
            var u6 = 原生Sql查询.Select3();//测试SQL注入攻击
            Console.ReadKey();
        }

        private static void AddLog()
        {
            using (var db = new FristContext())
            {
                var userlog = db.UserLogs.FirstOrDefault();
                db.AllLogs.Add(new Log
                {
                    Id = Guid.NewGuid(),
                    Message = "我是日志",
                    UserLogId = userlog.Id,
                });
                db.SaveChanges();
            }
        }
        private static AllLog AS转换()
        {
            using (var db = new FristContext())
            {
                var data = db.AllLogs
                         .Include(allLogs => (allLogs as Log).UserLog)
                         .FirstOrDefault();
                return data;
            }
        }
        private static AllLog 强制转换()
        {
            using (var db = new FristContext())
            {
                var data = db.AllLogs
                         .Include(allLogs => ((Log)allLogs).UserLog)
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
        private static User ThenIncludeSelect()
        {
            using (var db = new FristContext())
            {
                var data = db.Users
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
                    Name = "用户",
                    Pason = new Pason(),
                });
                return db.SaveChanges() > 0;
            }
        }
    }
}
