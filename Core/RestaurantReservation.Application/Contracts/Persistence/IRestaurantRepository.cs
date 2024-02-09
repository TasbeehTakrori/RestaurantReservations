using RestaurantReservation.Application.Models;

namespace RestaurantReservation.Application.Contracts.Persistence
{
    public interface IRestaurantRepository : IEntityRepository<RestaurantDTO>
    {
        Task<decimal> CalculateTotalRevenue(int restaurantId);
    }
}
