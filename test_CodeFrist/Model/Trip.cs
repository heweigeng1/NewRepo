using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
namespace test_CodeFrist.Model
{
    public class Trip
    {
        public Guid Identity { get; set; }
        public DateTime StrDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal CostUSD { get; set; }
        public Test_OneToOne one { get; set;}
    }
    public class TripConfiguration : EntityTypeConfiguration<Trip>
    {
        public TripConfiguration()
        {
            HasKey(c => c.Identity);//定义主键
            Property(c => c.Identity).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//默认GUID
        }
    }
}
