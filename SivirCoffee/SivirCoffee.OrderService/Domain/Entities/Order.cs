
using System.ComponentModel.DataAnnotations;
using SivirCoffee.ProductService.Domain.Entities;

namespace SivirCoffee.OrderService.Entities
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public double AmountOrder { get; set; }
        
        public Coffee Coffee { get; set; }
        
        public Candy Candy { get; set; }
        
        public Condiments Condiments { get; set; }
        
        [Required]
        public OrderStatus Status { get; set; }

    }
}
