namespace LibraryManagementSystem.Application.Services;

public interface IBaseService<TReadDto, TCreateDto, TUpdateDto>
{
    Task<IEnumerable<TReadDto>> GetAllAsync();
    Task<TReadDto?> GetByIdAsync(Guid id);
    Task<TReadDto> CreateAsync(TCreateDto dto);
    Task UpdateAsync(Guid id, TUpdateDto dto);
    Task DeleteAsync(Guid id);
}
