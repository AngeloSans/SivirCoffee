using SivirCoffee.AuthenticationService.Application.Service;
using SivirCoffee.AuthenticationService.Entities;
using SivirCoffee.AuthenticationService.Entities.DTO;
using SivirCoffee.AuthenticationService.Infrastructure.Repository;
using BCrypt.Net;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SivirCoffee.AuthenticationService.Service
{
    public class UserService : IUserService
    {
        private readonly JwtService _jwtService;
        private readonly IUserRepository _userRepository;

        public UserService(JwtService jwtService, IUserRepository userRepository)
        {
            _jwtService = jwtService;
            _userRepository = userRepository;
        }

        public async Task<User> CreateAsync(UserDTO userDTO)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = userDTO.Name,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(userDTO.Password),
                UserRoles = userDTO.Roles.Select(role => new UserRole
                {
                    Id = Guid.NewGuid(),
                    RoleId = Guid.Parse(role)
                }).ToList()
            };

            await _userRepository.AddAsync(user);
            return user;
        }

        public async Task<string> LoginAsync(string userName, string password)
        {
            var user = await _userRepository.GetByUserNameAsync(userName);

            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                return null;
            }

            var roleIdsAsString = user.UserRoles.Select(ur => ur.RoleId.ToString()).ToList();

            return _jwtService.GenerateToken(userName, roleIdsAsString);
        }

    }
}
