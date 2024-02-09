using RestaurantReservation.Application.Models;

namespace RestaurantReservation.Application.Contracts.Persistence
{
    public interface ITableRepository : IEntityRepository<TableDTO>
    {
    }
}
