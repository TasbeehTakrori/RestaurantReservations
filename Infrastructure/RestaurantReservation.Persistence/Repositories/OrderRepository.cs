using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Application.Contracts.Persistence;

namespace RestaurantReservation.Persistence.Repositories
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
                       .ThenInclude(oi => oi.MenuItem)
                       .AsSplitQuery()
                       .ToListAsync();

            return OrderAmountList.Count() > 0 ?
                 OrderAmountList.Select(o => o.TotalAmount).Average() : 0;
        }

        public async Task<IEnumerable<MenuItemDTO>> ListOrderedMenuItemsAsync(int reservationId)
        {
            var menuItems = await _dbContext.Orders.AsNoTracking()
                 .Where(o => o.ReservationId == reservationId)
                 .SelectMany(o => o.OrderItems.Select(oi => oi.MenuItem))
                 .AsSplitQuery()
                 .Distinct()
                 .ToListAsync();

            return _mapper.Map<IEnumerable<MenuItemDTO>>(menuItems);
        }

        public async Task<IEnumerable<OrderWithMenuItemsDTO>> ListOrdersWithMenuItemsAsync(int reservationId)
        {
            var ordersWithMenuItems = await _dbContext.Orders.AsNoTracking()
                .Where(o => o.ReservationId == reservationId)
                .Select(o => new OrderWithMenuItemsDTO
                {
                    OrderId = o.OrderId,
                    OrderDate = o.OrderDate,
                    MenuItems = o.OrderItems.Select(orderItem => new MenuItemDTO
                    {
                        MenuItemId = orderItem.MenuItemId,
                        Description = orderItem.MenuItem.Description,
                        Name = orderItem.MenuItem.Name,
                        Price = orderItem.MenuItem.Price
                    }).Distinct().ToList()
                })
                .AsSplitQuery()
                .ToListAsync();

            return ordersWithMenuItems;
        }
    }
}
