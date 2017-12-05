using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using data_models;
using data_models.Models;
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
            foreach (var order in paidOrders)
            {
                foreach (var item in order.OrderItems)
                    total += (double)item.ExtendedPrice;
            }
            ViewData["TotalSales"] = total;
            return View();
        }
        public async Task<IActionResult> History(string sortOrder, string SearchString, string selected)
        {
            ViewData["priceSort"] = sortOrder == "price" ? "price_desc" : "price";
            ViewData["tipSort"] = sortOrder == "tip" ? "tip_desc" : "tip";
            ViewData["OrderSort"] = sortOrder == "order"? "order_desc" : "order";
            ViewData["timeSort"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CurrentFilter"] = SearchString;
            var payments = from s in _context.paymentInfors
                         select s;
            if (!String.IsNullOrEmpty(SearchString))
            {
                if (selected == "TableID")
                {
                    payments = payments.Where(s => s.TableID.ToString().Contains(SearchString));
                }
                else
                {
                    if(selected == "OrderID")
                    {
                        payments = payments.Where(s => s.OrderID.ToString().Contains(SearchString));
                    }
                    else
                    {
                        if (selected == "Time")
                        {
                            payments = payments.Where(s => s.Time.ToString().Contains(SearchString));
                        }
                    }
                }
                
                
                                       
            }
            switch (sortOrder)
            {
                case "tip_desc":
                    payments = payments.OrderByDescending(s => s.Tips);
                    break;
                case "tip":
                    payments = payments.OrderBy(s => s.Tips);
                    break;
                case "order_desc":
                    payments = payments.OrderByDescending(s => s.OrderID);
                    break;
                case "order":
                    payments = payments.OrderBy(s => s.OrderID);
                    break;
                case "price":
                    payments = payments.OrderBy(s => s.TotalPrice);
                    break;
                case "price_desc":
                    payments = payments.OrderByDescending(s => s.TotalPrice);
                    break;
                case "Date":
                    payments = payments.OrderBy(s => s.Time);
                    break;
                case "date_desc":
                    payments = payments.OrderByDescending(s => s.Time);
                    break;
                default:
                    payments = payments.OrderBy(s => s.OrderID);
                    break;
            }
            return View(await payments.AsNoTracking().ToListAsync());
        }


    }
}