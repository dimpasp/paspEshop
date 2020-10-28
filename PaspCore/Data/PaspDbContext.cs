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
            connectionString_ = "Server=192.168.1.2;Database=PaspalasDb;User=paspjr;Password=12345!@#";

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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString_);
        }
    }
}

