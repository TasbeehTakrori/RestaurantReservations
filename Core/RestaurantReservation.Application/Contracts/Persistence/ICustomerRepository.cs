using RestaurantReservation.Domain.Entities;

namespace RestaurantReservation.Domain.Repositories.IRepositories
{
    public interface ICustomerRepository : IEntityRepository<Customer>
    {
        Task<List<Customer>> FindCustomersByPartySizeAsync(int partySize);
    }
}
