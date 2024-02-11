using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.API.DTOs;
using RestaurantReservation.Application.Contracts.IServices;
using RestaurantReservation.Domain.Entities;

namespace RestaurantReservation.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly List<User> _userRepository = new List<User>()
        {
            new User {Name = "Tasbeeh", Password = "654321"},
            new User {Name = "Israa", Password = "123456"},
            new User {Name = "Danya", Password = "123456"},
            new User {Name = "Ayah", Password = "123456"}
        };

        public LoginController(
            IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] LoginUserDto loginUser)
        {
            var user = _userRepository.FirstOrDefault(u => u.Name == loginUser.Name && u.Password == loginUser.Password);
            if (user == null)
            {
                return Unauthorized();
            }

            var token = _authenticationService.GenerateJwtToken(user);
            return Ok(new { token });
        }
    }
}
