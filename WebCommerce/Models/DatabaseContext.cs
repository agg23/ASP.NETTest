using Microsoft.EntityFrameworkCore;

namespace WebCommerce.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().Ignore(m => m.Email)
                   .Ignore(m => m.EmailConfirmed)
                   .Ignore(m => m.AccessFailedCount)
                   .Ignore(m => m.ConcurrencyStamp)
                   .Ignore(m => m.LockoutEnabled)
                   .Ignore(m => m.LockoutEnd)
                   .Ignore(m => m.NormalizedEmail)
                   .Ignore(m => m.NormalizedUserName)
                   .Ignore(m => m.PhoneNumber)
                   .Ignore(m => m.PhoneNumberConfirmed)
                   .Ignore(m => m.SecurityStamp)
                   .Ignore(m => m.TwoFactorEnabled);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductStock> ProductStock { get; set; }
    }
}
