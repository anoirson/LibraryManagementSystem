namespace LibraryManagementSystem.Application;

public abstract class AuditableReadDto : BaseReadDto
{
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

}
