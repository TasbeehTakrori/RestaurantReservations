using AutoMapper;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.Models;
using RestaurantReservation.Application.Contracts.Persistence;

namespace RestaurantReservation.Application.Contracts
{
    public class TableRepository : EntityRepository<Table, TableDTO>, ITableRepository
    {
        public TableRepository(RestaurantReservationDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }
    }
}
