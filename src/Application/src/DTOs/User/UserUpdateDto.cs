namespace LibraryManagementSystem.Application;

public class UserUpdateDto : AuditableUpdateDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

}
