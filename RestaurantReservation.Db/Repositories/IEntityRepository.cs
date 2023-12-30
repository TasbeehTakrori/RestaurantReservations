namespace RestaurantReservation.Db.Repositories
{
    public interface IEntityRepository<TEntity> where TEntity : class
    {
        Task CreateAsync(TEntity entity);
        Task DeleteAsync(int entityId);
        Task<IEnumerable<TEntity>> RetrieveAll();
        Task<TEntity?> RetrieveById(int entityId);
        Task UpdateAsync(TEntity entity);
    }
}