namespace SivirCoffee.AuthenticationService.Service
{
    public class UserService
    {
        private readonly JwtService _jwtService;

        public UserService(JwtService jwtService)
        {
            _jwtService = jwtService;
        }

        public string Authenticate(string userName, string password)
        {
            
            return _jwtService.GenerateToken(userName);
        }
    }
}
