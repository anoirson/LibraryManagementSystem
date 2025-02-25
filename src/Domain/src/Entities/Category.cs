namespace LibraryManagementSystem.Domain;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Book> Books { get; set; } = new List<Book>();

    private Category() { }

    public Category(string name, string description)
    {
        Name = name;
        Description = description;
    }


}
