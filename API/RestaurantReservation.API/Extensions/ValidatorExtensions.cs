using FluentValidation;
using RestaurantReservation.API.DTOs;
using RestaurantReservation.API.Validators;

namespace RestaurantReservation.API.Extensions
{
    public static class ValidatorExtensions
    {
        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<CustomerRequestDTO>, CustomerValidator>();
            services.AddScoped<IValidator<PaginationInfo>, PaginationInfoValidator>();
            services.AddScoped<IValidator<EmployeeRequestDTO>, EmployeeValidator>();
            services.AddScoped<IValidator<ReservationRequestDTO>, ReservationValidator>();
            services.AddScoped<IValidator<LoginUserDTO>, LoginUserValidator>();

            return services;
        }
    }
}
