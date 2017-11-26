using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_models;
using data_models.Models;

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
    }
}
