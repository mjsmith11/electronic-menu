using data_models;
using data_models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_menu.Controllers
{
    public class BillController : Controller
    {
        private readonly NetCoreMenuContext _context;

        private string[] CategoriesWithSides = new string[] { "Seafood", "Steaks", "Chops and Chicken" };

        public BillController(NetCoreMenuContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            int id;
            if (!HttpContext.Session.TryGetValue("OrderID", out byte[] orderIdBytes))
            {
                return NotFound();
            }
            else
            {
                id = int.Parse(Encoding.ASCII.GetString(orderIdBytes));
            }
            var order = await _context.Orders
                .AsNoTracking()
                .Include(o => o.OrderItems)
                .ThenInclude(i => i.MenuItem)
                .SingleOrDefaultAsync(o => o.OrderID == id);

            double total = 0;
            bool paid = order.IsPaid;
            foreach (var orderItem in order.OrderItems)
            {
                total += (double)orderItem.ExtendedPrice;
            }

            ViewData["Total"] = total;
            ViewData["Orderid"] = paid;

            return View(order);
        }

        public async Task<IActionResult> recipt(string cardnumber, int? table, int? id, int? tips, string paymentMethod, string CustomerName, int totalprice, string email)
        {

            int paymentInforId;
            if (!HttpContext.Session.TryGetValue("paymentInforID", out byte[] paymentInforIdBytes)) // no order id in the session.  We will need the table id to create one.
            {
                paymentInfor o = new paymentInfor
                {
                    PaymentMethod = paymentMethod,
                    CustomerName = CustomerName,
                    Tips = tips,
                    TotalPrice = totalprice,
                    TableID = (int)table,
                    OrderID = (int)id,
                    Time = System.DateTime.Now,
                    email = email,
                    CardNumber = cardnumber,
                };
                _context.paymentInfors.Add(o);
                await _context.SaveChangesAsync();
                paymentInforId = o.paymentInforID;
                HttpContext.Session.Set("paymentInforID", Encoding.ASCII.GetBytes(paymentInforId.ToString()));

                var orderToUpdate = await _context.Orders.SingleOrDefaultAsync(i => i.OrderID == id);
                orderToUpdate.IsPaid = true;
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("", "Unable to update order.");
                }
            }
            else
            {
                paymentInforId = int.Parse(Encoding.ASCII.GetString(paymentInforIdBytes));
            }
            var order = await _context.paymentInfors
                .AsNoTracking()
                .SingleOrDefaultAsync(o => o.OrderID == id);
            double total = 0;
            string card = "";
            total = (double)order.Tips + (double)order.TotalPrice;
            card = "********" + order.CardNumber.Substring(order.CardNumber.Length - 4);
            ViewData["Totalpaid"] = total;
            ViewData["CardNumber"] = card;
            return View(order);


        }
        public async Task<IActionResult> validCoupon(int Coupon)
        {
            var coupons = await _context.Coupons
            .AsNoTracking()
            .SingleOrDefaultAsync(m => m.CouponNumber == Coupon);
            if (coupons == null)
            {
                ViewData["valid"] = "This Coupon is invalid";
            }
            else
            {
                ViewData["valid"] = "This Coupon can be used";
            }

            return View(coupons);
        }
    }
}