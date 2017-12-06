using data_models.Models;
using Microsoft.EntityFrameworkCore;

namespace data_models
{
    public class NetCoreMenuContext : DbContext
    {
        public NetCoreMenuContext(DbContextOptions<NetCoreMenuContext> options) : base(options)
        {
        }

        public DbSet<Table> Tables { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<paymentInfor> paymentInfors { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<SystemOption> SystemOptions { get; set; }
        public DbSet<Css> Css { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>().ToTable("Table");
            modelBuilder.Entity<MenuItem>().ToTable("MenuItem");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderItem>().ToTable("OrderItem");
            modelBuilder.Entity<paymentInfor>().ToTable("paymentInfor");
            modelBuilder.Entity<Coupon>().ToTable("Coupon");
            modelBuilder.Entity<SystemOption>().ToTable("SystemOption");
            modelBuilder.Entity<Css>().ToTable("Css");
            modelBuilder.Entity<Review>().ToTable("Review");
        }
    }
}
