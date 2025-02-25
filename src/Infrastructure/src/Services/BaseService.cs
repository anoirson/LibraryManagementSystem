using LibraryManagementSystem.Application.Services;
using LibraryManagementSystem.Application.Repositories;
using LibraryManagementSystem.Application.Factories; // or wherever your factories live

namespace LibraryManagementSystem.Infrastructure.Services;


public abstract class BaseService<TEntity, TReadDto, TCreateDto, TUpdateDto>
    : IBaseService<TReadDto, TCreateDto, TUpdateDto>
    where TEntity : class
{
    protected readonly IBaseRepository<TEntity> _repository;
    protected readonly IDtoFactory<TEntity, TReadDto, TCreateDto, TUpdateDto> _dtoFactory;

    protected BaseService(
        IBaseRepository<TEntity> repository,
        IDtoFactory<TEntity, TReadDto, TCreateDto, TUpdateDto> readDtoFactory)
    {
        _repository = repository;
        _dtoFactory = readDtoFactory;
    }

    public virtual async Task<IEnumerable<TReadDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return _dtoFactory.CreateRead(entities); // Bulk convert to Read DTOs
    }

    public virtual async Task<TReadDto?> GetByIdAsync(Guid id)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null)
        {
            throw new KeyNotFoundException($"Entity with ID {id} not found.");
        }
        return _dtoFactory.CreateRead(entity);
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
    }

    public virtual async Task<TReadDto> CreateAsync(TCreateDto dto)
    {
        var entity = _dtoFactory.CreateEntity(dto);
        var createdEntity = await _repository.AddAsync(entity);
        return _dtoFactory.CreateRead(createdEntity);
    }

    public async Task UpdateAsync(Guid id, TUpdateDto dto)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null)
        {
            throw new KeyNotFoundException($"Entity with ID {id} not found.");
        }
        var updated = _dtoFactory.UpdateEntity(entity, dto);
        await _repository.UpdateAsync(updated);
    }
}
