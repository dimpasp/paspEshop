using Microsoft.EntityFrameworkCore;
using PaspCore.Model;
using System.Data;

namespace PaspCore.Data
{

    public class PaspDbContext : DbContext
    {
        private readonly string connectionString_;

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public PaspDbContext() : base()
        {
            connectionString_ = "Server=localhost;Database=CrowdFun;User Id=sa;Password=QWE123!@#";
        }
        public PaspDbContext(string connString)
        {
            connectionString_ = connString;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Price = 123
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 1
            });
        }
    }
}

