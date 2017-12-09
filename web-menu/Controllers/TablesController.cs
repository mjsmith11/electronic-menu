using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using data_models.Models.Messaging;
using data_models.Models.ViewModels;
using data_models;

namespace web_menu.Controllers
{
    public class TablesController : Controller
    {
        private readonly NetCoreMenuContext _context;

        public TablesController(NetCoreMenuContext context)
        {
            _context = context;
        }

        //Get a listing of tables sorted by availability and find open orders for tables
        // GET: Tables
        public async Task<IActionResult> Index()
        {
            var tables = _context.Tables.Where(t => t.TableID > 0)
                .AsNoTracking()
                .OrderByDescending(t => t.IsEmpty)
                .ThenBy(t => t.TableID);
            TablesWithRequests model = new TablesWithRequests();
            model.Tables = await tables.ToListAsync();
            model.WaiterRequests = new List<WaiterRequest>();
            ViewData["Orders"] = FindActiveOrders();
            return View(model);
        }

        //Marks a table as unavailabel
        // GET: Tables/Seat/5
        public async Task<IActionResult> Seat(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableToUpdate = await _context.Tables.SingleOrDefaultAsync(t => t.TableID == id);
            tableToUpdate.IsEmpty = false;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException)
            {
                ModelState.AddModelError("", "Unable to update table.");
            }
            return RedirectToAction(nameof(Index));
        }

        // Marks a table as available
        // GET: Tables/Available/5
        public async Task<IActionResult> Available(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableToUpdate = await _context.Tables.SingleOrDefaultAsync(t => t.TableID == id);
            tableToUpdate.IsEmpty = true;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                ModelState.AddModelError("", "Unable to update table.");
            }
            return RedirectToAction(nameof(Index));

        }

        //Sets the identified order to paid status
        public async Task<IActionResult> Paid(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var orderToUpdate = await _context.Orders.SingleOrDefaultAsync(o => o.OrderID == id);
            orderToUpdate.IsPaid = true;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                ModelState.AddModelError("", "Unable to update order.");
            }
            return RedirectToAction(nameof(Index));
        }


        //Responds to AJAX request for waiter requests
        [ResponseCache(NoStore = true, Location = ResponseCacheLocation.Client, Duration = 15)]
        public ActionResult Requests()
        {
            List<WaiterRequest> tables = new List<WaiterRequest>();
            while (MessageBoard.waiterRequests.TryTake(out WaiterRequest r))
            {
                tables.Add(r);
            }
            TablesWithRequests model = new TablesWithRequests
            {
                WaiterRequests = tables
            };

            return PartialView("_requests", model);
        }

        private Dictionary<int,int> FindActiveOrders()
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            var unPaidOrders = _context.Orders
                .Where(o => o.IsPaid == false); //since it is not allowed to open an order at a table with an unpaid order, this should have 0 or 1 order per table

            foreach(var order in unPaidOrders)
            {
                result.Add(order.TableID, order.OrderID);
            }
            return result;
        }
    }
}