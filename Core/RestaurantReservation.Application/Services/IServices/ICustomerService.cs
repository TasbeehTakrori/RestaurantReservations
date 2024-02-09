using RestaurantReservation.Application.Models;

namespace RestaurantReservation.Application.Services.IServices
{
    public interface ICustomerService
    {
        Task<CustomerDTO?> CreateCustomerAsync(CustomerDTO dto);
        Task DeleteCustomerAsync(int entityId);
        Task<IEnumerable<CustomerDTO>> RetrieveCustomersAsync(int pageNumber, int pageSize);
        Task<CustomerDTO?> RetrieveCustomerByIdAsync(int id);
        Task<CustomerDTO?> UpdateCustomerAsync(CustomerDTO dto);
        Task<IEnumerable<CustomerDTO>> FindCustomersByPartySizeAsync(int partySize, int pageNumber, int pageSize);
    }
}