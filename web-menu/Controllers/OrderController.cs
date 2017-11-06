using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using data_models;
using data_models.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text;

namespace web_menu.Controllers
{
    public class OrderController : Controller
    {
        private readonly NetCoreMenuContext _context;

        private string[] CategoriesWithSides = new string[] { "Seafood", "Steaks", "Chops and Chicken" };

        public OrderController(NetCoreMenuContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Menu");
        }

        public async Task<IActionResult> AddItem(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var item = await _context.MenuItems
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.MenuItemID == id);

            if(IncludesSides(item))
            {
                PopulateSideDropDownList();
            }
            byte[] orderIdBytes;
            if (!HttpContext.Session.TryGetValue("OrderID", out orderIdBytes)) // no order id in the session.  We will need the table id to create one.
            {
                PopulateTableDropDownList();
            }

            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> AddItem(int? TableId, int Quantity, int? SideId1, int? SideId2, int ItemId)
        {
            byte[] orderIdBytes;
            int orderId;
            if (!HttpContext.Session.TryGetValue("OrderID", out orderIdBytes)) // no order id in the session.  We will need the table id to create one.
            {
                Order o = new Order
                {
                    IsPaid = false,
                    IsPlaced = false,
                    IsPrepared = false,
                    TableID = (int)TableId
                };
                _context.Orders.Add(o);
                await _context.SaveChangesAsync();
                orderId = o.OrderID;
                HttpContext.Session.Set("OrderID", Encoding.ASCII.GetBytes(orderId.ToString()));
            }
            else
            {
                orderId = int.Parse(Encoding.ASCII.GetString(orderIdBytes));
            }

            OrderItem item = new OrderItem
            {
                MenuItemID = ItemId,
                OrderID = orderId,
                Quantity = Quantity
            };
            _context.OrderItems.Add(item);

            if(SideId1 != null)
            {
                OrderItem side1 = new OrderItem
                {
                    MenuItemID = (int)SideId1,
                    OrderID = orderId,
                    Quantity = Quantity
                };
                _context.OrderItems.Add(side1);
            }
            if(SideId2 != null)
            {
                OrderItem side2 = new OrderItem
                {
                    MenuItemID = (int)SideId2,
                    OrderID = orderId,
                    Quantity = Quantity
                };
                _context.OrderItems.Add(side2);
            }
            await _context.SaveChangesAsync();

            var menuItem = await _context.MenuItems.SingleAsync(m => m.MenuItemID == ItemId);
            ViewData["Added"] = 1;
            ViewData["OrderID"] = orderId;
            return View(menuItem);
        }

        public async Task<IActionResult> Review(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var order = await _context.Orders
                .AsNoTracking()
                .Include(o => o.OrderItems)
                .ThenInclude(i => i.MenuItem)
                .SingleOrDefaultAsync(o => o.OrderID == id);

            double total = 0;
            foreach(var orderItem in order.OrderItems)
            {
                if (orderItem.MenuItem.Price == null)
                    continue;
                if (orderItem.MenuItem.DiscountPrice == null)
                    total += (double)(orderItem.MenuItem.Price*orderItem.Quantity);
                else
                    total += (double)(orderItem.MenuItem.DiscountPrice*orderItem.Quantity);
            }

            ViewData["Total"] = total.ToString("C");

            return View(order);
        }

        private bool IncludesSides(MenuItem m)
        {
            if (CategoriesWithSides.Contains(m.Category))
                return true;
            else
                return false;
        }

        private void PopulateSideDropDownList()
        {
            var sidesQuery = from d in _context.MenuItems
                             where d.Category == "Sides"
                             select d;
            ViewBag.SideId = new SelectList(sidesQuery.AsNoTracking(), "MenuItemID", "Title");
        }

        private void PopulateTableDropDownList()
        {
            var tables = _context.Tables
                .AsNoTracking()
                .Where(t => !t.IsEmpty)
                .OrderBy(t => t.TableID);
            ViewBag.TableId = new SelectList(tables, "TableID", "TableID");
        }
    }
}