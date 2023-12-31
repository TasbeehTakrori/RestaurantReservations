using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories.IRepositories;

namespace RestaurantReservation.Db.Repositories
{
    internal class MenuItemRepository : EntityRepository<MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository(RestaurantReservationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
