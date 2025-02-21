using System.ComponentModel.DataAnnotations;
using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application;

public class UserCreateDto : AuditableCreateDto
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [MinLength(6)]
    [StrongPasswordAttribute]
    [Required]
    public string Password { get; set; }
    public RoleType Role { get; set; }

}
