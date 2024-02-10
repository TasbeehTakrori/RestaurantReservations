using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.Application.Contracts.Persistence
{
    public interface ICustomerRepository : IEntityRepository<CustomerDTO>
    {
        Task<IEnumerable<CustomerDTO>> FindCustomersByPartySizeAsync(int partySize, int pageNumber, int pageSize);
    }
}
