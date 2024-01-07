using FluentResults;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.Enums;

namespace RestaurantReservation.Db.Services.IServices
{
    public interface ICustomerService
    {
        Task<(IEnumerable<CustomerDTO>?, Result)> FindCustomersByPartySizeAsync(PartySize partySize);
    }
}