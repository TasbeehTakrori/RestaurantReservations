using FluentValidation;
using RestaurantReservation.API.DTOs;

namespace RestaurantReservation.API.Validators
{
    public class ReservationValidator : AbstractValidator<ReservationRequestDTO>
    {
        public ReservationValidator()
        {
            RuleFor(dto => dto.ReservationDate).NotEmpty()
                .WithMessage("Reservation date is required.");
            RuleFor(dto => dto.PartySize).GreaterThan(0)
                .WithMessage("Party size must be greater than 0.");
            RuleFor(dto => dto.CustomerId).NotEmpty()
                .WithMessage("Customer ID is required.");
            RuleFor(dto => dto.TableId).NotEmpty()
                .WithMessage("Table ID is required.");
            RuleFor(dto => dto.RestaurantId).NotEmpty()
                .WithMessage("Restaurant ID is required.");
        }
    }
}
