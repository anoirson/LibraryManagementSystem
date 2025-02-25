using LibraryManagementSystem.Application.Repositories;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Infrastructure.Repositories;

public class BookRepository : BaseRepository<Book>, IBookRepository
{
    public BookRepository(ApplicationDbContext context) : base(context) { }

    public async Task<IEnumerable<Book>> GetBooksByAuthorAsync(Guid authorId)
    {
        return await _context.Books
            .Where(b => b.Author.Id == authorId)
            .ToListAsync();
    }

    public async Task<IEnumerable<Book>> GetBooksByCategoryAsync(Guid categoryId)
    {
        return await _context.Books
            .Where(b => b.CategoryId == categoryId)
            .ToListAsync();
    }

    public async Task<IEnumerable<Book>> SearchBooksAsync(string titleOrAuthor)
    {
        return await _context.Books
            .Where(b =>
                b.Title.Contains(titleOrAuthor) ||
                b.Author.Name.Contains(titleOrAuthor))
            .ToListAsync();
    }
}
