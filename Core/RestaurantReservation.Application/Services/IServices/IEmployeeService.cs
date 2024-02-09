using RestaurantReservation.Application.Models;

namespace RestaurantReservation.Application.Services.IServices
{
    public interface IEmployeeService 
    {
        Task<IEnumerable<EmployeesWithRestaurantDetailsDTO>?> ListEmployeesWithRestaurantDetailsAsync();
        Task<IEnumerable<EmployeeDTO>> ListManagersAsync();
    }
}