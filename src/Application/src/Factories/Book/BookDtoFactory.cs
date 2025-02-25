using LibraryManagementSystem.Application.DTOs;
using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.Factories;

public class BookDtoFactory
    : DtoFactoryBase<Book, BookReadDto, BookCreateDto, BookUpdateDto>
{
    public override Book CreateEntity(BookCreateDto dto)
    {
        return new Book(dto.Title,
         dto.ISBN,
         dto.PublicationYear,
         dto.AvailableCopies,
         dto.AuthorId,
         dto.CategoryId,
         dto.PublisherId);
    }

    public override BookReadDto CreateRead(Book entity)
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
    public override Book UpdateEntity(Book entity, BookUpdateDto dto)
    {
        if (!string.IsNullOrWhiteSpace(dto.Title))
            entity.Title = dto.Title;

        if (dto.AvailableCopies.HasValue)
            entity.AvailableCopies = dto.AvailableCopies.Value;

        if (dto.Status.HasValue)
            entity.Status = dto.Status.Value;
        
        return entity;
    }
}
