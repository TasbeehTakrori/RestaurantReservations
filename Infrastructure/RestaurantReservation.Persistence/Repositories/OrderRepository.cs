using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Application.Contracts.IRepository;

namespace RestaurantReservation.Persistence.Repositories
{
    public class OrderRepository : EntityRepository<Order, OrderDTO>, IOrderRepository
    {

        public OrderRepository(RestaurantReservationDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public async Task<decimal> CalculateAverageOrderAmountAsync(int employeeId)
        {
            var orderCount = await _dbContext.Orders
                .Where(order => order.EmployeeId == employeeId)
                .CountAsync();

            if (orderCount == 0)
                return 0;

            var totalAmount = await _dbContext.Orders
                .Where(order => order.EmployeeId == employeeId)
                .SelectMany(order => order.OrderItems)
                .SumAsync(orderItem => orderItem.MenuItem.Price * orderItem.Quantity);

            var averageAmount = totalAmount / orderCount;

            return averageAmount;
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
