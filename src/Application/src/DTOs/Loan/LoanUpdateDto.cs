using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application;

public class LoanUpdateDto : AuditableUpdateDto
{
    public DateTime? ReturnDate { get; set; }
    public LoanStatus Status { get; set; }

}
