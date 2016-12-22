using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_CodeFrist.Model
{
 public   class Test_OneToOne
    {
        public Guid Identity { get; set; }
        public string Name { get; set; }
        public Trip Trip { get; set; }
       
    }
    public class Test_OneToOneConfiguration : EntityTypeConfiguration<Test_OneToOne>
    {
        public Test_OneToOneConfiguration()
        {
            HasKey(c => c.Identity);//定义主键
            HasRequired(p => p.Trip).WithOptional(p => p.one);
        }
    }
}
