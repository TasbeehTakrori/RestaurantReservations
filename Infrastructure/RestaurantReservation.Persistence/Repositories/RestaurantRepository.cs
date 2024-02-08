using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Models;
using RestaurantReservation.Domain.Repositories.IRepositories;

namespace RestaurantReservation.Domain.Repositories
{
    public class RestaurantRepository : EntityRepository<Restaurant, RestaurantDTO>, IRestaurantRepository
    {
        public RestaurantRepository(RestaurantReservationDbContext dbContext, IMapper mapper) 
            : base(dbContext, mapper)
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
