using FluentResults;
using RestaurantReservation.Domain.DTOs;
using RestaurantReservation.Domain.Enums;

namespace RestaurantReservation.Domain.Services.IServices
{
    public interface ICustomerService
    {
        Task<(IEnumerable<CustomerDTO>?, Result)> FindCustomersByPartySizeAsync(PartySize partySize);
    }
}