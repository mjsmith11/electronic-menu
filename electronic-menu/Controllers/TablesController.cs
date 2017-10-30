using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using electronic_menu.Data;
using electronic_menu.Models;

namespace electronic_menu.Controllers
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
            return View(await tables.ToListAsync());
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
    }
}