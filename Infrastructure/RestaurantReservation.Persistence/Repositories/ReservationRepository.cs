using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Application.Contracts.Persistence;

namespace RestaurantReservation.Persistence.Repositories
{
    public class ReservationRepository : EntityRepository<Reservation, ReservationDTO>, IReservationRepository
    {
        public ReservationRepository(RestaurantReservationDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public async Task<IEnumerable<ReservationDTO>> GetReservationsByCustomerAsync(int CustomerId)
        {
            var reservations = await _dbContext.Reservations
                .Where(c => c.CustomerId == CustomerId).ToListAsync();
            return _mapper.Map<IEnumerable<ReservationDTO>>(reservations);
        }

        public async Task<IEnumerable<ReservationsDetailsDTO>> RetrieveReservationsDetailsAsync()
        {
            var reservations = await _dbContext.ReservationsDetails.ToListAsync();
            return _mapper.Map<IEnumerable<ReservationsDetailsDTO>>(reservations);
        }
    }
}
