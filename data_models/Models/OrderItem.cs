using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace data_models.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }

        // Foreign Keys to Order and MenuItem tables
        [Required]
        public int OrderID { get; set; }
        [Required]
        public int MenuItemID { get; set; }
        [Required]
        public int Quantity { get; set; }
        public string Comment { get; set; }

        //Navigation Properties
        public Order Order { get; set; }
        public MenuItem MenuItem { get; set; }
        
        [Display(Name ="Extended Price")]
        [DataType(DataType.Currency)]
        public decimal ExtendedPrice {
            get
            {
                if (MenuItem.Price == null)
                    return 0;
                if (MenuItem.DiscountPrice == null)
                    return (decimal)MenuItem.Price * Quantity;
                else
                    return (decimal)MenuItem.DiscountPrice * Quantity;
            }
            }
    }
}
