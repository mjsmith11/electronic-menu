using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace data_models.Models
{
    public class Css
    {
        [Key]
        [StringLength(30)]
        public string DisplayName { get; set; }

        [Required]
        [StringLength(100)]
        public string DevHref { get; set; }

        [Required]
        [StringLength(100)]
        public string ProdHref { get; set; }
    }
}
