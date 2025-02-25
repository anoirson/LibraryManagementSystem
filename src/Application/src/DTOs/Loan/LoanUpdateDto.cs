using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.DTOs;

public class LoanUpdateDto : AuditableUpdateDto
{
    public DateTime? ReturnDate { get; set; }
    public LoanStatus? Status { get; set; }
    public DateTime? DueDate { get; set; }

}
