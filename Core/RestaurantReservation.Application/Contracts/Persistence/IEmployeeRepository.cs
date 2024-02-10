using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.Application.Contracts.Persistence
{
    public interface IEmployeeRepository : IEntityRepository<EmployeeDTO>
    {
        Task<IEnumerable<EmployeeDTO>> ListManagersAsync();
        Task<IEnumerable<EmployeesWithRestaurantDetailsDTO>> ListEmployeesWithRestaurantDetailsAsync();
    }
}
