
namespace LibraryManagementSystem.Domain;

public class BookLentEvent : BaseDomainEvent
{
    public Guid UserId { get; set; }
    public Guid BookId { get; set; }

    public BookLentEvent (Guid bookId, Guid UserId) 
    {
        UserId = UserId;
        BookId = bookId;
    }
   
}
