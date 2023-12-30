using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories.IRepositories;

namespace RestaurantReservation.Db.Repositories
{
    internal class CustomerRepository : EntityRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(RestaurantReservationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
