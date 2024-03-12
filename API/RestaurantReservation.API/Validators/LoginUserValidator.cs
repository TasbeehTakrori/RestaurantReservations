using FluentValidation;
using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.API.Validators
{
    public class LoginUserValidator : AbstractValidator<LoginUserDTO>
    {
        public LoginUserValidator()
        {
            RuleFor(loginUser => loginUser.Name).NotEmpty()
                .WithMessage("First name is required.");
            RuleFor(employee => employee.Password).NotEmpty()
                .WithMessage("Password is required.");

        }
    }
}
