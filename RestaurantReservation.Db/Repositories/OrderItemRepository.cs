using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Repositories.IRepositories;

namespace RestaurantReservation.Domain.Repositories
{
    internal class OrderItemRepository : EntityRepository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(RestaurantReservationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
