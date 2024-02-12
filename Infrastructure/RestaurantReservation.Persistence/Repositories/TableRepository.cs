using AutoMapper;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Application.Contracts.IRepository;

namespace RestaurantReservation.Persistence.Repositories
{
    public class TableRepository : EntityRepository<Table, TableDTO>, ITableRepository
    {
        public TableRepository(RestaurantReservationDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }
    }
}
