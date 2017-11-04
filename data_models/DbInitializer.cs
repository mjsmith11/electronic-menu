using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data_models.Models;

namespace data_models
{
    public class DbInitializer
    {
        public static void Initialize(NetCoreMenuContext context)
        {
            context.Database.EnsureCreated();

            if(context.Tables.Any())
            {
                return; // DB has already been seeded
            }

            seedTables(context);
        }

        public static void seedTables(NetCoreMenuContext context)
        {
            var tables = new Table[]
            {
                new Table { TableID = 1, IsEmpty = true },
                new Table { TableID = 2, IsEmpty = true },
                new Table { TableID = 3, IsEmpty = true },
                new Table { TableID = 4, IsEmpty = true },
                new Table { TableID = 5, IsEmpty = true },
                new Table { TableID = 6, IsEmpty = true },
                new Table { TableID = 7, IsEmpty = true },
                new Table { TableID = 8, IsEmpty = true },
                new Table { TableID = 9, IsEmpty = true },
                new Table { TableID = 10, IsEmpty = true }
            };

            foreach (Table t in tables)
            {
                context.Tables.Add(t);
            }
            context.SaveChanges();
        }
    }
}
