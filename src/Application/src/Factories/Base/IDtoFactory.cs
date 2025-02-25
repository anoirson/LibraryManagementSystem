namespace LibraryManagementSystem.Application.Factories;
public interface IDtoFactory<TDomain, TReadDto, TCreateDto, TUpdateDto> 
    : IReadOnlyDtoFactory<TDomain, TReadDto>
{
    TDomain CreateEntity(TCreateDto dto);
    TDomain UpdateEntity(TDomain entity, TUpdateDto dto);
}