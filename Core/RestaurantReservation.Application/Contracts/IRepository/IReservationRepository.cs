using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.Application.Contracts.IRepository
{
    public interface IReservationRepository : IEntityRepository<ReservationDTO>
    {
        Task<IEnumerable<ReservationDTO>> GetReservationsByCustomerAsync(int customerId);
        Task<IEnumerable<ReservationsDetailsDTO>> RetrieveReservationsDetailsAsync();
    }
}
