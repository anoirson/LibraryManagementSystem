namespace LibraryManagementSystem.Application.Factories;

public interface IReadOnlyDtoFactory<TDomain, TReadDto>
{
    TReadDto CreateRead(TDomain entity);
    IEnumerable<TReadDto> CreateRead(IEnumerable<TDomain> entities);
}