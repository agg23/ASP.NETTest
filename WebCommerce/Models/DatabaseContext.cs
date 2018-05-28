using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebCommerce.Models.Users;

namespace WebCommerce.Models
{
    public class DatabaseContext : IdentityDbContext<User, UserRole, int>
    {
        public DbSet<Product> Products { get; set; }
        //public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductStock> ProductStock { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                   .Ignore(m => m.Email)
                   .Ignore(m => m.EmailConfirmed)
                   .Ignore(m => m.AccessFailedCount)
                   .Ignore(m => m.ConcurrencyStamp)
                   .Ignore(m => m.LockoutEnabled)
                   .Ignore(m => m.LockoutEnd)
                   .Ignore(m => m.NormalizedEmail)
                   .Ignore(m => m.PhoneNumber)
                   .Ignore(m => m.PhoneNumberConfirmed)
                   .Ignore(m => m.TwoFactorEnabled)
                   .ToTable("Users");
        }
    }
}
