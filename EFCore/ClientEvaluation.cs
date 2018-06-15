using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EFCore.Entites;

namespace EFCore
{
    /// <summary>
    /// 客户端评估
    /// </summary>
    public static class ClientEvaluation
    {
        public static List<User> SelectUser()
        {
            using (var db = new FristContext())
            {
                var data = db.Users.Select(u => new User
                {
                    Name = CheckName(u.Name),
                });
                return data.ToList();
            }
        }
        public static List<User> SelectUser2()
        {
            using (var db = new FristContext())
            {
                var data = db.Users.Where(c => CheckName(c.Name).Contains("用"));
                return data.ToList();
            }
        }
        private static string CheckName(string name)
        {
            return string.Concat("用户:", name);
        }
    }
}
