namespace RestaurantReservation.Domain.Repositories.IRepositories
{
    public interface IEntityRepository<TDTO> where TDTO : class
    {
        Task<TDTO> CreateAsync(TDTO dto);
        Task DeleteAsync(int id);
        Task<IEnumerable<TDTO>> RetrieveAllAsync();
        Task<TDTO?> RetrieveByIdAsync(int id);
        Task UpdateAsync(TDTO dto);
    }
}