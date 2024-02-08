using RestaurantReservation.Domain.Models;
using FluentResults;

namespace RestaurantReservation.Domain.Services.IServices
{
    public interface IEmployeeService
    {
        Task<(IEnumerable<EmployeesWithRestaurantDetailsDTO>?, Result)> ListEmployeesWithRestaurantDetailsAsync();
        Task<(IEnumerable<EmployeeDTO>?, Result)> ListManagersAsync();
    }
}