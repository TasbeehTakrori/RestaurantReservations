using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Models;
using RestaurantReservation.Domain.Repositories.IRepositories;

namespace RestaurantReservation.Domain.Repositories
{
    public class EmployeeRepository : EntityRepository<Employee, EmployeeDTO>, IEmployeeRepository
    {
        public EmployeeRepository(RestaurantReservationDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public async Task<IEnumerable<EmployeesWithRestaurantDetailsDTO>> ListEmployeesWithRestaurantDetailsAsync()
        {
            var employeesWithRestaurantDetails = await _dbContext.EmployeesWithRestaurantDetails.ToListAsync();
            return _mapper.Map<IEnumerable<EmployeesWithRestaurantDetailsDTO>>(employeesWithRestaurantDetails);
        }

        public async Task<IEnumerable<EmployeeDTO>> ListManagersAsync()
        {
            var employee = await _dbContext.Employees.Where(e => e.Position == "Manager").ToListAsync();
            return _mapper.Map<IEnumerable<EmployeeDTO>>(employee);
        }
    }
}
