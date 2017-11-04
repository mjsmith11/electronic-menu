﻿using data_models.Models;
using Microsoft.EntityFrameworkCore;

namespace data_models
{
    public class NetCoreMenuContext : DbContext
    {
        public NetCoreMenuContext(DbContextOptions<NetCoreMenuContext> options) : base(options)
        {
        }

        public DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>().ToTable("Table");
        }
    }
}