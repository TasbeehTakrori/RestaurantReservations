using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories.IRepositories;

namespace RestaurantReservation.Db.Repositories
{
    internal class OrderItemRepository : EntityRepository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(RestaurantReservationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
