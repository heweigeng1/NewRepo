using epplus.data;
using epplus.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epplus.dto
{
    public class Area_IndustriesBasicDataDto
    {
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        /// <summary>
        /// 三经普企业个数
        /// </summary>
        public int? CompanyCount { get; set; }
        /// <summary>
        /// 当期基本单位名录库数量（个）
        /// </summary>
        public int? BasicUnitsDatabase { get; set; }
        /// <summary>
        /// 三经普个体户数
        /// </summary>
        public int? SelfEmployed { get; set; }

    }
}

namespace epplus
{
    public static class Area_IndustriesBasicDataDtoExtAdmin
    {
        public static List<Area_IndustriesBasicDataDto> Bulid_Area_IndustriesBasicDataDto()
        {
            using (var db = new GdpStatisticEntities())
            {
                return (from i in db.IndustriesBasicDatas
                        select new Area_IndustriesBasicDataDto
                        {
                            AreaCode = i.Areas.AreaCode,
                            AreaName = i.Areas.Name,
                            CompanyCount = i.CompanyCount,
                            SelfEmployed = i.SelfEmployed,
                            BasicUnitsDatabase = i.BasicUnitsDatabase
                        }).ToList();
            }
        }
    }
}
