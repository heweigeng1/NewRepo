using EFCore.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace EFCore
{
    public class FristContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserLog> UserLogs { get; set; }
        //FristContext(DbContextOptions<FristContext> options) : base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=TestEFCore;user id=sa;password=asdf.123;Trusted_Connection=True;");
        }
    }
}
