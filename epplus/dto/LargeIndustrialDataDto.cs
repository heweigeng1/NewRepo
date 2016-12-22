using AutoMapper;
using epplus.data;
using epplus.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epplus.dto
{
    public class LargeIndustrialDataDto
    {
        /// <summary>
        /// 行政区域代码
        /// </summary>
        public string AreaCode { get; set; }
        /// <summary>
        /// 当期金额(千元)
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 法人代码
        /// </summary>
        public string LegalPersonCode { get; set; }
        /// <summary>
        /// 行业代码
        /// </summary>
        public string IndustryCode { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        public string EnterpriseName { get; set; }
    }
}
namespace MvcSolution
{
    public static class LargeIndustrialDataDtoExtAdmin
    {
        public static List<LargeIndustrialDataDto> ToDtos()
        {
            List<LargeIndustrialDataDto> list = new List<LargeIndustrialDataDto>();
            using (var db = new GdpStatisticEntities())
            {
                var query = from q in db.LargeIndustrialDatas select q;
                foreach (var d in query)
                {
                    list.Add(Mapper.Map<LargeIndustrialDataDto>(d));
                }
            }
            return list;
        }
    }
}