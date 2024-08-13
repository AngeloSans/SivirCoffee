using Microsoft.AspNetCore.Mvc;
using SivirCoffee.AuthenticationService.Entities;
using SivirCoffee.AuthenticationService.Entities.DTO;
using SivirCoffee.AuthenticationService.Infrastructure.Repository;
using SivirCoffee.AuthenticationService.Service;
using System;
using System.Threading.Tasks;

namespace SivirCoffee.AuthenticationService.Application.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly IUserRepository _userRepository;

        public AuthenticationController(UserService userService, IUserRepository userRepository)
        {
            _userService = userService;
            _userRepository = userRepository;
        }

        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userRepository.GetAllUserAsync();
            if (users == null)
            {
                return NotFound("No users found.");
            }
            return Ok(users);
        }

        [HttpPost("CreateUser", Name = "CreateUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateUser([FromQuery] string userName, [FromQuery] string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                return BadRequest("Invalid user data.");
            }

            var userDTO = new UserDTO
            {
                Name = userName,
                Password = password
            };

            var user = await _userService.CreateAsync(userDTO);
            if (user == null)
            {
                return BadRequest("Failed to create user.");
            }

            return Ok("User created successfully.");
        }


        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromQuery] string userName, [FromQuery] string password)
        {
            var token = await _userService.LoginAsync(userName, password);
            if (token == null)
            {
                return Unauthorized("Invalid username or password.");
            }

            return Ok(new { Token = token });
        }

        [HttpDelete("DeleteUser/{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            await _userRepository.DeleteByIdAsync(id);
            return Ok("User deleted successfully.");
        }
    }

    public class LoginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
