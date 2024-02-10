using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Application.Contracts.Persistence;
using AutoMapper;

namespace RestaurantReservation.Persistence.Repositories
{
    public class CustomerRepository : EntityRepository<Customer, CustomerDTO>, ICustomerRepository
    {
        public CustomerRepository(RestaurantReservationDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public async Task<IEnumerable<CustomerDTO>> FindCustomersByPartySizeAsync(
            int partySize, int pageNumber, int pageSize)
        {
            var partySizeInt = partySize;

            var customers = await _dbContext.Customers
                .FromSqlInterpolated($"sp_FindCustomersByPartySize {partySizeInt}")
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return _mapper.Map<IEnumerable<CustomerDTO>>(customers);
        }
    }
}
