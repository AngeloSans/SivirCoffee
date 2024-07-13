using System.ComponentModel.DataAnnotations;

namespace SivirCoffee.ProductService.Entities
{
    public class Product
    {
        [Key] 
        public Guid Id { get; set; }

        [Required] [MaxLength(200)] 
        public string ProductNmae { get; set; }
        
        [Required]
        public double Amount { get; set; }
    }
}
