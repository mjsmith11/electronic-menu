using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace data_models.Models
{
    public class Coupon
    {
        public int CouponID { get; set; }
        [Required]
        public int CouponNumber { get; set; }
        [Required]
        public double DiscountPrice { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public int Status { get; set; }
    }
}