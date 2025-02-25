namespace LibraryManagementSystem.Domain;

public class Book : AuditableEntity
{
    public string Title { get; set; }
    public ISBN ISBN { get; set; }
    public int PublicationYear { get; set; }
    public BookStatus Status { get; set; }
    public int AvailableCopies { get; set; }
    public Guid AuthorId { get; set; }
    public Author Author { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    public ICollection<Loan> Loans { get; set; } = new List<Loan>();

    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    public ICollection<Recommendation> Recommendations { get; set; } = new List<Recommendation>();
    public Guid PublisherId { get; set; }
    public Publisher Publisher { get; set; }

    private Book() { }

    public Book(string title, string isbn, int publicationYear, int availableCopies, Guid author, Guid category, Guid publisher)
    {
        Title = title;
        ISBN = new ISBN(isbn);
        PublicationYear = publicationYear;
        Status = BookStatus.Available;
        AvailableCopies = availableCopies;
        PublisherId = publisher;
        CategoryId = category;
        AuthorId = author;
    }


}
