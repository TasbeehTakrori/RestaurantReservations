using FluentResults;
using RestaurantReservation.Db.DTOs;

namespace RestaurantReservation.Db.Services.IServices
{
    public interface IReservationService
    {
        Task<(IEnumerable<ReservationDTO>?, Result)> GetReservationsByCustomerAsync(int customerId);
        Task<(IEnumerable<ReservationsDetailsViewDTO>?, Result)> ListReservationsDetailsViewAsync();
    }
}