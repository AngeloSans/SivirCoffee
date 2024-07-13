using Microsoft.EntityFrameworkCore;
using SivirCoffee.ProductService.Entities;
using SivirCoffee.ProductService.Infraestructure;

namespace SivirCoffee.ProductService.Repository;

public class ProductRepository : IProductRepository
{
    private readonly ProductServiceDBcontext _dBcontext;

    public ProductRepository(ProductServiceDBcontext dBcontext)
    {
        _dBcontext = dBcontext;
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        return await _dBcontext.Products.ToListAsync();
    }
}