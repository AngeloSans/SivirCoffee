using SivirCoffee.AuthenticationService.Entities;
using SivirCoffee.AuthenticationService.Entities.DTO;

namespace SivirCoffee.AuthenticationService.Application.Service
{
    public interface IUserService
    {
        Task<User> CreateAsync(UserDTO userDTO);
        Task<String> LoginAsync(String UserName, String Password);


    }
}
