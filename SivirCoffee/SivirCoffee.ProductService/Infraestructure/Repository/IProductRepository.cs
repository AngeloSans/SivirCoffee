using SivirCoffee.ProductService.Entities;

namespace SivirCoffee.ProductService.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
    }
}
