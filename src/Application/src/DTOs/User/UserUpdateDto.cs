using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.DTOs;

public class UserUpdateDto : AuditableUpdateDto
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public RoleType? Role { get; set; }

}
