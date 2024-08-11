using System.Collections;
using SivirCoffee.ProductService.Domain.Entities;

namespace SivirCoffee.ProductService.Repository
{
    public interface IMenuRepository : IRepository<Candy>, IRepository<Coffee>, IRepository<Condiments>
    {
        Task<IEnumerable<Candy>> GetCandiesAsync();
        Task<IEnumerable<Coffee>> GetCoffiesAsync();
        Task<IEnumerable<Condiments>> GetCondimentsAsync();
        
    }
}
