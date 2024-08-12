using Microsoft.AspNetCore.Mvc;
using SivirCoffee.ProductService.Repository;

namespace SivirCoffee.ProductService.Application.Controllers;


[Route("Product[controller]")]
[ApiController]
public class MenuController : Controller
{
    private readonly MenuRepository _menuRepository;

    public MenuController(MenuRepository menuRepository)
    {
        _menuRepository = menuRepository;
    }

    [HttpGet("GetAllMenu")]
    public async Task<IActionResult> GetAllMenu()
    {
        var products = await _menuRepository.GetCandiesAsync();
        return Ok(products);
    }
}