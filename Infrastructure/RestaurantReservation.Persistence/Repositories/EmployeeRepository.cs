using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Application.Contracts.IRepository;
using RestaurantReservation.Domain.Enums;
using RestaurantReservation.Domain.Common;

namespace RestaurantReservation.Persistence.Repositories
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

        public async Task<(IEnumerable<EmployeeDTO>, PaginationMetadata)> RetrieveAllAsync(
            int pageNumber, int pageSize, EmployeePosition position)
        {
            var entities = await _dbContext.Employees.Where(e => e.Position == position)
                     .Skip((pageNumber - 1) * pageSize)
                     .Take(pageSize)
                     .ToListAsync();

            var totalItemCount = await _dbContext.Employees.CountAsync();

            var paginationMetadata = new PaginationMetadata(
                totalItemCount, pageSize, pageNumber);

            return (_mapper.Map<IEnumerable<EmployeeDTO>>(entities), paginationMetadata);
        }
    }
}
