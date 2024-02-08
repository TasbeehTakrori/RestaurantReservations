using AutoMapper;
using RestaurantReservation.Domain.DTOs;
using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Repositories.IRepositories;

namespace RestaurantReservation.Domain.Services
{
    internal class OrderItemService : EntityService<OrderItem, OrderItemDTO, IOrderItemRepository>
    {
        public OrderItemService(IOrderItemRepository entityRepository, IMapper mapper) : base(entityRepository, mapper)
        {
        }
    }
}
