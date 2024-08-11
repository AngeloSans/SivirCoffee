using Microsoft.AspNetCore.Mvc;
using SivirCoffee.OrderService.Application.Service;
using SivirCoffee.OrderService.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SivirCoffee.OrderService.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetAllOrders()
        {
            var orders = await _orderService.GetAllOrders();
            return Ok(orders);
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrderById(Guid id)
        {
            var order = await _orderService.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        
        [HttpPost]
        public async Task<ActionResult<Order>> AddOrderAsync(Order order)
        {
            await _orderService.AddOrderAsync(order);
            return CreatedAtAction(nameof(GetOrderById), new { id = order.Id }, order);
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderAsync(Guid id)
        {
            var order = await _orderService.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }

            await _orderService.DeleteOrderAsync(id);
            return NoContent();
        }
    }
}