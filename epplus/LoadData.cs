using epplus.data;
using System.Collections.Generic;
using System.Linq;

namespace epplus
{
    public class LoadData
    {
        public List<Areas>  LoadDataToExcel()
        {
            using (var  entity=new GdpStatisticEntities())
            {
                return entity.Areas.ToList();
            }
        }
    }
}
