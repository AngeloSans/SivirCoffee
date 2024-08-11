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
        return await _dBcontext.TolistAsync();
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
        return await _dBcontext.Toli
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
        return await _dBcontext.SaveChanges(Candy);
    }

    public Task UpdateMenu(Candy entity)
    {
        var MenuUpdate = await _dBcontext.FindAsync(id);
        if (MenuUpdate == null)
        {
            throw new Exception("menu already exist!");
        }
        return await 
    }

    Task<IEnumerable<T>> IRepository<Coffee>.GetAllMenu<T>()
    {
        throw new NotImplementedException();
    }

    public Task DeleteMenuById(Guid id)
    {
        var MenuId = await _dBcontext.FindAsync(id);
        if (MenuId == null)
        {
            throw new Exception("menu doesnt exist!");
        }

        return await _dBcontext.Remove(MenuId);
    }
}