using LibraryManagementSystem.Application.DTOs;
using LibraryManagementSystem.Application.Factories;
using LibraryManagementSystem.Application.Repositories;
using LibraryManagementSystem.Application.Services;
using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Infrastructure.Services;

public class CategoryService
    : BaseService<Category, CategoryReadDto, CategoryCreateDto, CategoryUpdateDto>, ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IDtoFactory<Category, CategoryReadDto, CategoryCreateDto, CategoryUpdateDto> _dtoFactory;

    public CategoryService(
        ICategoryRepository repository,
        IDtoFactory<Category, CategoryReadDto, CategoryCreateDto, CategoryUpdateDto> dtoFactory
    ) : base(repository, dtoFactory)
    {
        _categoryRepository = repository;
        _dtoFactory = dtoFactory;
    }

    public async Task<CategoryReadDto?> GetCategoryByNameAsync(string name)
    {
        var category = await _categoryRepository.GetByNameAsync(name);
        return category == null ? null : _dtoFactory.CreateRead(category);
    }

   
}
