using RestaurantReservation.Domain.Entities;

namespace RestaurantReservation.Domain.Repositories.IRepositories
{
    public interface IEmployeeRepository : IEntityRepository<Employee>
    {
        Task<IEnumerable<Employee>> ListManagersAsync();
        Task<IEnumerable<EmployeesWithRestaurantDetails>> ListEmployeesWithRestaurantDetailsViewAsync();
    }
}
