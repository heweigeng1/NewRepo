using epplus.data;
using epplus.dto;
using epplus.load;
using MvcSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epplus
{
    public class Program
    {
        public static void Main(string[] args)
        {
            mapper.MapperConfigure.Instance.Init();
            LoadData load = new LoadData();
            var data = load.LoadDataToExcel();
            var newmodel = LargeIndustrialDataDtoExtAdmin.ToDtos();
            string titel = "区域代码,当期累计产值(千元),法人代码,行业代码,单位名称";
            save.EpplusSaveHelper.SaveToExcel(newmodel, @"C:\Users\hewei\Desktop\新建文件夹\LargeIndustrialData.xlsx", titel.Split(','));
            Console.WriteLine("is ok!");
            //var loaddata = EpplusLoadHelper.LoadFromExcel<areaDto>(@"C:\Users\hewei\Desktop\新建文件夹\bbs.xlsx");
            //foreach (var d in loaddata)
            //{
            //    Console.WriteLine($@"{d.id}-{d.Name}-{d.Code}");
            //}
            Console.ReadKey();

        }

    }
}
