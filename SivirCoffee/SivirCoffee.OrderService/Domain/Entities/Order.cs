using SivirCoffee.OrderService.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace SivirCoffee.OrderService.Entities
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }

        public OrderStatus Status { get; set; }
    }
}
