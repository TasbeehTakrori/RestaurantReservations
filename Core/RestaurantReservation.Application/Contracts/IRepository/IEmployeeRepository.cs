using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Domain.Common;
using RestaurantReservation.Domain.Enums;

namespace RestaurantReservation.Application.Contracts.IRepository
{
    public interface IEmployeeRepository : IEntityRepository<EmployeeDTO>
    {
        Task<(IEnumerable<EmployeeDTO>, PaginationMetadata)> RetrieveAllAsync(
            int pageNumber, int pageSize, EmployeePosition position);
        Task<IEnumerable<EmployeesWithRestaurantDetailsDTO>> ListEmployeesWithRestaurantDetailsAsync();
    }
}
