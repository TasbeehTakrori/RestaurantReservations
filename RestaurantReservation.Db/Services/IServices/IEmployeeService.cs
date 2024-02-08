using FluentResults;
using RestaurantReservation.Domain.DTOs;
using RestaurantReservation.Domain.DTOs.RestaurantReservation.Db.Entities;

namespace RestaurantReservation.Domain.Services.IServices
{
    public interface IEmployeeService
    {
        Task<(IEnumerable<EmployeesWithRestaurantDetailsDTO>?, Result)> ListEmployeesWithRestaurantDetailsAsync();
        Task<(IEnumerable<EmployeeDTO>?, Result)> ListManagersAsync();
    }
}