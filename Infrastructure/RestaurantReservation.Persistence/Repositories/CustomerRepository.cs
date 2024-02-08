using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Repositories.IRepositories;

namespace RestaurantReservation.Domain.Repositories
{
    public class CustomerRepository : EntityRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(RestaurantReservationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Customer>> FindCustomersByPartySizeAsync(int partySize)
        {
            var partySizeInt = partySize;

            return await _dbContext.Customers
                .FromSqlInterpolated($"sp_FindCustomersByPartySize {partySizeInt}")
                .ToListAsync();
        }
    }
}
