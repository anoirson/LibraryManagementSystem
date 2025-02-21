using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application;

public class LoanReadDto : AuditableReadDto
{
    public string UserName { get; set; }
    public string BookTitle { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public LoanStatus Status { get; set; }

}
