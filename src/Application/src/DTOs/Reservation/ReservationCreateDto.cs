using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Application;

public class ReservationCreateDto : AuditableCreateDto
{
    [Required]
    public Guid UserId { get; set; }

    [Required]
    public Guid BookId { get; set; }


}
