using Microsoft.EntityFrameworkCore;
using SivirCoffee.ProductService.Domain.Entities;
using SivirCoffee.ProductService.Infrastructure;

namespace SivirCoffee.ProductService.Repository;

public class MenuRepository : IMenuRepository
{
    private readonly MenuServiceDBcontext _dBcontext;

    public MenuRepository(MenuServiceDBcontext dBcontext)
    {
        _dBcontext = dBcontext;
    }

    public async Task<IEnumerable<Candy>> GetAllProducts()
    {
        return await _dBcontext.Candies.ToListAsync();
    }
}