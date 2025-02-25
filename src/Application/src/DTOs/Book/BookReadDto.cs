using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.DTOs;

public class BookReadDto : AuditableReadDto
{
    public string Title { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }
    public BookStatus Status { get; set; }
    public int AvailableCopies { get; set; }
    public string AuthorName { get; set; }
    public string CategoryName { get; set; }
    public string PublisherName { get; set; }

}
