using FluentValidation;
using RestaurantReservation.API.DTOs;

namespace RestaurantReservation.API.Validators
{
    public class LoginUserValidator : AbstractValidator<LoginUserDTO>
    {
        public LoginUserValidator()
        {
            RuleFor(loginUser => loginUser.Name).NotEmpty()
                .WithMessage("First name is required.");
            RuleFor(employee => employee.Password).NotEmpty()
                .WithMessage("Password name is required.")
                .MinimumLength(6)
                .WithMessage("Password must be at least 6 characters long.");
        }
    }
}
