using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.Application.Contracts.IRepository
{
    public interface ITableRepository : IEntityRepository<TableDTO>
    {
    }
}
