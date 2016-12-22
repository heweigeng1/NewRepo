using AutoMapper;
using epplus.data;
using epplus.dto;

namespace epplus.mapper
{
    public class MapperConfigure
    {
        public static MapperConfigure Instance { get; }
        static MapperConfigure()
        {
            Instance = new MapperConfigure();
        }
        public void Init()
        {
            Mapper.Initialize(cm =>
            {
                cm.CreateMap<IndustriesBasicDatas, IndustriesBasicDatasDto>();

                cm.CreateMap<LargeIndustrialDatas, LargeIndustrialDataDto>();
            });
        }
    }
}
