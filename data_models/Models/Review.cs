using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace data_models.Models
{
    class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [Required]
        public int OrderID { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string CustomerName { get; set; }
        public DateTime Time { get; set; }
        [StringLength(400)]
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        public decimal? Score { get; set; }

        public string Picture { get; set; }

    }
}