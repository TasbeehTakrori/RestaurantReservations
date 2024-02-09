using RestaurantReservation.Application.Models;

namespace RestaurantReservation.Application.Services.IServices
{
    public interface IReservationService
    {
        Task<IEnumerable<ReservationDTO>> GetReservationsByCustomerAsync(int customerId);
        Task<IEnumerable<ReservationsDetailsViewDTO>?> ListReservationsDetailsViewAsync();
    }
}