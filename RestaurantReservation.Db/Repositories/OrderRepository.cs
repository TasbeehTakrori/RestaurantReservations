using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories.IRepositories;

namespace RestaurantReservation.Db.Repositories
{
    public class OrderRepository : EntityRepository<Order>, IOrderRepository
    {

        public OrderRepository(RestaurantReservationDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<IEnumerable<Order>?> ListOrdersAndMenuItems(int reservationId)
        {
            return await _dbContext.Orders.AsNoTracking()
                .Where(order => order.ReservationId == reservationId)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.MenuItem)
                .AsSplitQuery()
                .ToListAsync();
        }
    }
}
