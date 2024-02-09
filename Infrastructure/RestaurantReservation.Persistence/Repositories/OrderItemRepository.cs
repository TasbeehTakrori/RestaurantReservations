using AutoMapper;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.Models;
using RestaurantReservation.Application.Contracts.Persistence;

namespace RestaurantReservation.Persistence.Repositories
{
    internal class OrderItemRepository : EntityRepository<OrderItem, OrderItemDTO>, IOrderItemRepository
    {
        public OrderItemRepository(RestaurantReservationDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }
    }
}
