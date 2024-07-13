using SivirCoffee.AuthenticationService.Infrastructure.Repository;

namespace SivirCoffee.AuthenticationService.Service
{
    public class UserService
    {
        private readonly JwtService _jwtService;
        private readonly IUserRepository _userRepository;

        public UserService(JwtService jwtService, UserRepository userRepository)
        {
            _jwtService = jwtService;
            _userRepository = userRepository;
        }

        public string Authenticate(string userName, string password)
        {
            
            return _jwtService.GenerateToken(userName);
        }
    }
}
