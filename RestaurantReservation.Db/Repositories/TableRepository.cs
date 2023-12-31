using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories.IRepositories;

namespace RestaurantReservation.Db.Repositories
{
    public class TableRepository : EntityRepository<Table>, ITableRepository
    {
        public TableRepository(RestaurantReservationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
