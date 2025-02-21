using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application;

public class UserReadDto : AuditableReadDto
{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string Email {get; set;}
    public RoleType Role {get; set;}

}
