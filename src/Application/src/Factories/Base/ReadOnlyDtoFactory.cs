namespace LibraryManagementSystem.Application.Factories;


public abstract class ReadOnlyDtoFactoryBase<TDomain, TReadDto> 
    : IReadOnlyDtoFactory<TDomain, TReadDto>
{
    public abstract TReadDto CreateRead(TDomain entity);

    public IEnumerable<TReadDto> CreateRead(IEnumerable<TDomain> entities)
    {
        return entities.Select(CreateRead).ToList();
    }
}