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
        [MyAttributes]
        public string Name { get; set; }
        
        public string Address { get; set; }
        
        public Products Productses { get; set; }
    }
}