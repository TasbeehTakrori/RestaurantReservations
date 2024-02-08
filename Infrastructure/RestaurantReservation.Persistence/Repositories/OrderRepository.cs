using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Repositories.IRepositories;

namespace RestaurantReservation.Domain.Repositories
{
    public class OrderRepository : EntityRepository<Order>, IOrderRepository
    {

        public OrderRepository(RestaurantReservationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<decimal> CalculateAverageOrderAmountAsync(int employeeId)
        {
            var OrderAmountList = await _dbContext.Orders.AsNoTracking()
                       .Where(o => o.EmployeeId == employeeId)
                       .Include(o => o.OrderItems)
                       .ThenInclude(oi=> oi.MenuItem)
                       .AsSplitQuery()
                       .ToListAsync();

            return OrderAmountList.Count() > 0 ?
                 OrderAmountList.Select(o => o.TotalAmount).Average() : 0;
        }

        public async Task<IEnumerable<MenuItem>?> ListOrderedMenuItemsAsync(int reservationId)
        {
            return await _dbContext.Orders.AsNoTracking()
                 .Where(o => o.ReservationId == reservationId)
                 .SelectMany(o => o.OrderItems.Select(oi => oi.MenuItem))
                 .AsSplitQuery()
                 .Distinct()
                 .ToListAsync();
        }

        public async Task<IEnumerable<Order>?> ListOrdersAndMenuItemsAsync(int reservationId)
        {
            return await _dbContext.Orders.AsNoTracking()
                .Where(o => o.ReservationId == reservationId)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.MenuItem)
                .AsSplitQuery()
                .ToListAsync();
        }
    }
}
