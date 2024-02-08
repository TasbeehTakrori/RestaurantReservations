using AutoMapper;
using FluentResults;
using RestaurantReservation.Domain.Models;
using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Repositories.IRepositories;
using RestaurantReservation.Domain.Services.IServices;

namespace RestaurantReservation.Domain.Services
{
    public class RestaurantService : EntityService<Restaurant, RestaurantDTO, IRestaurantRepository>, IRestaurantService
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
