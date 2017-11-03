using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_menu.Models.Messaging;

namespace web_menu.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CallWaiter()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CallWaiter(int? TableID)
        {
            if (TableID == null)
            {
                return NotFound();
            }
            MessageBoard.waiterRequests.Add((int)TableID);

            return RedirectToAction(nameof(Index));
        }
    }
}