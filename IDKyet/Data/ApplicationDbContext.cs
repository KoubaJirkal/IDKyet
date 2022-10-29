
using ASPCoreFormSelectDemo.Models;
using EfcDbInit.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace EfcDbInit.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Champions> Champions { get; set; }
        public DbSet<Summs> Summs { get; set; }
        public DbSet<Role> Roles { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Role>().HasData(new Role {RoleID = 1, RoleName = "Top"});
            builder.Entity<Champions>().HasData(new Champions { ChampionsId = 1, Name = "Aatrox", RoleID = 1});
            builder.Entity<Summs>().HasData(new Summs { Id = 1, Name = "KarelFrederick", Password = "Karlík1234", Server = EnumServers.EUNE });

                
        }
    }
}