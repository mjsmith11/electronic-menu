using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using data_models;
using Microsoft.EntityFrameworkCore;

namespace web_menu.Controllers
{
    public class ReportController : Controller
    {
        private readonly NetCoreMenuContext _context;

        public ReportController(NetCoreMenuContext context)
        {
            _context = context;
        }

        public IActionResult AllSales()
        {
            var paidOrders = _context.Orders
                .AsNoTracking()
                .Where(o => o.IsPaid)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.MenuItem);

            double total = 0;
            foreach(var order in paidOrders)
            {
                foreach (var item in order.OrderItems)
                    total += (double)item.ExtendedPrice;
            }
            ViewData["TotalSales"] = total;
            return View();
        }
    }
}