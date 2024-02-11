using FluentValidation;
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
        private readonly IValidator<LoginUserDTO> _loginUserValidator;

        private readonly List<User> _userRepository = new List<User>()
        {
            new User {Name = "Tasbeeh", Password = "654321"},
            new User {Name = "Israa", Password = "123456"},
            new User {Name = "Danya", Password = "123456"},
            new User {Name = "Ayah", Password = "123456"}
        };

        public LoginController(
            IAuthenticationService authenticationService, IValidator<LoginUserDTO> loginUserValidator)
        {
            _authenticationService = authenticationService;
            _loginUserValidator = loginUserValidator;
        }

        [HttpPost]
        public async Task<ActionResult> Login([FromBody] LoginUserDTO loginUser)
        {
            await _loginUserValidator.ValidateAndThrowAsync(loginUser);

            var user = _userRepository.FirstOrDefault(u => u.Name == loginUser.Name && u.Password == loginUser.Password);
            if (user == null)
            {
                return Unauthorized(new { message = "Username or password is incorrect!" });
            }

            var token = _authenticationService.GenerateJwtToken(user);
            return Ok(new { token });
        }
    }
}
