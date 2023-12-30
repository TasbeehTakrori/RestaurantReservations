using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories.IRepositories;

namespace RestaurantReservation.Db.Repositories
{
    public class EmployeeRepository : EntityRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RestaurantReservationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Employee>> ListManagersAsync()
        {
            return await _dbContext.Employees.Where(e => e.Position == "Manager").ToListAsync();
        }
    }
}
