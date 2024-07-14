using Microsoft.EntityFrameworkCore;
using SivirCoffee.OrderService.Entities;
using SivirCoffee.OrderService.Repository;

namespace SivirCoffee.OrderService.Infraestructure.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDBContext _dbContext;

        public OrderRepository(OrderDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddOrderAsync(Order order)
        {
            await _dbContext.Orders.AddAsync(order);
            await _dbContext.SaveChangesAsync();
           
        }

        public async Task DeleteOrderAsync(Guid id)
        {
            var orderId = await _dbContext.Orders.FindAsync(id);
            if(orderId != null)
            {
                _dbContext.Orders.Remove(orderId);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Order>> GetAllOrderAsync()
        {
            return await _dbContext.Orders
                .ToListAsync();
        }

        public async Task<Order> GetOrderByIdAsync(Guid id)
        {
            return await _dbContext.Orders
                .FirstOrDefaultAsync(Order => Order.Id == id);
        }
    }
}
