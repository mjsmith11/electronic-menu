using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_models;
using data_models.Models;
using System.Data.Entity.Infrastructure;

namespace menu_manager.DBControllers
{
    public class CouponControllers
    {
        public static List<Coupon> GetItemsSortByCategory(NetFrameworkMenuContext context)
        {
            return context.Coupons
                .AsNoTracking()
                .OrderBy(mi => mi.CouponNumber)
                .ToList();
        }
        public static void CreateItem(NetFrameworkMenuContext context, Coupon m)
        {
            context.Coupons.Add(m);
            context.SaveChanges();
        }

        internal static Coupon GetOneById(NetFrameworkMenuContext context, int activeID)
        {
            return context.Coupons
                 .AsNoTracking().
                 Single(m => m.CouponID == activeID);
        }

        internal static bool DeleteItemById(NetFrameworkMenuContext context, int activeID)
        {
            var coupon = context.Coupons
               .SingleOrDefault(m => m.CouponID == activeID);

            if (coupon == null)
                return false;

            try
            {
                context.Coupons.Remove(coupon);
                context.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        internal static void UpdateItemByObject(NetFrameworkMenuContext context, int activeID, Coupon obj)
        {
            var itemToUpdate = context.Coupons
                .SingleOrDefault(m => m.CouponID == activeID);

            itemToUpdate.CouponNumber = obj.CouponNumber;
            itemToUpdate.DiscountPrice = obj.DiscountPrice;
            itemToUpdate.StartDate = obj.StartDate;
            itemToUpdate.EndDate = obj.EndDate;
            itemToUpdate.Status = obj.Status;
            context.SaveChanges();
        }
    }
}