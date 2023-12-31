using AutoMapper;
using FluentResults;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories.IRepositories;

namespace RestaurantReservation.Db.Services
{
    public class RestaurantService : EntityService<Restaurant, RestaurantDTO, IRestaurantRepository>
    {
        public RestaurantService(IRestaurantRepository entityRepository, IMapper mapper) : base(entityRepository, mapper)
        {
        }
        public async Task<(decimal?, Result)> CalculateTotalRevenueAsync(int restaurantId)
        {
            try
            {
                var totalRevenue = await _entityRepository.CalculateTotalRevenue(restaurantId);
                return (totalRevenue, Result.Ok());
            }
            catch (Exception ex)
            {
                return (null, Result.Fail(ex.Message));
            }
        }
    }
}
