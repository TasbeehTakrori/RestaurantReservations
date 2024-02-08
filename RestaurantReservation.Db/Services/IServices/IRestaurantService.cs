using FluentResults;

namespace RestaurantReservation.Domain.Services.IServices
{
    public interface IRestaurantService
    {
        Task<(decimal?, Result)> CalculateTotalRevenueAsync(int restaurantId);
    }
}