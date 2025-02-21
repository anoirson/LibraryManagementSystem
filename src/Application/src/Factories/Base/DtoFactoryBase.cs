namespace LibraryManagementSystem.Application;

public abstract class DtoFactoryBase<TDomain, TDto> : IDtoFactory<TDomain, TDto>
{
    public abstract TDto Create(TDomain entity);

    public IEnumerable<TDto> Create(IEnumerable<TDomain> entities)
    {
        return entities.Select(Create).ToList();
    }
}
