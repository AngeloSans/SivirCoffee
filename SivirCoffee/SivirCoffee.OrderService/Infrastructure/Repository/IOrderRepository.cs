using SivirCoffee.OrderService.Entities;

namespace SivirCoffee.OrderService.Infrastructure.Repository;

public interface IOrderRepository
{
    Task<Order> GetOrderByIdAsync(Guid id);
    Task<IEnumerable<Order>> GetAllOrderAsync();
    Task AddOrderAsync(Order order);
    Task DeleteOrderAsync(Guid id);
}
