using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.Repositories;

public interface IBookRepository : IBaseRepository<Book>
{
    Task<IEnumerable<Book>> GetBooksByAuthorAsync(Guid authorId);
    Task<IEnumerable<Book>> GetBooksByCategoryAsync(Guid categoryId);
    Task<IEnumerable<Book>> SearchBooksAsync(string titleOrAuthor);
}
