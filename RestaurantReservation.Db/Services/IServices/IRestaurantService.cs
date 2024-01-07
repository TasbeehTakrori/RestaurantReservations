using FluentResults;

namespace RestaurantReservation.Db.Services.IServices
{
    public interface IRestaurantService
    {
        Task<(decimal?, Result)> CalculateTotalRevenueAsync(int restaurantId);
    }
}