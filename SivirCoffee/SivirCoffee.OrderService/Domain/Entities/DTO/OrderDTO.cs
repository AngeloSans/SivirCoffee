
namespace SivirCoffee.OrderService.Entities.DTO
{
    public class OrderDTO
    {
        public Guid Id { get; set; }
        public double AmountOrder { get; set; }
        public OrderStatus Status { get; set; }
    }
}
