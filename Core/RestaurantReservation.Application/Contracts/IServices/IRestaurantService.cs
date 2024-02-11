using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.Application.Contracts.IServices
{
    public interface IRestaurantService
    {
        Task<decimal?> CalculateTotalRevenueAsync(int restaurantId);
    }
}