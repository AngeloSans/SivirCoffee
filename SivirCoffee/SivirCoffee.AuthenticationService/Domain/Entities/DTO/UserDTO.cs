namespace SivirCoffee.AuthenticationService.Entities.DTO
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public List<string> Roles { get; set; }
    }
}
