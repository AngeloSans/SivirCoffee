using SivirCoffee.OrderService.Application.Service;
using SivirCoffee.OrderService.Entities;
using SivirCoffee.OrderService.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SivirCoffee.OrderService.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task AddOrderAsync(Order order)
        {
            await _orderRepository.AddOrderAsync(order);
        }

        public async Task DeleteOrderAsync(Guid id)
        {
            await _orderRepository.DeleteOrderAsync(id);
        }

        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await _orderRepository.GetAllOrderAsync();
        }

        public async Task<Order> GetOrderById(Guid id)
        {
            return await _orderRepository.GetOrderByIdAsync(id);
        }
    }
}