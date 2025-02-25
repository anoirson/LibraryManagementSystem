using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Application.DTOs;

public class ReservationCreateDto : AuditableCreateDto
{
    [Required]
    public Guid UserId { get; set; }

    [Required]
    public Guid BookId { get; set; }
    public DateTime ReservationDate { get; set; }


}
