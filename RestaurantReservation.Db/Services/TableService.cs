using AutoMapper;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories.IRepositories;

namespace RestaurantReservation.Db.Services
{
    internal class TableService : EntityService<Table, TableDTO, ITableRepository>
    {
        public TableService(ITableRepository entityRepository, IMapper mapper) : base(entityRepository, mapper)
        {
        }
    }
}
