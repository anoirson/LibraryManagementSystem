using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.DTOs;

public class ReservationUpdateDto : AuditableUpdateDto
{
    public ReservationStatus? Status { get; set; }
    public DateTime? ReservationDate { get; set; }

}
