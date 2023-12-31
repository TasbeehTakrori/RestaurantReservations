using FluentResults;

namespace RestaurantReservation.Db.Services.IServices
{
    public interface IEntityService<TDto> where TDto : class
    {
        Task<Result> CreateAsync(TDto dto);
        Task<Result> DeleteAsync(int entityId);
        Task<(IEnumerable<TDto>?, Result)> RetrieveAllAsync();
        Task<(TDto?, Result)> RetrieveByIdAsync(int entityId);
        Task<Result> UpdateAsync(TDto dto);
    }
}