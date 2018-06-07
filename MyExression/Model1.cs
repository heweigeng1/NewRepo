namespace MyExression
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<ApplicateRecords> ApplicateRecords { get; set; }
        public virtual DbSet<Areas> Areas { get; set; }
        public virtual DbSet<ArticleComments> ArticleComments { get; set; }
        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<Attaches> Attaches { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Collects> Collects { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Commodities> Commodities { get; set; }
        public virtual DbSet<CourseAttachRLs> CourseAttachRLs { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Dictionaries> Dictionaries { get; set; }
        public virtual DbSet<Distributors> Distributors { get; set; }
        public virtual DbSet<FeedBacks> FeedBacks { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<Koriyasus> Koriyasus { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<OrderNewDetails> OrderNewDetails { get; set; }
        public virtual DbSet<OrderNews> OrderNews { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PersonLabelChilds> PersonLabelChilds { get; set; }
        public virtual DbSet<PersonLabels> PersonLabels { get; set; }
        public virtual DbSet<Prices> Prices { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<SystemInfoes> SystemInfoes { get; set; }
        public virtual DbSet<UserDistributorRLs> UserDistributorRLs { get; set; }
        public virtual DbSet<UserRoleRLs> UserRoleRLs { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articles>()
                .HasMany(e => e.ArticleComments)
                .WithRequired(e => e.Articles)
                .HasForeignKey(e => e.ArticleId);

            modelBuilder.Entity<Articles>()
                .HasMany(e => e.Collects)
                .WithRequired(e => e.Articles)
                .HasForeignKey(e => e.ArticleId);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Commodities)
                .WithOptional(e => e.Categories)
                .HasForeignKey(e => e.CategoryId);

            modelBuilder.Entity<Commodities>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Commodities)
                .HasForeignKey(e => e.CommodityId);

            modelBuilder.Entity<Courses>()
                .HasMany(e => e.Comments)
                .WithOptional(e => e.Courses)
                .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<Dictionaries>()
                .HasMany(e => e.Dictionaries1)
                .WithOptional(e => e.Dictionaries2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<Distributors>()
                .HasMany(e => e.Areas)
                .WithOptional(e => e.Distributors)
                .HasForeignKey(e => e.Distributor_Id);

            modelBuilder.Entity<Distributors>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Distributors)
                .HasForeignKey(e => e.DistributorId);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Orders)
                .HasForeignKey(e => e.OrderId);

            modelBuilder.Entity<Projects>()
                .HasMany(e => e.Courses)
                .WithOptional(e => e.Projects)
                .HasForeignKey(e => e.ProjectId);

            modelBuilder.Entity<Projects>()
                .HasMany(e => e.Koriyasus)
                .WithOptional(e => e.Projects)
                .HasForeignKey(e => e.ProjectId);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.UserRoleRLs)
                .WithRequired(e => e.Roles)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.ArticleComments)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Collects)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Comments)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Images)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.BuyUser_Id);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.PersonLabels)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Projects)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.ForemanUserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Projects1)
                .WithOptional(e => e.Users1)
                .HasForeignKey(e => e.OwnerUserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.UserDistributorRLs)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.UserRoleRLs)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}
