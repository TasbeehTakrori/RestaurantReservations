using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories.IRepositories;

namespace RestaurantReservation.Db.Repositories
{
    public class RestaurantRepository : EntityRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(RestaurantReservationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<decimal> CalculateTotalRevenue(int restaurantId)
        {
            return await _dbContext.Restaurants
            .Select(_ => _dbContext.CalculateTotalRevenue(restaurantId))
            .FirstOrDefaultAsync();
        }
    }
}
