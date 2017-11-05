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

        //Navigation Properties
        public Order Order { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}
