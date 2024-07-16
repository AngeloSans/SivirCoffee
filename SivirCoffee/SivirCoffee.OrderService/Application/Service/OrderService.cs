using SivirCoffee.OrderService.Application.Service;
using SivirCoffee.OrderService.Entities;
using SivirCoffee.OrderService.Infrastructure.Repository;

namespace SivirCoffee.OrderService.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _oderRepository;

        public OrderService(IOrderRepository oderRepository)
        {
            _oderRepository = oderRepository;
        }

        public Task AddOrderAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrderAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
