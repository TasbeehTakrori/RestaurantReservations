using FluentValidation;
using RestaurantReservation.API.DTOs;
using RestaurantReservation.Domain.Constants;

namespace RestaurantReservation.API.Validators
{
    public class CustomerValidator : AbstractValidator<CustomerRequestDTO>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.FirstName).NotEmpty()
                .WithMessage("First name is required.");
            RuleFor(customer => customer.LastName).NotEmpty()
                .WithMessage("Last name is required.");
            RuleFor(customer => customer.Email).NotEmpty()
                .WithMessage("Email is required.")
                .EmailAddress()
                .WithMessage("Email is not in a valid format.");
            RuleFor(customer => customer.PhoneNumber).NotEmpty()
                .WithMessage("Phone number is required.")
                .Matches(RegexPatterns.PhoneRegex)
                .WithMessage("Phone Number is not in a valid format.");
        }
    }
}
