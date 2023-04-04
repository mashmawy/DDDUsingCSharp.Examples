using OrderExample.Domain;
using Microsoft.EntityFrameworkCore;
namespace OrderExample.Infrastructure
{
    public class OrderDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(local);database=OrderDB;Trusted_Connection=True;TrustServerCertificate=True;");


        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
        }
    }
}