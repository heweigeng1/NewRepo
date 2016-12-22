using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace test_CodeFrist.Model
{
    public class Destination
    {
        public int DestinationId { get; set; }
        //[Required]
        public string Name { get; set; }

        public string Country { get; set; }
        //[MaxLength(500)]
        public string Description { get; set; }
        //[Column(TypeName ="image")]
        public byte[] Photo { get; set; }

        public List<Lodging> Lodgings { get; set; }
    }
    public class DestinationConfiguration: EntityTypeConfiguration<Destination>
    {
        public DestinationConfiguration()
        {
            ToTable("T_Destinations");
            Property(c => c.Name).IsRequired();
            Property(c => c.Description).HasMaxLength(500);
            Property(c => c.Photo).HasColumnType("image");
        }
    }

}
