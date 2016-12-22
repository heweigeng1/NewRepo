using System.Collections.Generic;
using System.Linq;
using epplus.data;

namespace epplus.sqlhelper
{
    public static class SqlHelper<T> where T : class, new()
    {
        public static List<T> getModelList()
        {
            using (var db = new GdpStatisticEntities())
            {
                
                return db.Set<T>().ToList();
            }
        }
        public static IQueryable<T>getEntity()
        {
            using (var db=new GdpStatisticEntities())
            {
                return db.Set<T>().AsQueryable();
            }
        }
    }
}
