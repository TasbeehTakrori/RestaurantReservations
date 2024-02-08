using AutoMapper;
using RestaurantReservation.Domain.DTOs;
using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Repositories.IRepositories;

namespace RestaurantReservation.Domain.Services
{
    internal class TableService : EntityService<Table, TableDTO, ITableRepository>
    {
        public TableService(ITableRepository entityRepository, IMapper mapper) : base(entityRepository, mapper)
        {
        }
    }
}
