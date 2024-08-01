using Microsoft.EntityFrameworkCore;
using SivirCoffee.ProductService.Domain.Entities;
using SivirCoffee.ProductService.Infrastructure;

namespace SivirCoffee.ProductService.Repository;

public class MenuRepository : IMenuRepository
{
    private readonly MenuServiceDBcontext _dBcontext;

    public MenuRepository(MenuServiceDBcontext dBcontext)
    {
        _dBcontext = dBcontext;
    }

    public Task<IEnumerable<Candy>> GetCandies()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Coffee>> GetCoffies()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Condiments>> GetCondiments()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Condiments>> getCondiments()
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<T>> IRepository<Condiments>.GetAllMenu<T>()
    {
        throw new NotImplementedException();
    }

    public Task AddToMenu(Condiments condiments)
    {
        throw new NotImplementedException();
    }

    public Task UpdateMenu(Condiments condiments)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<T>> IRepository<Candy>.GetAllMenu<T>()
    {
        throw new NotImplementedException();
    }

    public Task AddToMenu(Coffee entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateMenu(Coffee entity)
    {
        throw new NotImplementedException();
    }

    public Task AddToMenu(Candy entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateMenu(Candy entity)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<T>> IRepository<Coffee>.GetAllMenu<T>()
    {
        throw new NotImplementedException();
    }

    public Task DeleteMenuById(Guid id)
    {
        throw new NotImplementedException();
    }
}