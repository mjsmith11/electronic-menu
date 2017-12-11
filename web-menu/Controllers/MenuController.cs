using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using data_models.Models.Messaging;
using data_models;
using data_models.Models;

namespace web_menu.Controllers
{
    public class MenuController : Controller
    {
       private readonly NetCoreMenuContext _context;

        public MenuController(NetCoreMenuContext context)
        {
            _context = context;
        }

        //Create a list of lists of menuitems where each sublist represents menuitems for a specific category and the main list is ordered in display order
        public async Task<IActionResult> Index(string sortOrder)
        {
            var categories = await _context.MenuItems
                .AsNoTracking()
                .Select(m => m.Category)
                .Distinct()
                .OrderBy(m => GetCategorySortIndex(m))
                .ToListAsync();

            ViewData["reviewSort"] = sortOrder == "review" ? "review" : "review_desc";
            ViewData["decreaseSort"] = String.IsNullOrEmpty(sortOrder) ? "price_desc": "price_desc";
            ViewData["IncreaseSort"] = String.IsNullOrEmpty(sortOrder) ? "price_asc": "price_asc";

            List<List<MenuItem>> menu = new List<List<MenuItem>>();
            foreach(string category in categories)
            {
                var categoryItems = from s in _context.MenuItems
                                    .Where(m => (m.Category.Equals(category)))
                                    select s;
                switch (sortOrder)
                {
                    case "review_desc":
                        categoryItems = categoryItems.OrderByDescending(s => s.Score);
                        break;
                    case "review":
                        categoryItems = categoryItems.OrderBy(s => s.Score);
                        break;
                    case "price_desc":
                        categoryItems = categoryItems.OrderByDescending(s => s.Price);
                        break;
                    case "price_asc":
                        categoryItems = categoryItems.OrderBy(s => s.Price);
                        break;
                    default:
                        break;
                }
                await categoryItems.AsNoTracking().ToListAsync();
                menu.Add(categoryItems.ToList());
            }
   
            return View(menu);
        }

        public IActionResult CallWaiter()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CallWaiter(int? TableID, string request)
        {
            if (TableID == null)
            {
                return NotFound();
            }
            WaiterRequest r = new WaiterRequest
            {
                TableNumber = (int)TableID,
                Request = request
            };

            MessageBoard.waiterRequests.Add(r);

            return RedirectToAction(nameof(Index));
        }

        private int GetCategorySortIndex(string category)
        {
            switch(category)
            {

                case "Appetizers": return 1;
                case "Steaks": return 2;
                case "Chops and Chicken": return 3;
                case "Seafood": return 4;
                case "Salads": return 5;
                case "Sides": return 6;
                case "Desserts": return 7;
                default: return 8;
            }
        }
    }
}