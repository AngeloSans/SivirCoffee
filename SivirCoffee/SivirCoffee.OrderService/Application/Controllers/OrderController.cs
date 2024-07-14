using Microsoft.AspNetCore.Mvc;

namespace SivirCoffee.OrderService.Application.Controllers;

public class OrderController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}