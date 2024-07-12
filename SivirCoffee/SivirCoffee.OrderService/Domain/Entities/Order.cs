using System.ComponentModel.DataAnnotations;

namespace SivirCoffee.OrderService.Entities
{
    public class Order
    {
        [Key]
        private Guid Id { get; set; }
    }
}
