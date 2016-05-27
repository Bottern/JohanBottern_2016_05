using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JohanB_2016_05.Models
{
    public class Store
    {
        [Required]
        public int StoreId { get; set; }
        [Required, MinLength(3), MaxLength(80)]
        public string Name { get; set; }
        [Required, MinLength(5), MaxLength(250)]
        public string Address { get; set; }
        [Required]
        public Products Products { get; set; }
    }
}