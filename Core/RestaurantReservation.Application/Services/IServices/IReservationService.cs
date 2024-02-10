using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.Application.Services.IServices
{
    public interface IReservationService
    {
        Task<IEnumerable<ReservationDTO>> GetReservationsByCustomerAsync(int customerId);
        Task<IEnumerable<ReservationsDetailsViewDTO>?> ListReservationsDetailsViewAsync();
    }
}