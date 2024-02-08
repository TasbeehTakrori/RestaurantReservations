using AutoMapper;
using RestaurantReservation.Domain.Models;
using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Repositories.IRepositories;

namespace RestaurantReservation.Domain.Services
{
    internal class MenuItemService : EntityService<MenuItem, MenuItemDTO, IMenuItemRepository>
    {
        public MenuItemService(IMenuItemRepository entityRepository, IMapper mapper) : base(entityRepository, mapper)
        {
        }
    }
}
