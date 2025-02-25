using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.Repositories;

public interface IPublisherRepository : IBaseRepository<Publisher>
{
    Task<Publisher?> GetByNameAsync(string name);
}
