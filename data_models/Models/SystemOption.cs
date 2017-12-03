using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace data_models.Models
{
    public class SystemOption
    {
        [Key]
        [StringLength(30)]
        public string Key { get; set; }

        [StringLength(50)]
        public string Value { get; set; }

        #region Keys
        public const string CSS_KEY = "site_css"; 
        #endregion


    }
}
