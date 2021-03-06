﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using data_models;
using data_models.Models;

namespace web_menu.Controllers
{
    public class PreOrderController : Controller
    {
        private readonly NetCoreMenuContext _context;

        public PreOrderController(NetCoreMenuContext context)
        {
            _context = context;
        }
        //The preorder tab will find all tables that are equal to -1 and have not yet been paid for, this will show current preorders
        //To seat the preorder customer at a table, click the edit link and select a new table. Then go to the table map and mark it as not available
        // GET: PreOrder
        public async Task<IActionResult> Index()
        {
            var netCoreMenuContext = _context.Orders.Where(o => o.TableID == -1 && o.IsPaid != true);
            return View(await netCoreMenuContext.ToListAsync());
        }

        // GET: PreOrder/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Table)
                .SingleOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: PreOrder/Create
        public IActionResult Create()
        {
            ViewData["TableID"] = new SelectList(_context.Tables, "TableID", "TableID");
            return View();
        }

        // POST: PreOrder/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,IsPlaced,IsPrepared,IsPaid,TableID")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TableID"] = new SelectList(_context.Tables, "TableID", "TableID", order.TableID);
            return View(order);
        }

        // GET: PreOrder/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.SingleOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["TableID"] = new SelectList(_context.Tables, "TableID", "TableID", order.TableID);
            return View(order);
        }

        // POST: PreOrder/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,IsPlaced,IsPrepared,IsPaid,TableID")] Order order)
        {
            if (id != order.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["TableID"] = new SelectList(_context.Tables, "TableID", "TableID", order.TableID);
            return View(order);
        }

        // GET: PreOrder/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Table)
                .SingleOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: PreOrder/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.SingleOrDefaultAsync(m => m.OrderID == id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderID == id);
        }
    }
}
