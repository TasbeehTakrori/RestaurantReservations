using RestaurantReservation.Application.Models;

namespace RestaurantReservation.Application.Contracts.Persistence
{
    public interface IMenuItemRepository : IEntityRepository<MenuItemDTO>
    {
    }
}
