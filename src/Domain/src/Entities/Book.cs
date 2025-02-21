namespace LibraryManagementSystem.Domain;

public class Book : AuditableEntity
{
    public string Title { get; set; }
    public ISBN ISBN { get; set; }
    public int PublicationYear { get; set; }
    public BookStatus Status { get; set; }
    public int AvailableCopies { get; set; }
    public Author Author { get; set; }
    public Category Category { get; set; }
    public ICollection<Loan> Loans { get; set; } = new List<Loan>();

    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    public Publisher Publisher { get; set; }

    public Book(string title, ISBN isbn, int publicationYear, BookStatus status, int availableCopies, Author author, Category category, Publisher publisher)
    {
        Title = title;
        ISBN = isbn;
        PublicationYear = publicationYear;
        Status = status;
        AvailableCopies = availableCopies;
        Author = author;
        Category = category;
        Publisher = publisher;
    }
    
    
}
