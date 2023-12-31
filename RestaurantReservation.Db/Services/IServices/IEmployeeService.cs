using FluentResults;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.DTOs.RestaurantReservation.Db.Entities;

namespace RestaurantReservation.Db.Services.IServices
{
    public interface IEmployeeService
    {
        Task<(IEnumerable<EmployeesWithRestaurantDetailsViewDTO>?, Result)> ListEmployeesWithRestaurantDetailsViewAsync();
        Task<(IEnumerable<EmployeeDTO>?, Result)> ListManagersAsync();
    }
}