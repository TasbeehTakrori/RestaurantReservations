using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.Application.Contracts.IRepository
{
    public interface IRestaurantRepository : IEntityRepository<RestaurantDTO>
    {
        Task<decimal> CalculateTotalRevenue(int restaurantId);
    }
}
