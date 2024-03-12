using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.Application.Contracts.IService
{
    public interface IRestaurantService
    {
        Task<decimal?> CalculateTotalRevenueAsync(int restaurantId);
    }
}