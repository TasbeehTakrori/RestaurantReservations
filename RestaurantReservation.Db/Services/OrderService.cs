using AutoMapper;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories.IRepositories;

namespace RestaurantReservation.Db.Services
{
    public class OrderService : EntityService<Order, OrderDTO, IOrderRepository>
    {
        public OrderService(IOrderRepository entityRepository, IMapper mapper) : base(entityRepository, mapper)
        {
        }

        public async Task<(decimal, Result)> CalculateAverageOrderAmount(int employeeId)
        {
            try
            {
                var avgOrderAmount = await _entityRepository.CalculateAverageOrderAmount(employeeId);
                return (avgOrderAmount, Result.Ok());
            }
            catch (Exception ex)
            {
                return (0, Result.Fail(ex.Message));
            }
        }

        public async Task<(IEnumerable<OrderWithMenuItemDTO>?, Result)> ListOrdersAndMenuItems(int reservationId)
        {
            try
            {
                var ordersWithOrderItems = await _entityRepository.ListOrdersAndMenuItems(reservationId);
                var dtos = MapOrderToOrderWithMenuEntityDto(ordersWithOrderItems);
                return (dtos, Result.Ok());
            }
            catch (Exception ex)
            {
                return (null, Result.Fail(ex.Message));
            }
        }

        public async Task<(IEnumerable<MenuItemDTO>?, Result)> ListOrderedMenuItems(int reservationId)
        {
            try
            {
                var orderedMenuItems = await _entityRepository.ListOrderedMenuItems(reservationId);
                var dtos = MapEntityToDto<MenuItem,MenuItemDTO>(orderedMenuItems);
                return (dtos, Result.Ok());
            }
            catch (Exception ex)
            {
                return (null, Result.Fail(ex.Message));
            }
        }

        private IEnumerable<OrderWithMenuItemDTO> MapOrderToOrderWithMenuEntityDto(IEnumerable<Order> orderWithOrderItems)
        {
            var orderWithMenuItemDTO = new List<OrderWithMenuItemDTO>();
            foreach (var order in orderWithOrderItems)
            {
                var orderItems = order.OrderItems;
                var menuItems = new List<MenuItem>();
                orderItems.ForEach(item => menuItems.Add(item.MenuItem));

                orderWithMenuItemDTO.Add(
                    new OrderWithMenuItemDTO()
                    {
                        OrderId = order.OrderId,
                        TotalAmount = order.TotalAmount,
                        OrderDate = order.OrderDate,
                        MenuItems = menuItems,
                    }
                    );
            }
            return orderWithMenuItemDTO;
        }
    }
}
