using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace data_models.Models
{
    public class Table
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Table Number")]
        public int TableID { get; set; }

        public bool IsEmpty { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
