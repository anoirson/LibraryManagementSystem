namespace LibraryManagementSystem.Domain;

public class Publisher : BaseEntity
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactEmail { get; set; }
    public ICollection<Book> Books { get; set; } = [];

    public Publisher(string name, string address, string contactEmail)
    {
        Name = name;
        Address = address;
        ContactEmail = contactEmail;
    }
    
    public override string ToString()
    {
        return $"Name: {Name}, Address: {Address}, ContactEmail: {ContactEmail}";
    }
    

}
