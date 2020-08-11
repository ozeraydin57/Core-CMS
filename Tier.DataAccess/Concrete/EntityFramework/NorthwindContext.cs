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
            optionsBuilder.UseSqlServer(@"server=.;database=HEDIYE;trusted_connection=true;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Category { get; set; }

        public DbSet<Menu> Menu { get; set; }
        public DbSet<Param> Param { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<PostDetail> PostDetail { get; set; }
        public DbSet<PostCategory> PostCategory { get; set; }
        public DbSet<PostComment> PostComment { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Contact> Contact { get; set; }
    }
}
