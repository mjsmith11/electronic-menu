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
        [HttpPost]
        public async Task<IActionResult> Index(int id, int? order)
        {
            var couponToUpdate = await _context.Coupons.SingleOrDefaultAsync(t => t.CouponNumber == id);
            couponToUpdate.Status = false;
            couponToUpdate.OrderID = (int)order;
            double discount = (double)couponToUpdate.DiscountPrice;
            await _context.SaveChangesAsync(); 

            var orders= await _context.Orders
                .AsNoTracking()
                .Include(o => o.OrderItems)
                .ThenInclude(i => i.MenuItem)
                .SingleOrDefaultAsync(o => o.OrderID == order);

            double total = 0;
            bool paid = orders.IsPaid;
            foreach (var orderItem in orders.OrderItems)
            {
                total += (double)orderItem.ExtendedPrice;
            }

            ViewData["Total"] = total-discount;
            ViewData["Orderid"] = paid;

            ViewData["couponNumber"] = id;
            ViewData["discount"] = discount;         
            return View(orders);
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
        public async Task<IActionResult> ValidCoupon(int Coupon, int id)
        {
            var coupons = await _context.Coupons
            .AsNoTracking()
            .SingleOrDefaultAsync(o => o.CouponNumber == Coupon);
            var status = coupons.Status;
            if (coupons==null || status == false)
            {
                ViewData["valid"] = "This Coupon is invalid";
            }
            else
            {
                var currentTime = System.DateTime.Now;
                var startTime = coupons.StartDate;
                var endTime = coupons.EndDate;
                if (currentTime < startTime)
                {
                    ViewData["valid"] = "This Coupon not start yet";
                }
                else
                {
                    if (currentTime >= startTime && currentTime <= endTime)
                    {
                        ViewData["valid"] = "This Coupon can be used";
                        ViewData["Orderid"] = id;
                        ViewData["couponNumber"] = coupons.CouponNumber;
                    }
                    else
                    {
                        ViewData["valid"] = "This Coupon is Expired";
                    }
                }
            }


            return View(coupons);
        }
    }
}