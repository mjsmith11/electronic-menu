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
                .OrderBy(mi => mi.Category)
                .ToList();
        }
    }
}
