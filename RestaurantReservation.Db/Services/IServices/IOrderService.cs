using FluentResults;
using RestaurantReservation.Db.DTOs;

namespace RestaurantReservation.Db.Services.IServices
{
    public interface IOrderService
    {
        Task<(decimal, Result)> CalculateAverageOrderAmountAsync(int employeeId);
        Task<(IEnumerable<MenuItemDTO>?, Result)> ListOrderedMenuItemsAsync(int reservationId);
        Task<(IEnumerable<OrderWithMenuItemDTO>?, Result)> ListOrdersAndMenuItemsAsync(int reservationId);
    }
}