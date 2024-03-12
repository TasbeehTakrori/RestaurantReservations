using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.Application.Contracts.IService;
using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.API.Controllers
{
    /// <summary>
    /// API Controller for handling user authentication.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IValidator<LoginUserDTO> _loginUserValidator;
        private readonly ILoginService _loginService;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        /// <param name="loginUserValidator">The validator for the login user DTO.</param>
        /// <param name="loginService">The login service to handle user authentication.</param>
        public LoginController(
            IValidator<LoginUserDTO> loginUserValidator, ILoginService loginService)
        {
            _loginUserValidator = loginUserValidator;
            _loginService = loginService;
        }

        /// <summary>
        /// Endpoint for user login.
        /// </summary>
        /// <param name="loginUser">The login user data.</param>
        /// <returns>OK with a JWT token if login is successful, Unauthorized otherwise.</returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
