using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.Models;
using RestaurantReservation.Application.Contracts.Persistence;

namespace RestaurantReservation.Application.Contracts
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
