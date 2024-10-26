using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PiecesOfArt.DTOs;
using PiecesOfArt.Interface;
using PiecesOfArt.Models;

namespace PiecesOfArt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userRepository.GetAll();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] DTO_User userDto)
        {
            var user = new User
            {
                Name = userDto.Name,
                Email = userDto.Email,
                Age = userDto.Age,
                LoyaltyCardId = userDto.LoyaltyCardId
            };
            await _userRepository.Add(user);
            return CreatedAtAction(nameof(GetAllUsers), new { id = user.Id }, user);
        }

        // Additional methods for PUT, DELETE, etc.
    }

}
