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
            using (var db=new FristContext())
            {
                var entity = db.Users.FirstOrDefault();
                entity.Name = "老猫";
                db.SaveChanges();
            }
        }
        /// <summary>
        /// 非跟踪查询
        /// </summary>
        public static void NoTrackingSelect()
        {
            using (var db=new FristContext())
            {
                var entity = db.Users.AsNoTracking().ToList();
            }
        }
        /// <summary>
        /// 非跟踪查询,上下文级别
        /// </summary>
        public static void NoTrackingSelect2()
        {
            using (var db = new FristContext())
            {
                db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                var entity = db.Users.ToList();
            }
        }

    }
}
