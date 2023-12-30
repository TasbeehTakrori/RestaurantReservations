using RestaurantReservation.Db.Entities;

namespace RestaurantReservation.Db.Repositories
{
    public interface IEmployeeRepository : IEntityRepository<Employee>
    {
        Task<List<Employee>> ListManagersAsync();
    }
}
