using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Repositories.IRepositories;

namespace RestaurantReservation.Domain.Repositories
{
    public class EmployeeRepository : EntityRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RestaurantReservationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<EmployeesWithRestaurantDetails>> ListEmployeesWithRestaurantDetailsAsync()
        {
            return await _dbContext.EmployeesWithRestaurantDetails.ToListAsync();
        }

        public async Task<IEnumerable<Employee>> ListManagersAsync()
        {
            return await _dbContext.Employees.Where(e => e.Position == "Manager").ToListAsync();
        }
    }
}
