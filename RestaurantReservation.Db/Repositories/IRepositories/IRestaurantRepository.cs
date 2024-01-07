using RestaurantReservation.Db.Entities;

namespace RestaurantReservation.Db.Repositories.IRepositories
{
    public interface IRestaurantRepository : IEntityRepository<Restaurant>
    {
        Task<decimal> CalculateTotalRevenue(int restaurantId);
    }
}
