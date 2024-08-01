using System.Collections;
using SivirCoffee.ProductService.Domain.Entities;

namespace SivirCoffee.ProductService.Repository
{
    public interface IMenuRepository : IRepository<Candy>, IRepository<Coffee>, IRepository<Condiments>
    {
        Task<IEnumerable<Candy>> GetCandies();
        Task<IEnumerable<Coffee>> GetCoffies();
        Task<IEnumerable<Condiments>> GetCondiments();
        
    }
}
