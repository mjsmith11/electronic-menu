using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using data_models;
using System.Text;

namespace web_menu.Controllers
{
    public class BillController : Controller
    {
        private readonly NetCoreMenuContext _context;

        private string[] CategoriesWithSides = new string[] { "Seafood", "Steaks", "Chops and Chicken" };

        public BillController(NetCoreMenuContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            int id;
            if(!HttpContext.Session.TryGetValue("OrderID", out byte[] orderIdBytes))
            {
                return NotFound();
            }
            else
            {
                id = int.Parse(Encoding.ASCII.GetString(orderIdBytes));
            }
            var order = await _context.Orders
                .AsNoTracking()
                .Include(o => o.OrderItems)
                .ThenInclude(i => i.MenuItem)
                .SingleOrDefaultAsync(o => o.OrderID == id);

            double total = 0;
            foreach (var orderItem in order.OrderItems)
            {
                total += (double)orderItem.ExtendedPrice;
            }

            ViewData["Total"] = total;

            return View(order);
        }
    }
}