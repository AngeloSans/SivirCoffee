using AutoMapper;
using SivirCoffee.ProductService.Domain.Entities;
using SivirCoffee.ProductService.Domain.Entities.DTO;
using SivirCoffee.ProductService.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SivirCoffee.ProductService.Application.Service
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepository;
        private readonly IMapper _mapper;

        public MenuService(IMenuRepository menuRepository, IMapper mapper)
        {
            _menuRepository = menuRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CandyDTO>> GetCandiesAsync()
        {
            var candies = await _menuRepository.GetCandiesAsync();
            return _mapper.Map<IEnumerable<CandyDTO>>(candies);
        }

        public async Task<IEnumerable<CoffeeDTO>> GetCoffeeAsync()
        {
            var coffees = await _menuRepository.GetCoffeesAsync();
            return _mapper.Map<IEnumerable<CoffeeDTO>>(coffees);
        }

        public async Task<IEnumerable<CondimentsDTO>> GetCondimentsAsync()
        {
            var condiments = await _menuRepository.GetCondimentsAsync();
            return _mapper.Map<IEnumerable<CondimentsDTO>>(condiments);
        }

        public async Task AddCandyAsync(CandyDTO candyDto)
        {
            var candy = _mapper.Map<Candy>(candyDto);
            await _menuRepository.AddCandyAsync(candy);
        }

        public async Task AddCoffeeAsync(CoffeeDTO coffeeDto)
        {
            var coffee = _mapper.Map<Coffee>(coffeeDto);
            await _menuRepository.AddCoffeeAsync(coffee);
        }

        public async Task AddCondimentsAsync(CondimentsDTO condimentsDto)
        {
            var condiment = _mapper.Map<Condiments>(condimentsDto);
            await _menuRepository.AddCondimentAsync(condiment);
        }

        public async Task UpdateCandyAsync(CandyDTO candyDto)
        {
            var candy = _mapper.Map<Candy>(candyDto);
            await _menuRepository.UpdateCandyAsync(candy);
        }

        public async Task UpdateCoffeeAsync(CoffeeDTO coffeeDto)
        {
            var coffee = _mapper.Map<Coffee>(coffeeDto);
            await _menuRepository.UpdateCoffeeAsync(coffee);
        }

        public async Task UpdateCondimentsAsync(CondimentsDTO condimentsDto)
        {
            var condiment = _mapper.Map<Condiments>(condimentsDto);
            await _menuRepository.UpdateCondimentAsync(condiment);
        }
    }
}
