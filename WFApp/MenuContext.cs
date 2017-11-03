using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_models.Models;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace WFApp
{
    public class MenuContext : DbContext
    {
        public DbSet<Table> Table { get; set; }

        public MenuContext()
        {

        }

        public MenuContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>().ToTable("Table");
        }
    }
}
