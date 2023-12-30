using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories.IRepositories;

namespace RestaurantReservation.Db.Repositories
{
    public class ReservationRepository : EntityRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(RestaurantReservationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Reservation>?> GetReservationsByCustomerAsync(int CustomerId)
        {
            return await _dbContext.Reservations
                .Where(c => c.CustomerId == CustomerId).ToListAsync();
        }
    }
}
