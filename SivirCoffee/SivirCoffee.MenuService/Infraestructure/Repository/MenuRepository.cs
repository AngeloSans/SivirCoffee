using Microsoft.EntityFrameworkCore;
using SivirCoffee.ProductService.Domain.Entities;
using SivirCoffee.ProductService.Infrastructure;

namespace SivirCoffee.ProductService.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly MenuServiceDBcontext _dbContext;

        public MenuRepository(MenuServiceDBcontext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Candy>> GetCandiesAsync()
        {
            return await _dbContext.Candies.ToListAsync();
        }

        public async Task<IEnumerable<Coffee>> GetCoffeesAsync()
        {
            return await _dbContext.Coffees.ToListAsync();
        }

        public async Task<IEnumerable<Condiments>> GetCondimentsAsync()
        {
            return await _dbContext.Condiments.ToListAsync();
        }

        public async Task AddCandyAsync(Candy candy)
        {
            await _dbContext.Candies.AddAsync(candy);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddCoffeeAsync(Coffee coffee)
        {
            await _dbContext.Coffees.AddAsync(coffee);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddCondimentAsync(Condiments condiment)
        {
            await _dbContext.Condiments.AddAsync(condiment);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateCandyAsync(Candy candy)
        {
            _dbContext.Candies.Update(candy);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateCoffeeAsync(Coffee coffee)
        {
            _dbContext.Coffees.Update(coffee);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateCondimentAsync(Condiments condiment)
        {
            _dbContext.Condiments.Update(condiment);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteMenuByIdAsync(Guid id)
        {
            var candy = await _dbContext.Candies.FindAsync(id);
            if (candy != null)
            {
                _dbContext.Candies.Remove(candy);
            }
            else
            {
                var coffee = await _dbContext.Coffees.FindAsync(id);
                if (coffee != null)
                {
                    _dbContext.Coffees.Remove(coffee);
                }
                else
                {
                    var condiment = await _dbContext.Condiments.FindAsync(id);
                    if (condiment != null)
                    {
                        _dbContext.Condiments.Remove(condiment);
                    }
                    else
                    {
                        throw new Exception("Menu item not found!");
                    }
                }
            }
            await _dbContext.SaveChangesAsync();
        }

    }
}
