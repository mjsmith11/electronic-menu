using data_models;
using data_models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_menu.Views.WritingReview
{
    public class WritingReviewController : Controller
    {
        private readonly NetCoreMenuContext _context;
        public WritingReviewController(NetCoreMenuContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Menu");
        }
        public async Task<IActionResult> Addreview(int? id)
        {
            var payment = await _context.paymentInfors
                .AsNoTracking()
                .SingleOrDefaultAsync(o => o.paymentInforID == id);
            int order = payment.OrderID;
            string name = payment.CustomerName;
          
            var item = await _context.Orders
                .AsNoTracking()
                .Include(i => i.OrderItems)
                .ThenInclude(m => m.MenuItem)
                .SingleOrDefaultAsync(i => i.OrderID == order);
            ViewData["customer"] = name;
            ViewData["pid"] = id;
            return View(item);
        }

        public async Task<IActionResult> writeItem(int? id, string name, int? payment)
        {
            var menu = await _context.MenuItems
                .AsNoTracking()
                .SingleOrDefaultAsync(o => o.MenuItemID == id);
            ViewData["customer"] = name;
            ViewData["pid"] = payment;
            return View(menu);
        }
        [HttpPost]
        public async Task<IActionResult> writeItem(int? itemid, string name, int score, string comment, int payment)
        {

            Review o = new Review
            {
                CustomerName = name,
                Time = System.DateTime.Now,
                Description = comment,
                Score = score,
                MenuItemID = (int)itemid,
            };
            _context.Reviews.Add(o);
            await _context.SaveChangesAsync();
            //calculate the total score for this menu item and save it in menuitem 
            var item = await _context.MenuItems
               .AsNoTracking()
               .Include(m => m.Reviews)
               .SingleOrDefaultAsync(m => m.MenuItemID == itemid);
            int scores = 0;
            int no = 0;
            foreach (var i in item.Reviews)
            {
                scores += i.Score;
                no++;
            }
            double totalScore = ((double)scores / no);
            
            var scoreToUpdate = await _context.MenuItems.SingleOrDefaultAsync(t => t.MenuItemID == itemid);
            scoreToUpdate.Score = (decimal)totalScore;
            await _context.SaveChangesAsync();

            var menuItem = await _context.MenuItems.SingleAsync(m => m.MenuItemID == itemid);
            ViewData["Added"] = 1;
            ViewData["customer"] = name;
            ViewData["pid"] = payment;

            return View(menuItem);
        }
    }
}