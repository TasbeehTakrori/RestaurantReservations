using AutoMapper;
using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Models;
using RestaurantReservation.Domain.Repositories.IRepositories;

namespace RestaurantReservation.Domain.Repositories
{
    public class TableRepository : EntityRepository<Table, TableDTO>, ITableRepository
    {
        public TableRepository(RestaurantReservationDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }
    }
}
