namespace LibraryManagementSystem.Application;

public interface IDtoFactory<TDomain, TDto>
{
    TDto Create(TDomain entity);
    IEnumerable<TDto> Create(IEnumerable<TDomain> entities);
}
