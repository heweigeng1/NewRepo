﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace test_CodeFrist
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GdpStatisticEntities : DbContext
    {
        public GdpStatisticEntities()
            : base("name=GdpStatisticEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<Lodgings> Lodgings { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<T_Destinations> T_Destinations { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<Trips> Trips { get; set; }
        public virtual DbSet<UserRoleRLs> UserRoleRLs { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserTagRLs> UserTagRLs { get; set; }
    }
}
