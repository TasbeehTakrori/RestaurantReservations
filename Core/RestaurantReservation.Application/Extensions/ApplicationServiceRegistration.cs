using Microsoft.Extensions.DependencyInjection;
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

            return services;
        }
    }
}
