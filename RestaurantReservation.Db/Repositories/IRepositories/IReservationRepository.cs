using RestaurantReservation.Db.Entities;

namespace RestaurantReservation.Db.Repositories.IRepositories
{
    public interface IReservationRepository : IEntityRepository<Reservation>
    {
        Task<IEnumerable<Reservation>?> GetReservationsByCustomerAsync(int customerId);
    }
}
