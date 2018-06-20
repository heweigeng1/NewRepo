using EFCore.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCore
{
    public static class 跟踪与非跟踪查询
    {
        /// <summary>
        /// 跟踪
        /// </summary>
        public static void Select()
        {
            using (var db = new FristContext())
            {
                var entity = db.Users.FirstOrDefault();
                entity.Name = "老猫A";
                db.SaveChanges();
            }
        }
        /// <summary>
        /// 跟踪查询2
        /// </summary>
        public static List<User> Select2()
        {
            using (var db = new FristContext())
            {
                return db.Users.ToList();
            }
        }
        /// <summary>
        /// 非跟踪查询
        /// </summary>
        public static List<User> NoTrackingSelect()
        {
            using (var db = new FristContext())
            {
                return db.Users.AsNoTracking().ToList();
            }
        }
        /// <summary>
        /// 非跟踪查询,上下文级别
        /// </summary>
        public static List<User> NoTrackingSelect2()
        {
            using (var db = new FristContext())
            {
                db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                return db.Users.ToList();
            }
        }

        public static User Update()
        {
            using (var db=new FristContext())
            {
               var user= db.Users.FirstOrDefault();
                user.Creatime = DateTime.Now;
                db.SaveChanges();
                return user;
            }
        }
        public static User UpdateAsNoTracking()
        {
            using (var db = new FristContext())
            {
                var user = db.Users.AsNoTracking().FirstOrDefault();
                user.Creatime = DateTime.Now;
                db.SaveChanges();
                return user;
            }
        }

    }
}
