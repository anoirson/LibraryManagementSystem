using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application;

public class ReservationUpdateDto : AuditableUpdateDto
{
    public ReservationStatus Status { get; set; }

}
