using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace data_models.Models
{
    public class Css
    {
        public int CssId { get; set; }

        [StringLength(30)]
        [Index(IsUnique =true)]
        [Required]
        public string DisplayName { get; set; }

        [Required]
        [StringLength(100)]
        public string DevHref { get; set; }

        [Required]
        [StringLength(100)]
        public string ProdHref { get; set; }
    }
}
