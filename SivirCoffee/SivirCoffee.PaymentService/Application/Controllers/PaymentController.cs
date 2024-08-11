using Microsoft.AspNetCore.Mvc;

namespace SivirCoffee.PaymentService.Application.Controllers;

public class PaymentController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
}