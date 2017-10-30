﻿using electronic_menu.Models;
using Microsoft.EntityFrameworkCore;

namespace electronic_menu.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) : base(options)
        {
        }

        public DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>().ToTable("Table");
        }
    }
}