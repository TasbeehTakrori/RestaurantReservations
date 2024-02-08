using FluentResults;
using RestaurantReservation.Domain.Models;
using RestaurantReservation.Domain.Enums;

namespace RestaurantReservation.Domain.Services.IServices
{
    public interface ICustomerService
    {
        Task<(IEnumerable<CustomerDTO>?, Result)> FindCustomersByPartySizeAsync(PartySize partySize);
    }
}