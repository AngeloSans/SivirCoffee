namespace SivirCoffee.ProductService.Repository;

public interface IRepository<T>
{
    Task<IEnumerable<T>> GetAllMenu<T>();

    Task AddToMenu(T entity);

    Task UpdateMenu(T entity);

    Task DeleteMenuById(Guid id);
}