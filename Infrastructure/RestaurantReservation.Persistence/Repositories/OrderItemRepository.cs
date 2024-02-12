using AutoMapper;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Application.Contracts.IRepository;

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
