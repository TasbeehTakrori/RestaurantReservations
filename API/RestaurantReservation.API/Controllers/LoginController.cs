using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.Application.Contracts.IService;
using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IValidator<LoginUserDTO> _loginUserValidator;
        private readonly ILoginService _loginService;


        public LoginController(
            IValidator<LoginUserDTO> loginUserValidator, ILoginService loginService)
        {
            _loginUserValidator = loginUserValidator;
            _loginService = loginService;
        }

        [HttpPost]
        public async Task<ActionResult> Login([FromBody] LoginUserDTO loginUser)
        {
            await _loginUserValidator.ValidateAndThrowAsync(loginUser);

            var token = _loginService.Login(loginUser);
            if (token == null)
            {
                return Unauthorized(new { message = "Username or password is incorrect!" });
            }
            return Ok(new { token });
        }
    }
}
