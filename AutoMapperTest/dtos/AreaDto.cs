using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTest.dtos
{
    public class AreaDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AreaCode { get; set; }
        public string CreatedTime { get; set; }
        public string LastUpdatedTime { get; set; }
        public string Delflag { get; set; }
    }
    public class CropDto
    {
        public Guid Id { get; set; }
        public Guid CropId { get; set; }
        public string CropName { get; set; }
    }
}
