using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using SivirCoffee.AuthenticationService.Entities;
using SivirCoffee.AuthenticationService.Infrastructure.Repository;
using SivirCoffee.AuthenticationService.Service;

namespace SivirCoffee.AuthenticationService.Application.Controllers;
[Route("Authentication/[controller]")]
[ApiController]
public class AuthenticationController : Controller
{
    private readonly UserService _userService;
    private readonly IUserRepository _userRepository;

    public AuthenticationController(UserService userService, IUserRepository userRepository)
    {
        _userService = userService;
        _userRepository = userRepository;
    }
    
    

    [HttpGet("GetAllUsers")]
    public async Task<IActionResult> GetAllUser()
    {
        var user = await _userRepository.GetAllUserAsync();
        return Ok (user);
    }

    [HttpPost("Create")]
    public async Task<IActionResult> SignUp([FromBody] User user)
    {
        if (user == null)
        {
            return BadRequest("Invalid");
        }
        await _userRepository.AddAsync(user);
        return Ok("user created");
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var user = await _userRepository.GetByUserNameAsync(request.UserName);
        if (user == null || user.Password != request.Password)
        {
            return Unauthorized("Invalid username or password");
        }

        var token = _userService.Authenticate(request.UserName, request.Password);
        return Ok(new { Token = token });
    }

    [HttpDelete("DeleteUserId/{id}")]
    public async Task<IActionResult> DeleteUser(Guid id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        if (user == null)
        {
            return NotFound();
        }

        await _userRepository.DeleteByIdAsync(id);
        return Ok("UserDeleted");
    }
}

public class LoginRequest
{
    public string UserName { get; set; }
    public string Password { get; set; }
}