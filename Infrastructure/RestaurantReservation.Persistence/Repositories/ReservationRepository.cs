using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Repositories.IRepositories;

namespace RestaurantReservation.Domain.Repositories
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

        public async Task<IEnumerable<ReservationsDetails>> RetrieveReservationsDetailsViewAsync()
        {
            return await _dbContext.ReservationsDetails.ToListAsync();
        }
    }
}
