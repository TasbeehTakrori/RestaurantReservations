using RestaurantReservation.Db.Entities;

namespace RestaurantReservation.Db.Repositories.IRepositories
{
    public interface IOrderRepository : IEntityRepository<Order>
    {
        Task<IEnumerable<Order>?> ListOrdersAndMenuItems(int reservationId);
    }
}
