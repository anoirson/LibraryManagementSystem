using LibraryManagementSystem.Application.DTOs;

namespace LibraryManagementSystem.Application.Services;

public interface IBookService : IBaseService<BookReadDto, BookCreateDto, BookUpdateDto>
{
    Task<IEnumerable<BookReadDto>> SearchBooksAsync(string query);
}
