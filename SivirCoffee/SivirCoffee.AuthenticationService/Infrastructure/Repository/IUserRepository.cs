using SivirCoffee.AuthenticationService.Entities;


namespace SivirCoffee.AuthenticationService.Infrastructure.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUserAsync();
        Task<User> GetByIdAsync(Guid id);
        Task<User> GetByUserNameAsync(string name);
        Task<User> AddAsync(User user);
        Task DeleteByIdAsync(Guid id);
    }
}
