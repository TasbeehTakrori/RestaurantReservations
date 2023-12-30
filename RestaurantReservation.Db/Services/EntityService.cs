using AutoMapper;
using FluentResults;
using RestaurantReservation.Db.Repositories;

namespace RestaurantReservation.Db.Services
{
    public class EntityService<TEntity, TDto> : IEntityService<TDto> where TEntity : class where TDto : class
    {
        private readonly IEntityRepository<TEntity> _entityRepository;
        private readonly IMapper _mapper;


        public EntityService(IEntityRepository<TEntity> entityRepository, IMapper mapper)
        {
            _entityRepository = entityRepository;
            _mapper = mapper;
        }

        public async Task<Result> CreateAsync(TDto dto)
        {
            try
            {
                var entity = MapDtoToEntity(dto);
                await _entityRepository.CreateAsync(entity);
                return Result.Ok();
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }

        public async Task<Result> UpdateAsync(TDto dto)
        {
            try
            {
                var entity = MapDtoToEntity(dto);
                await _entityRepository.UpdateAsync(entity);
                return Result.Ok();
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }

        public async Task<Result> DeleteAsync(int entityId)
        {
            try
            {
                await _entityRepository.DeleteAsync(entityId);
                return Result.Ok();
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }

        public async Task<(IEnumerable<TDto>?, Result)> RetrieveAll()
        {
            try
            {
                var entities = await _entityRepository.RetrieveAll();
                var dtos = MapEntityToDto(entities);
                return (dtos, Result.Ok());
            }
            catch (Exception ex)
            {
                return (null, Result.Fail(ex.Message));
            }
        }

        public async Task<(TDto?, Result)> RetrieveById(int entityId)
        {
            try
            {
                var entity = await _entityRepository.RetrieveById(entityId);
                var dto = MapEntityToDto(entity);
                return (dto, Result.Ok());
            }
            catch (Exception ex)
            {
                return (null, Result.Fail(ex.Message));
            }
        }

        private TEntity MapDtoToEntity(TDto dto)
        {
            return _mapper.Map<TDto, TEntity>(dto);
        }

        private TDto MapEntityToDto(TEntity entity)
        {
            return _mapper.Map<TEntity, TDto>(entity);
        }

        private IEnumerable<TDto> MapEntityToDto(IEnumerable<TEntity> entities)
        {
            return _mapper.Map<IEnumerable<TEntity>, IEnumerable<TDto>>(entities);
        }

        private IEnumerable<TEntity> MapDtoToEntity(IEnumerable<TDto> dtos)
        {
            return _mapper.Map<IEnumerable<TDto>, IEnumerable<TEntity>>(dtos);
        }
    }
}
