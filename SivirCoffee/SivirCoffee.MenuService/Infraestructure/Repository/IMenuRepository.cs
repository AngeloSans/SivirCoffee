using System.Collections;
using SivirCoffee.ProductService.Domain.Entities;

namespace SivirCoffee.ProductService.Repository
{
    public interface IMenuRepository
    {
        Task<IEnumerable<Candy>> GetCandiesAsync();
        Task<IEnumerable<Coffee>> GetCoffeesAsync();
        Task<IEnumerable<Condiments>> GetCondimentsAsync();
        
        Task AddCandyAsync(Candy candy);
        Task AddCoffeeAsync(Coffee coffee);
        Task AddCondimentAsync(Condiments condiment);

        Task UpdateCandyAsync(Candy candy);
        Task UpdateCoffeeAsync(Coffee coffee);
        Task UpdateCondimentAsync(Condiments condiment);

        Task DeleteMenuByIdAsync(Guid id);
    }
}
