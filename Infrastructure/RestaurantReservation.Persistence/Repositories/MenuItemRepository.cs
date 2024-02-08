using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Repositories.IRepositories;

namespace RestaurantReservation.Domain.Repositories
{
    internal class MenuItemRepository : EntityRepository<MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository(RestaurantReservationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
