using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PaspCore.Model;

namespace PaspCore.Data
{

    public class PaspDbContext : IdentityDbContext
    {
        private readonly string connectionString_;

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public PaspDbContext() : base()
        {
            connectionString_ = "Server=localhost;Database=PaspalasDb;User=paspjr;Password=ADHE1!@23#";

        }
        public PaspDbContext(string connString)
        {
            connectionString_ = connString;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product{ });
            modelBuilder.Entity<Category>().HasData(new Category{ });
            modelBuilder.Entity<Account>(e =>
                e.HasNoKey());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString_);
        }
    }
}

