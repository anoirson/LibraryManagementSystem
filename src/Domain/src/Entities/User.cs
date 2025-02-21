namespace LibraryManagementSystem.Domain;

public class User : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Email Email { get; set; }
    public string PasswordHash { get; set; }
    public RoleType Role { get; set; }
    public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public User (string firstName, string lastName, Email email, string passwordHash, RoleType role)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
    }

    public override string ToString()
    {
        return $"Email: {Email}, Role: {Role}, FirstName: {FirstName}, LastName: {LastName}";
    }

}
