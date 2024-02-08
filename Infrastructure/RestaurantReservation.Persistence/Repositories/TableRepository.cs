using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Repositories.IRepositories;

namespace RestaurantReservation.Domain.Repositories
{
    public class TableRepository : EntityRepository<Table>, ITableRepository
    {
        public TableRepository(RestaurantReservationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
