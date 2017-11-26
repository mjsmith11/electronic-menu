using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_models;
using data_models.Models;
using System.Data.Entity.Infrastructure;

namespace menu_manager.DBControllers
{
    public class MenuItemController
    {
        public static List<MenuItem> GetItemsSortByCategory(NetFrameworkMenuContext context)
        {
            return context.MenuItems
                .AsNoTracking()
                .OrderBy(mi => mi.Category)
                .ToList();
        }

        public static MenuItem GetOneById(NetFrameworkMenuContext context, int id)
        {
            return context.MenuItems
                .AsNoTracking().
                Single(m => m.MenuItemID == id);
        }

        public static List<String> GetCategories(NetFrameworkMenuContext context)
        {
            return context.MenuItems
                .AsNoTracking()
                .Select(m => m.Category)
                .Distinct()
                .ToList();
        }

        public static void CreateItem(NetFrameworkMenuContext context, MenuItem m)
        {
            context.MenuItems.Add(m);
            context.SaveChanges();
        }

        public static bool DeleteItemById(NetFrameworkMenuContext context, int id)
        {
            var menuItem = context.MenuItems
                .SingleOrDefault(m => m.MenuItemID == id);

            if (menuItem == null)
                return false;

            try
            {
                context.MenuItems.Remove(menuItem);
                context.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }
    }
}
