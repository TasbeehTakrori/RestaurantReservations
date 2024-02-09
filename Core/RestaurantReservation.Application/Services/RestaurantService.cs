/*using AutoMapper;
using FluentResults;
using RestaurantReservation.Application.Models;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.Contracts.Persistence;
using RestaurantReservation.Application.Services.IServices;

namespace RestaurantReservation.Application.Services
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
*/