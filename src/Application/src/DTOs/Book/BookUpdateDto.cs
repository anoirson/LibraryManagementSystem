using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.DTOs;

public class BookUpdateDto : AuditableUpdateDto
{
    public string? Title { get; set; }
    public int? AvailableCopies { get; set; }
    public BookStatus? Status { get; set; }

}
