using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Application.Contracts.IRepository;

namespace RestaurantReservation.Persistence.Repositories
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
