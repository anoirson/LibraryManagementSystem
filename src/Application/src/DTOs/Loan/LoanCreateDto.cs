using System.ComponentModel.DataAnnotations;
using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.DTOs;

public class LoanCreateDto : AuditableCreateDto
{
    [Required]
    public Guid BookId { get; set; }
    public Guid UserId {get; set; }

    [Required]
    public DateTime LoanDate { get; set; }
    [Required]
    public DateTime DueDate { get; set; }
    [Required]
    public LoanStatus LoanStatus { get; set; }

}
