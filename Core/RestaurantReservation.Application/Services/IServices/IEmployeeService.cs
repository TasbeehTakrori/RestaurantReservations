using FluentResults;
using RestaurantReservation.Domain.Models;
using RestaurantReservation.Domain.Models.RestaurantReservation.Db.Entities;

namespace RestaurantReservation.Domain.Services.IServices
{
    public interface IEmployeeService
    {
        Task<(IEnumerable<EmployeesWithRestaurantDetailsDTO>?, Result)> ListEmployeesWithRestaurantDetailsAsync();
        Task<(IEnumerable<EmployeeDTO>?, Result)> ListManagersAsync();
    }
}