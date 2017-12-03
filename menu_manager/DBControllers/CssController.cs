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
    class CssController
    {
        public static List<string> ReturnAllDisplayNames(NetFrameworkMenuContext context)
        {
            return context.Css
                .AsNoTracking()
                .Select(o => o.DisplayName)
                .ToList();
        }

        public static string ReturnSelectedCSS(NetFrameworkMenuContext context)
        {
            return context.SystemOptions
                .AsNoTracking()
                .Single(o => o.Key.Equals(SystemOption.CSS_KEY))
                .Value;
        }

        public static void UpdateActiveCSS(NetFrameworkMenuContext context, string newValue)
        {
            var settingToUpdate = context.SystemOptions
                .Single(o => o.Key.Equals(SystemOption.CSS_KEY));

            settingToUpdate.Value = newValue;

            context.SaveChanges();
        }
    }
}
