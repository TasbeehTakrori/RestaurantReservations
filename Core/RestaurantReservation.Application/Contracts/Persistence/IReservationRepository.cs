using RestaurantReservation.Domain.Entities;

namespace RestaurantReservation.Domain.Repositories.IRepositories
{
    public interface IReservationRepository : IEntityRepository<Reservation>
    {
        Task<IEnumerable<Reservation>?> GetReservationsByCustomerAsync(int customerId);
        Task<IEnumerable<ReservationsDetails>> RetrieveReservationsDetailsViewAsync();
    }
}
