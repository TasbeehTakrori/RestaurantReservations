using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.Application.Contracts.Persistence
{
    public interface IMenuItemRepository : IEntityRepository<MenuItemDTO>
    {
    }
}
