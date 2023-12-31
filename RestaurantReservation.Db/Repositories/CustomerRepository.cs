using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Enums;
using RestaurantReservation.Db.Repositories.IRepositories;

namespace RestaurantReservation.Db.Repositories
{
    public class CustomerRepository : EntityRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(RestaurantReservationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Customer>> FindCustomersByPartySizeAsync(PartySize partySize)
        {
            var partySizeInt = (int)partySize;

            return await _dbContext.Customers
                .FromSqlInterpolated($"sp_FindCustomersByPartySize {partySizeInt}")
                .ToListAsync();
        }
    }
}
