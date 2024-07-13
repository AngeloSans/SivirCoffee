using SivirCoffee.ProductService.Domain.Entities;

namespace SivirCoffee.ProductService.Repository
{
    public interface IMenuRepository
    {
        Task<IEnumerable<Candy>> GetAllProducts();
        
    }
}
