using RestaurantReservation.Domain.Entities;

namespace RestaurantReservation.Domain.Repositories.IRepositories
{
    public interface IRestaurantRepository : IEntityRepository<Restaurant>
    {
        Task<decimal> CalculateTotalRevenue(int restaurantId);
    }
}
