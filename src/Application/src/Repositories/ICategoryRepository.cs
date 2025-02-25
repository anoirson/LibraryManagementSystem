using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.Repositories;

public interface ICategoryRepository : IBaseRepository<Category>
{
    Task<Category?> GetByNameAsync(string name);
}
