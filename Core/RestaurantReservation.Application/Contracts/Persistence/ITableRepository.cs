using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.Application.Contracts.Persistence
{
    public interface ITableRepository : IEntityRepository<TableDTO>
    {
    }
}
