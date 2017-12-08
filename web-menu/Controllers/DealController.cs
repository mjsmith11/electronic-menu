using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using data_models;

namespace web_menu.Controllers
{
    public class DealController : Controller
    {
        private readonly NetCoreMenuContext _context;

        public DealController(NetCoreMenuContext context)
        {
            _context = context;
        }
        //GET: Deal
        public IActionResult Index()
        {
            var deals = _context.MenuItems.Where(m => m.DiscountPrice != null || m.Category.Equals("Combo")).ToList();
            return View(deals);
            
        }
    }
}