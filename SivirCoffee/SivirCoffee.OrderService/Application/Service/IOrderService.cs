using SivirCoffee.OrderService.Entities;

namespace SivirCoffee.OrderService.Application.Service
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllOrders();
        Task<Order> GetOrderById(Guid id);
        Task AddOrderAsync(Order order);
        Task DeleteOrderAsync (Guid id);
        
    }
}
