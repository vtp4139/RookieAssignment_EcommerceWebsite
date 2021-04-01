using EcommerceWebsite.Backend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWebsite.Backend.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrderDetail>()
            .HasKey(pc => new { pc.ProductID, pc.OrderID });

            modelBuilder.Entity<OrderDetail>()
                .HasOne(pc => pc.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(pc => pc.ProductID);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(pc => pc.Order)
                .WithMany(c => c.OrderDetails)
                .HasForeignKey(pc => pc.OrderID);

            modelBuilder.Entity<User>()
                .ToTable("AspNetUsers");
        }
    }
}
