/*using SivirCoffee.ProductService.Domain.Entities.DTO;
using SivirCoffee.ProductService.Repository;

namespace SivirCoffee.ProductService.Application.Service
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public Task AddToMenuAsync(CondimentsDTO condimentsDTO)
        {
            var condiment = _menuRepository.GetCondimentsAsync();
            if (condiment == null)
            {
                throw new Exception("element is equal to null");
            }

            return _menuRepository.AddCondimentAsync(condimentsDTO);
            
        }

        public Task<IEnumerable<CoffeeDTO>> Cafes()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CandyDTO>> Candies()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CondimentsDTO>> Condiments()
        {
            throw new NotImplementedException();
        }

        public Task RemoverToMenuAsync(CondimentsDTO condimentsDTO)
        {
            throw new NotImplementedException();
        }

        public Task UpdateToMenuAsync(CandyDTO candyDTO)
        {
            throw new NotImplementedException();
        }
    }
}
*/