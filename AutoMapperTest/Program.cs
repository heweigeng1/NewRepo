using AutoMapper;
using AutoMapperTest.Db;
using AutoMapperTest.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MapperConfigure.Instance.Init();
            //dtoToObj();
            IdToCropId();
        }
        public static void dtoToObj()
        {
            AreaDto dto = new AreaDto
            {
                AreaCode = "1007",
                CreatedTime = DateTime.Now.ToString(),
                Name = "天安门"
            };
            Areas area = Mapper.Map<Areas>(dto);
            Console.WriteLine($"{area.Name}:{area.AreaCode}:{area.CreatedTime}");
            Console.ReadKey();
        }

        public static void IdToCropId()
        {
            CropDto dto = new CropDto
            {
                CropId = Guid.NewGuid(),
                CropName = "我是测试"
            };
            Console.WriteLine("obj=>dto");
            var model = Mapper.Map<Crops>(dto);
            Console.WriteLine($"crops objName{model.CropName}+++obj{model.Id}++");
            var newdto = Mapper.Map<CropDto>(model);
            Console.WriteLine("dto=>obj");
            Console.WriteLine($"dto DtoName={newdto.CropName}    DTOID={newdto.Id}   DTOCropID={newdto.CropId}");
            Console.ReadKey();
        }
    }
}
