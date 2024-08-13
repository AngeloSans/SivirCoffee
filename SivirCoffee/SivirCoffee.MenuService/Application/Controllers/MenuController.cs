using Microsoft.AspNetCore.Mvc;
using SivirCoffee.ProductService.Application.Service;
using SivirCoffee.ProductService.Domain.Entities.DTO;
using System.Threading.Tasks;

namespace SivirCoffee.ProductService.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet("GetAllCandies")]
        public async Task<IActionResult> GetAllCandies()
        {
            var candies = await _menuService.GetCandiesAsync();
            return Ok(candies);
        }

        [HttpGet("GetAllCoffees")]
        public async Task<IActionResult> GetAllCoffees()
        {
            var coffees = await _menuService.GetCoffeeAsync();
            return Ok(coffees);
        }

        [HttpGet("GetAllCondiments")]
        public async Task<IActionResult> GetAllCondiments()
        {
            var condiments = await _menuService.GetCondimentsAsync();
            return Ok(condiments);
        }

        [HttpPost("AddCandy")]
        public async Task<IActionResult> AddCandy([FromBody] CandyDTO candyDto)
        {
            await _menuService.AddCandyAsync(candyDto);
            return CreatedAtAction(nameof(GetAllCandies), new { id = candyDto.Id }, candyDto);
        }

        [HttpPost("AddCoffee")]
        public async Task<IActionResult> AddCoffee([FromBody] CoffeeDTO coffeeDto)
        {
            await _menuService.AddCoffeeAsync(coffeeDto);
            return CreatedAtAction(nameof(GetAllCoffees), new { id = coffeeDto.Id }, coffeeDto);
        }

        [HttpPost("AddCondiment")]
        public async Task<IActionResult> AddCondiment([FromBody] CondimentsDTO condimentsDto)
        {
            await _menuService.AddCondimentsAsync(condimentsDto);
            return CreatedAtAction(nameof(GetAllCondiments), new { id = condimentsDto.Id }, condimentsDto);
        }

        [HttpPut("UpdateCandy/{id}")]
        public async Task<IActionResult> UpdateCandy(Guid id, [FromBody] CandyDTO candyDto)
        {
            if (id != candyDto.Id)
            {
                return BadRequest("Candy ID mismatch.");
            }

            await _menuService.UpdateCandyAsync(candyDto);
            return NoContent();
        }

        [HttpPut("UpdateCoffee/{id}")]
        public async Task<IActionResult> UpdateCoffee(Guid id, [FromBody] CoffeeDTO coffeeDto)
        {
            if (id != coffeeDto.Id)
            {
                return BadRequest("Coffee ID mismatch.");
            }

            await _menuService.UpdateCoffeeAsync(coffeeDto);
            return NoContent();
        }

        [HttpPut("UpdateCondiment/{id}")]
        public async Task<IActionResult> UpdateCondiment(Guid id, [FromBody] CondimentsDTO condimentsDto)
        {
            if (id != condimentsDto.Id)
            {
                return BadRequest("Condiment ID mismatch.");
            }

            await _menuService.UpdateCondimentsAsync(condimentsDto);
            return NoContent();
        }
    }
}
