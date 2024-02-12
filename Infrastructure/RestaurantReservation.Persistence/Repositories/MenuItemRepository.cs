using AutoMapper;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Application.Contracts.IRepository;

namespace RestaurantReservation.Persistence.Repositories
{
    internal class MenuItemRepository : EntityRepository<MenuItem, MenuItemDTO>, IMenuItemRepository
    {
        public MenuItemRepository(RestaurantReservationDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }
    }
}
