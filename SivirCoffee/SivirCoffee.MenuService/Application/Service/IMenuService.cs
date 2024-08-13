using System.Collections;
using SivirCoffee.ProductService.Domain.Entities;
using SivirCoffee.ProductService.Domain.Entities.DTO;

namespace SivirCoffee.ProductService.Application.Service
{
    public interface IMenuService
    {
        Task<IEnumerable<CandyDTO>> GetCandiesAsync();
        Task<IEnumerable<CoffeeDTO>> GetCoffeeAsync();
        Task<IEnumerable<CondimentsDTO>> GetCondimentsAsync();

        Task AddCandyAsync(CandyDTO candyDto);
        Task AddCoffeeAsync(CoffeeDTO coffeeDto);
        Task AddCondimentsAsync(CondimentsDTO condimentsDto);

        Task UpdateCandyAsync(CandyDTO candyDto);
        Task UpdateCoffeeAsync(CoffeeDTO coffeeDto);
        Task UpdateCondimentsAsync(CondimentsDTO condimentsDto);
    }
}
