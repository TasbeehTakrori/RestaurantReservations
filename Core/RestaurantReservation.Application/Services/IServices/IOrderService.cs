using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Domain.Common;

namespace RestaurantReservation.Application.Services.IServices
{
    public interface IOrderService
    {
        Task<OrderDTO?> CreateOrderAsync(OrderDTO dto);
        Task DeleteOrderAsync(int id);
        Task<(IEnumerable<OrderDTO>, PaginationMetadata)> RetrieveOrdersAsync(int pageNumber, int pageSize);
        Task<OrderDTO?> RetrieveOrderByIdAsync(int id);
        Task UpdateOrderAsync(int id, OrderDTO dto);
        Task<decimal> CalculateAverageOrderAmountAsync(int employeeId);
        Task<IEnumerable<MenuItemDTO>> GetOrderedMenuItemsAsync(int reservationId);
        Task<IEnumerable<OrderWithMenuItemsDTO>> GetOrdersAndMenuItemsAsync(int reservationId);
    }
}