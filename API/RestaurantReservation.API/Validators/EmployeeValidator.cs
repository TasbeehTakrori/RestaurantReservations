using FluentValidation;
using RestaurantReservation.API.DTOs;

namespace RestaurantReservation.API.Validators
{
    public class EmployeeValidator : AbstractValidator<EmployeeRequestDTO>
    {
        public EmployeeValidator()
        {
            RuleFor(employee => employee.FirstName).NotEmpty()
                .WithMessage("First name is required.");
            RuleFor(employee => employee.LastName).NotEmpty()
                .WithMessage("Last name is required.");
            RuleFor(employee => employee.Position).NotEmpty()
                .WithMessage("Employee position is required.");
            RuleFor(employee => employee.RestaurantId).GreaterThanOrEqualTo(-1)
                .WithMessage("Restaurant ID must be greater than or equal 0.");
        }
    }
}
