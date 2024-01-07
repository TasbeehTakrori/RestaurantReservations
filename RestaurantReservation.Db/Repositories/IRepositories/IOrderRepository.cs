using RestaurantReservation.Db.Entities;

namespace RestaurantReservation.Db.Repositories.IRepositories
{
    public interface IOrderRepository : IEntityRepository<Order>
    {
        Task<IEnumerable<Order>?> ListOrdersAndMenuItemsAsync(int reservationId);
        Task<IEnumerable<MenuItem>?> ListOrderedMenuItemsAsync(int reservationId);
        Task<decimal> CalculateAverageOrderAmountAsync(int employeeId);
    }
}
