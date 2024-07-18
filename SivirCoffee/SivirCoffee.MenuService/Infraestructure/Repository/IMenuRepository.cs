using System.Collections;
using SivirCoffee.ProductService.Domain.Entities;

namespace SivirCoffee.ProductService.Repository
{
    public interface IMenuRepository
    {
        Task<IEnumerable<T>> GetAllMenu<T>();

        Task AddToMenu(T entity);

        Task UpdateMenu(T entity);

        Task DeleteMenuById(Guid id);



    }
}
