using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_menu.Data;
using web_menu.Models.Messaging;
using web_menu.Models.ViewModels;

namespace web_menu.Controllers
{
    public class TablesController : Controller
    {
        private readonly MenuContext _context;

        public TablesController(MenuContext context)
        {
            _context = context;
        }

        // GET: Tables
        public async Task<IActionResult> Index()
        {
            var tables = _context.Tables
                .AsNoTracking()
                .OrderByDescending(t => t.IsEmpty)
                .ThenBy(t => t.TableID);
            TablesWithRequests model = new TablesWithRequests();
            model.Tables = await tables.ToListAsync();
            model.WaiterRequests = new List<int>();
            return View(model);
        }

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


        [ResponseCache(NoStore = true, Location = ResponseCacheLocation.Client, Duration = 15)]
        public ActionResult Requests()
        {
            List<int> tables = new List<int>();
            int tableNum;
            while (MessageBoard.waiterRequests.TryTake(out tableNum))
            {
              tables.Add(tableNum);
            }
            TablesWithRequests model = new TablesWithRequests();
            model.WaiterRequests = tables;

            return PartialView("_requests", model);
        }
    }
}