using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Domain.Common;

namespace RestaurantReservation.Application.Contracts.IServices
{
    public interface ICustomerService
    {
        Task<CustomerDTO?> CreateCustomerAsync(CustomerDTO dto);
        Task DeleteCustomerAsync(int id);
        Task<(IEnumerable<CustomerDTO>, PaginationMetadata)> RetrieveCustomersAsync(int pageNumber, int pageSize);
        Task<CustomerDTO?> RetrieveCustomerByIdAsync(int id);
        Task UpdateCustomerAsync(int id, CustomerDTO dto);
        Task<IEnumerable<CustomerDTO>> FindCustomersByPartySizeAsync(int partySize, int pageNumber, int pageSize);
    }
}