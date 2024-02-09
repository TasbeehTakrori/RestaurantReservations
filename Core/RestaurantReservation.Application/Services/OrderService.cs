/*using AutoMapper;
using FluentResults;
using RestaurantReservation.Application.Models;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.Contracts.Persistence;
using RestaurantReservation.Application.Services.IServices;

namespace RestaurantReservation.Application.Services
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
                var menuItemsDTO = new List<MenuItemDTO>();
                orderItems.ForEach(item => menuItemsDTO.Add(_mapper.Map<MenuItemDTO>(item.MenuItem)));

                orderWithMenuItemDTO.Add(
                    new OrderWithMenuItemDTO()
                    {
                        OrderId = order.OrderId,
                        TotalAmount = order.TotalAmount,
                        OrderDate = order.OrderDate,
                        MenuItems = menuItemsDTO,
                    }
                    );
            }
            return orderWithMenuItemDTO;
        }
    }
}
*/