using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Models;
using RestaurantReservation.Domain.Repositories.IRepositories;
using System.Collections.Generic;

namespace RestaurantReservation.Domain.Repositories
{
    public class ReservationRepository : EntityRepository<Reservation, ReservationDTO>, IReservationRepository
    {
        public ReservationRepository(RestaurantReservationDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public async Task<IEnumerable<ReservationDTO>?> GetReservationsByCustomerAsync(int CustomerId)
        {
            var reservations = await _dbContext.Reservations
                .Where(c => c.CustomerId == CustomerId).ToListAsync();
            return _mapper.Map<IEnumerable<ReservationDTO>>(reservations);
        }

        public async Task<IEnumerable<ReservationsDetails>> RetrieveReservationsDetailsViewAsync()
        {
            var reservations = await _dbContext.ReservationsDetails.ToListAsync();
            return _mapper.Map<IEnumerable<ReservationsDetails>>(reservations);
        }
    }
}
