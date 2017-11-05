using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace data_models.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        [Required]
        public bool IsPlaced { get; set; }
        [Required]
        public bool IsPrepared { get; set; }
        [Required]
        public bool IsPaid { get; set; }

        ///Foreign Key to the table the order is for.
        [Required]
        public int TableID { get; set; }

        ///Navigation Properties
        public Table Table { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        
    }
}
