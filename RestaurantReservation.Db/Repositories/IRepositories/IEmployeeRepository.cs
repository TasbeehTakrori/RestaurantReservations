using RestaurantReservation.Db.Entities;

namespace RestaurantReservation.Db.Repositories.IRepositories
{
    public interface IEmployeeRepository : IEntityRepository<Employee>
    {
        Task<List<Employee>> ListManagersAsync();
    }
}
