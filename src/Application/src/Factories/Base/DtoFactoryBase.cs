namespace LibraryManagementSystem.Application.Factories;

public abstract class DtoFactoryBase<TDomain, TReadDto, TCreateDto, TUpdateDto> 
    : IDtoFactory<TDomain, TReadDto, TCreateDto, TUpdateDto>
{
    public abstract TReadDto CreateRead(TDomain entity);
    public abstract TDomain CreateEntity(TCreateDto dto);

    public IEnumerable<TReadDto> CreateRead(IEnumerable<TDomain> entities)
    {
        return entities.Select(CreateRead).ToList();
    }

    public abstract TDomain UpdateEntity(TDomain entity, TUpdateDto dto);
    
}