using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.Application.Services.IServices
{
    public interface IOrderService
    {
        Task<decimal> CalculateAverageOrderAmountAsync(int employeeId);
        Task<IEnumerable<MenuItemDTO>> ListOrderedMenuItemsAsync(int reservationId);
        Task<IEnumerable<OrderWithMenuItemDTO>?> ListOrdersAndMenuItemsAsync(int reservationId);
    }
}