using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.DTOs;

public class ReservationReadDto : AuditableReadDto
{
     public Guid Id { get; set; }
    public string UserName { get; set; }
    public string BookTitle { get; set; }
    public DateTime ReservationDate { get; set; }
    public ReservationStatus Status { get; set; }

}
