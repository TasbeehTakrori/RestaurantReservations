using FluentResults;
using RestaurantReservation.Domain.Models;

namespace RestaurantReservation.Domain.Services.IServices
{
    public interface ICustomerService
    {
        Task<(IEnumerable<CustomerDTO>?, Result)> FindCustomersByPartySizeAsync(int partySize);
    }
}