using FluentResults;
using RestaurantReservation.Domain.DTOs;

namespace RestaurantReservation.Domain.Services.IServices
{
    public interface IReservationService
    {
        Task<(IEnumerable<ReservationDTO>?, Result)> GetReservationsByCustomerAsync(int customerId);
        Task<(IEnumerable<ReservationsDetailsViewDTO>?, Result)> ListReservationsDetailsViewAsync();
    }
}