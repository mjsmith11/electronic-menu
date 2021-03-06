﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_models.Models;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace data_models
{
    public class NetFrameworkMenuContext : DbContext
    {
        public DbSet<Table> Table { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<paymentInfor> paymentInfors { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<SystemOption> SystemOptions { get; set; }
        public DbSet<Css> Css { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public NetFrameworkMenuContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
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

        public static NetFrameworkMenuContext GetContext()
        {
            string connectionString = DbConfig.GetMySQLConnectionString();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
                return new NetFrameworkMenuContext(connection, false);
        }
    }
}
