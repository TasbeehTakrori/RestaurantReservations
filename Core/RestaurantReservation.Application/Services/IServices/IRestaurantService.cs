using RestaurantReservation.Application.Models;

namespace RestaurantReservation.Application.Services.IServices
{
    public interface IRestaurantService
    {
        Task<decimal?> CalculateTotalRevenueAsync(int restaurantId);
    }
}