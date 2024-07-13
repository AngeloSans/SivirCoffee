using Microsoft.AspNetCore.Mvc;
using SivirCoffee.ProductService.Repository;

namespace SivirCoffee.ProductService.Application.Controllers;


[Route("Product[controller]")]
[ApiController]
public class ProductController : Controller
{
    private readonly ProductRepository _productRepository;

    public ProductController(ProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet("GetAllProduct")]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await _productRepository.GetAllProducts();
        return Ok(products);
    }
}