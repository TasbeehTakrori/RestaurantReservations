using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Application.Contracts.Persistence;
using RestaurantReservation.Domain.Common;

namespace RestaurantReservation.Persistence.Repositories
{
    public class EntityRepository<TEntity, TDTO> : IEntityRepository<TDTO> where TEntity : class where TDTO : class
    {
        protected readonly RestaurantReservationDbContext _dbContext;
        protected readonly IMapper _mapper;

        public EntityRepository(
            RestaurantReservationDbContext dbContext,
            IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<TDTO> CreateAsync(TDTO dto)
        {
            var entityEntry = await _dbContext.Set<TEntity>().AddAsync(_mapper.Map<TEntity>(dto));
            await _dbContext.SaveChangesAsync();

            var addedEntity = entityEntry.Entity;
            return _mapper.Map<TDTO>(addedEntity);
        }

        public async Task UpdateAsync(TDTO dto)
        {
            _dbContext.Entry(_mapper.Map<TEntity>(dto)).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {

            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            if (entity != null)
            {
                _dbContext.Set<TEntity>().Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<(IEnumerable<TDTO>, PaginationMetadata)> RetrieveAllAsync(int pageNumber, int pageSize)
        {

            var entities = await _dbContext.Set<TEntity>()
                      .Skip((pageNumber - 1) * pageSize)
                      .Take(pageSize)
                      .ToListAsync();

            var totalItemCount = await _dbContext.Set<TEntity>().CountAsync();

            var paginationMetadata = new PaginationMetadata(
                totalItemCount, pageSize, pageNumber);

            return (_mapper.Map<IEnumerable<TDTO>>(entities), paginationMetadata);
        }

        public async Task<TDTO?> RetrieveByIdAsync(int id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            if (entity != null)
            {
                _dbContext.Entry(entity).State = EntityState.Detached;
            }

            return _mapper.Map<TDTO>(entity);
        }
    }
}