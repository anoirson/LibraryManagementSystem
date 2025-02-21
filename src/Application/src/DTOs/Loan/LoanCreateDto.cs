using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Application;

public class LoanCreateDto : AuditableCreateDto
{
    [Required]
    public Guid BookId { get; set; }

    [Required]
    public DateTime DueDate { get; set; } 

}
