using Microsoft.AspNetCore.Mvc;
using SivirCoffee.OrderService.Application.Service;


namespace SivirCoffee.OrderService.Application.Controllers;

[Route("/Order")]
[ApiController]
public class OrderController : Controller
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = OrderService;
    }
    
}
