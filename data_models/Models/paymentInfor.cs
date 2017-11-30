using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace data_models.Models
{
    public class paymentInfor
    {
        [Key]
        public int paymentInforID { get; set; }
        [Required]
        public int OrderID { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string PaymentMethod { get; set; }
        [DataType(DataType.Currency)]
        public decimal? Tips { get; set; }
        [DataType(DataType.Currency)]
        public decimal? TotalPrice { get; set; }
        [Required]
        public int TableID { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string CustomerName { get; set; }

        public DateTime Time { get; set; }
        public string CardNumber { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 1)]
        public string email { get; set; }

    }
}
