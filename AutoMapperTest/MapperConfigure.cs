using AutoMapper;
using AutoMapperTest.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapperTest.Db;

namespace AutoMapperTest
{
    class MapperConfigure
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
                cm.CreateMap<Areas, AreaDto>();
                cm.CreateMap<AreaDto, Areas>();
                cm.CreateMap<CropDto, Crops>().ForMember(c => c.Id, opt => opt.Ignore()).ForMember(c => c.Id, opt => opt.MapFrom(src=>src.CropId));
                cm.CreateMap<Crops, CropDto>().ForMember(c => c.CropId, opt => opt.MapFrom(src => src.Id)).ForMember(c=>c.Id,opt=>opt.Ignore());
            });

        }
    }
    
}
