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
        public DbSet<Customer> Customers { get; set; }       
        public PaspDbContext() : base()
        {
            connectionString_ = "Data Source=(localdb)\\MSSQLLocalDB;Database=PaspalasDb;User=sa;Password=ADHE1!@23#";

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().Property(m => m.ProductId).IsRequired();
            modelBuilder.Entity<Category>().Property(m => m.CategoryId).IsRequired();
            //hasdata to ckeck out
            modelBuilder.Entity<Account>(e =>
                e.HasNoKey());
            modelBuilder.Entity<Order>().OwnsOne(x=>x.Products);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString_);
        }
    }
}

