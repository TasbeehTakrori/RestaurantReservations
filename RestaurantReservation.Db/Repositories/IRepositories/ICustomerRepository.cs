using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Enums;

namespace RestaurantReservation.Domain.Repositories.IRepositories
{
    public interface ICustomerRepository : IEntityRepository<Customer>
    {
        Task<List<Customer>> FindCustomersByPartySizeAsync(PartySize partySize);
    }
}
