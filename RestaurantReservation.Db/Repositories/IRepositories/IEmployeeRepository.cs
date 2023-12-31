using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Entities.RestaurantReservation.Db.Entities;

namespace RestaurantReservation.Db.Repositories.IRepositories
{
    public interface IEmployeeRepository : IEntityRepository<Employee>
    {
        Task<IEnumerable<Employee>> ListManagersAsync();
        Task<IEnumerable<EmployeesWithRestaurantDetailsView>> ListEmployeesWithRestaurantDetailsViewAsync();
    }
}
