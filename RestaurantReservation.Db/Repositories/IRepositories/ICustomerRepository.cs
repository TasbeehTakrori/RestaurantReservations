using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Enums;

namespace RestaurantReservation.Db.Repositories.IRepositories
{
    public interface ICustomerRepository : IEntityRepository<Customer>
    {
        Task<List<Customer>> FindCustomersByPartySizeAsync(PartySize partySize);
    }
}
