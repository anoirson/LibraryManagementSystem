using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Application;

public class BookCreateDto : AuditableCreateDto
{
    [Required]
    public string Title { get; set; }

    [Required]
    public string ISBN { get; set; }

    [Required]
    public int PublicationYear { get; set; }

    [Required]
    public Guid AuthorId { get; set; }

    [Required]
    public Guid CategoryId { get; set; }

    [Required]
    public Guid PublisherId { get; set; }

    public int AvailableCopies { get; set; } = 1;


}
