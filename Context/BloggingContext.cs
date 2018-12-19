using EntityCore2_MigrationsTest.Domains;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EntityCore2_MigrationsTest
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=blogging.db");
        }
    }
    
}
    
