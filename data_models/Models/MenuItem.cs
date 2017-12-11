using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace data_models.Models
{
    public class MenuItem
    {
        public int MenuItemID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Title { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name ="Price Each")]
        public decimal? Price { get; set; }
        [DataType(DataType.Currency)]
        public decimal? DiscountPrice { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string Category { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
        public bool IsSpecialty { get; set; }
        public string Image { get; set; }
        public string Alergy { get; set; }
        public string Calories { get; set; }
        [DataType(DataType.Currency)]
        public decimal Score { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
