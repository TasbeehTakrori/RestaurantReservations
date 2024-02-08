using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Models;
using RestaurantReservation.Domain.Repositories.IRepositories;

namespace RestaurantReservation.Domain.Repositories
{
    public class OrderRepository : EntityRepository<Order, OrderDTO>, IOrderRepository
    {

        public OrderRepository(RestaurantReservationDbContext dbContext, IMapper mapper) 
            : base(dbContext, mapper)
        {
        }

        public async Task<decimal> CalculateAverageOrderAmountAsync(int id)
        {
            var OrderAmountList = await _dbContext.Orders.AsNoTracking()
                       .Where(o => o.EmployeeId == id)
                       .Include(o => o.OrderItems)
                       .ThenInclude(oi=> oi.MenuItem)
                       .AsSplitQuery()
                       .ToListAsync();

            return OrderAmountList.Count() > 0 ?
                 OrderAmountList.Select(o => o.TotalAmount).Average() : 0;
        }

        public async Task<IEnumerable<MenuItemDTO>?> ListOrderedMenuItemsAsync(int reservationId)
        {
            var menuItems = await _dbContext.Orders.AsNoTracking()
                 .Where(o => o.ReservationId == reservationId)
                 .SelectMany(o => o.OrderItems.Select(oi => oi.MenuItem))
                 .AsSplitQuery()
                 .Distinct()
                 .ToListAsync();

            return _mapper.Map<IEnumerable<MenuItemDTO>>(menuItems);
        }

        public async Task<IEnumerable<OrderDTO>?> ListOrdersAndMenuItemsAsync(int reservationId)
        {
            var ordersAndMenuItems = await _dbContext.Orders.AsNoTracking()
                .Where(o => o.ReservationId == reservationId)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.MenuItem)
                .AsSplitQuery()
                .ToListAsync();

            return _mapper.Map<IEnumerable<OrderDTO>>(ordersAndMenuItems);
        }
    }
}
