using FluentValidation;
using RestaurantReservation.API.DTOs;
using RestaurantReservation.Domain.Constants;

namespace RestaurantReservation.API.Validators
{
    public class PaginationInfoValidator : AbstractValidator<PaginationInfo>
    {
        public PaginationInfoValidator()
        {
            RuleFor(paginationInfo => paginationInfo.PageSize)
                .LessThan(PaginationConstants.MaxPageSize)
                .GreaterThan(PaginationConstants.MinPageSize)
                .WithMessage($"Page size should be between {PaginationConstants.MinPageSize} and {PaginationConstants.MaxPageSize}.");
        }
    }
}
