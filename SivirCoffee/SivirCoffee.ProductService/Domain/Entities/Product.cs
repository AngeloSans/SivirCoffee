using System.ComponentModel.DataAnnotations;

namespace SivirCoffee.ProductService.Entities
{
    public class Product
    {
        [Key] 
        private Guid Id { get; set; }
    }
}
