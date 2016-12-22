using System.Data.Entity.ModelConfiguration;
namespace test_CodeFrist.Model
{
    public class Lodging
    {
        public int LodgingId { get; set; }

        public string Name { get; set; }

        public string Owner { get; set; }

        public bool IsResort { get; set; }

        public Destination Destination { get; set; }
    }
    public class LodgingConfiguration : EntityTypeConfiguration<Lodging>
    {
        public LodgingConfiguration()
        {
            Property(c => c.Name).IsRequired();
        }
    }
}
