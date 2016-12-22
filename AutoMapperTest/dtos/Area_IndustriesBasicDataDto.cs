using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTest.dtos
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
