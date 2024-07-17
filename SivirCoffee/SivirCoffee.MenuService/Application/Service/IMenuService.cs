using SivirCoffee.ProductService.Domain.Entities.DTO;

namespace SivirCoffee.ProductService.Application.Service
{
    public interface IMenuService
    {
        Task<IEnumerable<CandyDTO>> Candies();
        Task<IEnumerable<CoffeeDTO>> Cafes();
        Task<IEnumerable<CondimentsDTO>> Condiments();
        Task AddToMenuAsync(CondimentsDTO condimentsDTO);

        Task RemoverToMenuAsync (CondimentsDTO condimentsDTO);

        Task UpdateToMenuAsync(CandyDTO candyDTO);
    }
}
