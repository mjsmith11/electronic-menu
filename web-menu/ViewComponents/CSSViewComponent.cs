using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using data_models;
using data_models.Models;
using Microsoft.EntityFrameworkCore;

namespace web_menu.Components
{

    public class CSSViewComponent : ViewComponent
    {
        private readonly NetCoreMenuContext _context;

        public CSSViewComponent(NetCoreMenuContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cssOpt = await _context.SystemOptions
                .AsNoTracking()
                .SingleAsync(o => o.Key == SystemOption.CSS_KEY);

            var css = await _context.Css
                .AsNoTracking()
                .SingleAsync(c => c.DisplayName.Equals(cssOpt.Value));

            return View(css);
        }
    }
}
