using RestaurantReservation.Application.Models;
using RestaurantReservation.Domain.Common;

namespace RestaurantReservation.Application.Services.IServices
{
    public interface ICustomerService
    {
        Task<CustomerDTO?> CreateCustomerAsync(CustomerDTO dto);
        Task DeleteCustomerAsync(int entityId);
        Task<(IEnumerable<CustomerDTO>, PaginationMetadata)> RetrieveCustomersAsync(int pageNumber, int pageSize);
        Task<CustomerDTO?> RetrieveCustomerByIdAsync(int id);
        Task<CustomerDTO?> UpdateCustomerAsync(int id, CustomerDTO dto);
        Task<IEnumerable<CustomerDTO>> FindCustomersByPartySizeAsync(int partySize, int pageNumber, int pageSize);
    }
}