using System.Data.Entity;
using System.Data;
using test_CodeFrist.Model;

namespace test_CodeFrist
{
    public class testContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Test_OneToOne> Test_OneToOnes { get; set; }
        //重写绑定
        public testContext():base("name=GdpDbContext")
        {
            
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<testContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DestinationConfiguration());
            modelBuilder.Configurations.Add(new LodgingConfiguration());
            modelBuilder.Configurations.Add(new TripConfiguration());
            modelBuilder.Configurations.Add(new Test_OneToOneConfiguration());
        }
    }
}
