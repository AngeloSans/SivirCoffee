using Microsoft.EntityFrameworkCore;
using SivirCoffee.AuthenticationService.Entities;
using SivirCoffee.AuthenticationService.Infrastructure.Repository;

namespace SivirCoffee.AuthenticationService.Infrastructure.Repository;

public class UserRepository : IUserRepository
{
    private readonly AuthenticationDBContext _authenticationDbContext;

    public UserRepository(AuthenticationDBContext context)
    {
        _authenticationDbContext = context;
    }


    public async Task<IEnumerable<User>> GetAllUserAsync()
    {
        return await _authenticationDbContext.Users.ToListAsync();
    }

    public async Task<User> GetByIdAsync(Guid id)
    {
        return await _authenticationDbContext.Users.FindAsync(id);
    }

    public async Task<User> GetByUserNameAsync(string name)
    {
        return await _authenticationDbContext.Users
            .FirstOrDefaultAsync(u => u.Name == name);
    }

    public async Task<User> AddAsync(User user)
    {
        await _authenticationDbContext.Users.AddAsync(user);
        await _authenticationDbContext.SaveChangesAsync();
        return user;
    }

    public async Task DeleteByIdAsync(Guid id)
    {
        var user = await _authenticationDbContext.Users.FindAsync(id);
        if (user != null)
        {
            _authenticationDbContext.Users.Remove(user);
            await _authenticationDbContext.SaveChangesAsync();
        }
    }

}