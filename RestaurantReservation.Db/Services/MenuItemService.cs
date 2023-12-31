using AutoMapper;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories.IRepositories;

namespace RestaurantReservation.Db.Services
{
    internal class MenuItemService : EntityService<MenuItem, MenuItemDTO, IMenuItemRepository>
    {
        public MenuItemService(IMenuItemRepository entityRepository, IMapper mapper) : base(entityRepository, mapper)
        {
        }
    }
}
