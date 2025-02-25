using LibraryManagementSystem.Application.Services;
using LibraryManagementSystem.Application.Repositories;
using LibraryManagementSystem.Application.DTOs;
using LibraryManagementSystem.Application.Factories;
using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Infrastructure.Services;

public class BookService
    : BaseService<Book, BookReadDto, BookCreateDto, BookUpdateDto>,
      IBookService
{
    private readonly IBookRepository _bookRepository;
    private readonly IDtoFactory<Book, BookReadDto, BookCreateDto, BookUpdateDto> _dtoFactory;

    public BookService(
        IBookRepository bookRepository,
        IDtoFactory<Book, BookReadDto, BookCreateDto, BookUpdateDto> dtoFactory)
        : base(bookRepository, dtoFactory)
    {
        _dtoFactory = dtoFactory;
        _bookRepository = bookRepository;
    }
    public async Task<IEnumerable<BookReadDto>> SearchBooksAsync(string query)
    {
        var books = await _bookRepository.SearchBooksAsync(query);
        return _dtoFactory.CreateRead(books);
    }
}
