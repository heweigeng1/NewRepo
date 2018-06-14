using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EFCore.Entites;

namespace EFCore
{
    public static class 显式加载
    {
        public static User Load1()
        {
            using (var db = new FristContext())
            {
                var entity = db.Users.First();//获取第一个用户
                db.Entry(entity).Collection(c => c.UserLog)//加载集合
                    .Load();
                return entity;
            }
        }
        public static UserLog Load2()
        {
            using (var db = new FristContext())
            {
                var entity = db.UserLogs.First();
                db.Entry(entity).Reference(c => c.User)//加载单个
                     .Load();//这个是没有返回值的,是加载了导航属性与实体
                return entity;
            }
        }
        public static UserLog Load3()
        {
            using (var db = new FristContext())
            {
                var entity = db.UserLogs.First();
                db.Entry(entity).Reference(c => c.User)//加载单个
                    .Query()//这里返回的是IQueryable<User> 
                    .First();//这里是User
                return entity;
            }
        }
        public static UserLog Load4()
        {
            using (var db=new FristContext())
            {
                var entity = db.UserLogs.First();
                db.Entry(entity).Reference(c => c.User)
                    .Query()
                    .Where(c=>c.Name=="Admin")//可以根据条件筛选
                    .First();
                return entity;
            }
        }
    }
}
