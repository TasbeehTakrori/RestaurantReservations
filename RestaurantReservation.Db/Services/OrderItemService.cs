using AutoMapper;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories.IRepositories;

namespace RestaurantReservation.Db.Services
{
    internal class OrderItemService : EntityService<OrderItem, OrderItemDTO, IOrderItemRepository>
    {
        public OrderItemService(IOrderItemRepository entityRepository, IMapper mapper) : base(entityRepository, mapper)
        {
        }
    }
}
