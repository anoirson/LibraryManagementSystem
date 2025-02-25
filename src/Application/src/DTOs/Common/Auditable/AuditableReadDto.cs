namespace LibraryManagementSystem.Application.DTOs;

public abstract class AuditableReadDto : BaseReadDto
{
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

}
