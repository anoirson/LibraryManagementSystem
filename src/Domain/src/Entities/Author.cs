namespace LibraryManagementSystem.Domain;

public class Author : BaseEntity
{
    public string Name { get; set; }
    public string Biography { get; set; }
    public ICollection<Book> Books { get; set; } = new List<Book>();
    private Author() { }

    public Author(string name, string biography)
    {
        Name = name;
        Biography = biography;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Biography: {Biography}";
    }
    
}
