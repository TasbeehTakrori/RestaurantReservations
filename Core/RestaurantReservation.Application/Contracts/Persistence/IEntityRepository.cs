using RestaurantReservation.Domain.Common;

namespace RestaurantReservation.Application.Contracts.Persistence
{
    public interface IEntityRepository<TDTO> where TDTO : class
    {
        Task<TDTO> CreateAsync(TDTO dto);
        Task DeleteAsync(int id);
        Task<(IEnumerable<TDTO>, PaginationMetadata)> RetrieveAllAsync(int pageNumber, int pageSize);
        Task<TDTO?> RetrieveByIdAsync(int id);
        Task<TDTO> UpdateAsync(TDTO dto);
    }
}