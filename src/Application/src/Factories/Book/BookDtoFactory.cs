using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application;

public class BookDtoFactory : DtoFactoryBase<Book, BookReadDto>
{
    public override BookReadDto Create(Book entity)
    {
        return new BookReadDto
        {
            Id = entity.Id,
            Title = entity.Title,
            ISBN = entity.ISBN.Value,
            PublicationYear = entity.PublicationYear,
            Status = entity.Status,
            AvailableCopies = entity.AvailableCopies,
            AuthorName = entity.Author.Name,
            CategoryName = entity.Category.Name,
            PublisherName = entity.Publisher.Name
        };
    }
}
