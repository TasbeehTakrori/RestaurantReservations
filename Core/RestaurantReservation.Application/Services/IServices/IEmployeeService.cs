using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Domain.Common;

namespace RestaurantReservation.Application.Services.IServices
{
    public interface IEmployeeService
    {
        Task<EmployeeDTO?> CreateEmployeeAsync(EmployeeDTO dto);
        Task DeleteEmployeeAsync(int entityId);
        Task<(IEnumerable<EmployeeDTO>, PaginationMetadata)> RetrieveEmployeesAsync(int pageNumber, int pageSize);
        Task<EmployeeDTO?> RetrieveEmployeeByIdAsync(int id);
        Task UpdateEmployeeAsync(int id, EmployeeDTO dto);
        Task<IEnumerable<EmployeesWithRestaurantDetailsDTO>> ListEmployeesWithRestaurantDetailsAsync();
        Task<IEnumerable<EmployeeDTO>> ListManagersAsync();
    }
}