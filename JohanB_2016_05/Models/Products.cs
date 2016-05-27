using System.ComponentModel.DataAnnotations;

namespace JohanB_2016_05.Models
{
    public class Products
    {
        [Required]
        public int ProductId { get; set; }
        [Required, MinLength(3), MaxLength(80)]
        public string Name { get; set; }
        [Required, MinLength(3), MaxLength(580)]
        public string  ProductText { get; set; }
        [Required, Range(1,1000)]
        public int ProductNumber { get; set; }
        [Required, Range(0,1000)]
        public int ProductsInStock { get; set; }
    }
}