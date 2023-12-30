using FluentResults;

namespace RestaurantReservation.Db.Services
{
    public interface IEntityService<TDto> where TDto : class
    {
        Task<Result> CreateAsync(TDto dto);
        Task<Result> DeleteAsync(int entityId);
        Task<(IEnumerable<TDto>?, Result)> RetrieveAll();
        Task<(TDto?, Result)> RetrieveById(int entityId);
        Task<Result> UpdateAsync(TDto dto);
    }
}