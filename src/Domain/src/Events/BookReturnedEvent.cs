namespace LibraryManagementSystem.Domain;

public class BookReturnedEvent : BaseDomainEvent
{
    public Guid BookId { get; }
    public Guid MemberId { get; }
    public BookReturnedEvent(Guid bookId, Guid memberId)
    {
        BookId = bookId;
        MemberId = memberId;
    }

}
