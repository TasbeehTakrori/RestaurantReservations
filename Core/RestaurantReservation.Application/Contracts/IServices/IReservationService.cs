using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Domain.Common;

namespace RestaurantReservation.Application.Contracts.IServices
{
    public interface IReservationService
    {
        Task<ReservationDTO?> CreateReservationAsync(ReservationDTO dto);
        Task DeleteReservationAsync(int id);
        Task<(IEnumerable<ReservationDTO>, PaginationMetadata)> RetrieveReservationAsync(int pageNumber, int pageSize);
        Task<ReservationDTO?> RetrieveReservationByIdAsync(int id);
        Task UpdateReservationAsync(int id, ReservationDTO dto);
        Task<IEnumerable<ReservationDTO>> GetReservationsByCustomerAsync(int id);
        Task<IEnumerable<ReservationsDetailsDTO>> GetReservationsDetailsAsync();
    }
}