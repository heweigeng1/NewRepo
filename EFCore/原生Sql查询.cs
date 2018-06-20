using EFCore.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCore
{
    public static class 原生Sql查询
    {
        public static List<User> Select1()
        {
            using (var db = new FristContext())
            {
                return db.Users.FromSql("select * from Users").ToList();
            }
        }
        /// <summary>
        /// 参数查询
        /// </summary>
        /// <returns></returns>
        public static List<User> Select2()
        {
            using (var db = new FristContext())
            {
                string userName = "老猫A";
                return db.Users.FromSql($"select * from Users where Name={userName}").ToList();
            }
        }
        public static List<User> Select3()
        {
            using (var db = new FristContext())
            {
                string userName = "{' or 1=1 --}";
                return db.Users.FromSql($"select * from Users where Name={userName}").ToList();
            }
        }
    }
}
