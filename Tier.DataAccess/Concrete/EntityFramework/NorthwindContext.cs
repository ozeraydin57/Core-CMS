using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tier.Entities.Concrete;

namespace Tier.DataAccess.Concrete.EntityFramework
{
    public class OADBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=OAEV\MSSQLSERVER2012;database=Blog;trusted_connection=true;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Menu> Menu { get; set; }
        public DbSet<Param> Param { get; set; }

    }
}
