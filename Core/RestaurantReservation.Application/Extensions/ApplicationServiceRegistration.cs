using Microsoft.Extensions.DependencyInjection;
using RestaurantReservation.Application.Contracts.IService;
using RestaurantReservation.Application.Contracts.IServices;
using RestaurantReservation.Application.Services;
using RestaurantReservation.Application.Services.IServices;

namespace RestaurantReservation.Application.Extensions
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<ILoginService, LoginService>();

            return services;
        }
    }
}
