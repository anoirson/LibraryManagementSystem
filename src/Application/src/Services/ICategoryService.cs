using LibraryManagementSystem.Application.DTOs;

namespace LibraryManagementSystem.Application.Services;

public interface ICategoryService : IBaseService<CategoryReadDto, CategoryCreateDto, CategoryUpdateDto>
{
    Task<CategoryReadDto?> GetCategoryByNameAsync(string name);
}
