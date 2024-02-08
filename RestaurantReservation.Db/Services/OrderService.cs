using AutoMapper;
using FluentResults;
using RestaurantReservation.Domain.DTOs;
using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Repositories.IRepositories;
using RestaurantReservation.Domain.Services.IServices;

namespace RestaurantReservation.Domain.Services
{
    public class OrderService : EntityService<Order, OrderDTO, IOrderRepository>, IOrderService
    {
        public OrderService(IOrderRepository entityRepository, IMapper mapper) : base(entityRepository, mapper)
        {
        }

        public async Task<(decimal, Result)> CalculateAverageOrderAmountAsync(int employeeId)
        {
            try
            {
                var avgOrderAmount = await _entityRepository.CalculateAverageOrderAmountAsync(employeeId);
                return (avgOrderAmount, Result.Ok());
            }
            catch (Exception ex)
            {
                return (0, Result.Fail(ex.Message));
            }
        }

        public async Task<(IEnumerable<OrderWithMenuItemDTO>?, Result)> ListOrdersAndMenuItemsAsync(int reservationId)
        {
            try
            {
                var ordersWithOrderItems = await _entityRepository.ListOrdersAndMenuItemsAsync(reservationId);
                var dtos = MapOrderToOrderWithMenuEntityDto(ordersWithOrderItems);
                return (dtos, Result.Ok());
            }
            catch (Exception ex)
            {
                return (null, Result.Fail(ex.Message));
            }
        }

        public async Task<(IEnumerable<MenuItemDTO>?, Result)> ListOrderedMenuItemsAsync(int reservationId)
        {
            try
            {
                var orderedMenuItems = await _entityRepository.ListOrderedMenuItemsAsync(reservationId);
                var dtos = MapEntityToDto<MenuItem, MenuItemDTO>(orderedMenuItems);
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
