namespace RestaurantReservation.Db.Repositories.IRepositories
{
    public interface IEntityRepository<TEntity> where TEntity : class
    {
        Task CreateAsync(TEntity entity);
        Task DeleteAsync(int entityId);
        Task<IEnumerable<TEntity>> RetrieveAllAsync();
        Task<TEntity?> RetrieveByIdAsync(int entityId);
        Task UpdateAsync(TEntity entity);
    }
}