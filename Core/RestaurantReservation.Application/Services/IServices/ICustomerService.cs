using FluentResults;
using RestaurantReservation.Domain.Models;

namespace RestaurantReservation.Domain.Services.IServices
{
    public interface ICustomerService
    {
        Task<Result<IEnumerable<CustomerDTO>>> FindCustomersByPartySizeAsync(int partySize);
    }
}