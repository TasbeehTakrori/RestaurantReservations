using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Domain.Repositories.IRepositories;

namespace RestaurantReservation.Domain.Repositories
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
            await _dbContext.Set<TEntity>().AddAsync(_mapper.Map<TEntity>(dto));
            await _dbContext.SaveChangesAsync();
            return dto;
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

        public async Task<IEnumerable<TDTO>> RetrieveAllAsync()
        {
            var entities = await _dbContext.Set<TEntity>().ToListAsync();
            return _mapper.Map<IEnumerable<TDTO>>(entities);
        }

        public async Task<TDTO?> RetrieveByIdAsync(int id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            return _mapper.Map<TDTO>(entity);
        }
    }
}
