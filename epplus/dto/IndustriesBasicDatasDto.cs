using AutoMapper;
using epplus.data;
using epplus.dto;
using System;
using System.Collections.Generic;

namespace epplus.dto
{
    public class IndustriesBasicDatasDto
    {
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
        public Guid AreaId { get; set; }
    }
}

namespace epplus
{
    public static class bulidDto
    {
        public static List<IndustriesBasicDatasDto> getdto(this List<IndustriesBasicDatas> query)
        {
            List<IndustriesBasicDatasDto> list = new List<IndustriesBasicDatasDto>();
            foreach (var d in query)
            {
                list.Add(Mapper.Map<IndustriesBasicDatasDto>(d));
            }
            return list;
        }
    }
}