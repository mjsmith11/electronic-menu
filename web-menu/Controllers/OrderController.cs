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

        //Gather details on the item the user clicked and request details such as quantity an sides
        public async Task<IActionResult> AddItem(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var item = await _context.MenuItems
                .AsNoTracking()
                .Include(m => m.Reviews)
                .SingleOrDefaultAsync(m => m.MenuItemID == id);
            int score = 0;
            int no = 0;
            foreach(var i in item.Reviews)
            {
                score += i.Score;
                no++;
            }
            double totalScore = ((double)score / no);
            if(IncludesSides(item))
            {
                PopulateSideDropDownList();
            }
            byte[] orderIdBytes;
            if (!HttpContext.Session.TryGetValue("OrderID", out orderIdBytes)) // no order id in the session.  We will need the table id to create one.
            {
                PopulateTableDropDownList();
            }

            ViewData["score"] = totalScore;
            return View(item);
        }

        //Insert the ordered itema nd any sides into the database
        [HttpPost]
        public async Task<IActionResult> AddItem(int? TableId, int Quantity, int? SideId1, int? SideId2, int ItemId, string Comment)
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
                Quantity = Quantity,
                Comment = Comment
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

            var menuItem = await _context.MenuItems.Include(m => m.Reviews).SingleAsync(m => m.MenuItemID == ItemId);
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
                total += (double)orderItem.ExtendedPrice;
            }

            ViewData["Total"] = total.ToString("C");

            return View(order);
        }

        public async Task<IActionResult> DeleteItem(int? id, bool? saveChangesError=false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItem = await _context.OrderItems
                .AsNoTracking()
                .Include(o => o.MenuItem)
                .SingleOrDefaultAsync(o => o.OrderItemID == id);

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] = "Failed to remove the item from your order.  Please try again.";
            }

            return View(orderItem);
                
        }

        [HttpPost, ActionName("DeleteItem")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteItemConfirmed(int id)
        {
            var orderItem = await _context.OrderItems
                .AsNoTracking()
                .SingleOrDefaultAsync(o => o.OrderItemID == id);

            if (orderItem == null)
            {
                return RedirectToOrderOrMenu();
            }

            try
            {
                _context.OrderItems.Remove(orderItem);
                await _context.SaveChangesAsync();
                return RedirectToOrderOrMenu();
            }
            catch(DbUpdateException)
            {
                return RedirectToAction(nameof(DeleteItem), new { id = id, saveChangesError = true });
            }
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> PlaceOrder(int id)
        {
            var order = await _context.Orders
                .SingleOrDefaultAsync(o => o.OrderID == id);

            order.IsPlaced = true;
            await _context.SaveChangesAsync();

            return View();

        }

        private IActionResult RedirectToOrderOrMenu()
        {
            if (HttpContext.Session.TryGetValue("OrderID", out byte[] orderIdBytes))
                return RedirectToAction(nameof(Review), new { id = int.Parse(Encoding.ASCII.GetString(orderIdBytes)) });
            else
                return RedirectToAction(nameof(Index), nameof(MenuController));
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
            var orders = _context.Orders.ToList();
            var tables = _context.Tables
                .AsNoTracking()
                .Where(t => !t.IsEmpty);
            tables = tables.Where(t => !HasUnpaidOrder(t, orders.Where(o => o.TableID == t.TableID).ToList())); //don't open an order for a table until previous is paid
            tables = tables.OrderBy(t => t.TableID);
            ViewBag.TableId = new SelectList(tables, "TableID", "TableID");
        }

        private bool HasUnpaidOrder(Table t, List<Order> orders)
        {
            if (orders == null)
            {
                return false;
            }
            foreach (Order o in orders)
            {
                if (!o.IsPaid)
                {
                    return true;
                }
            }
            return false;
        }
    }
}