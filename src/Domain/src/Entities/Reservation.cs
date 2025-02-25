namespace LibraryManagementSystem.Domain;

public class Reservation : AuditableEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid BookId { get; set; }
    public Book Book { get; set; }
    public DateTime ReservationDate { get; set; }
    public ReservationStatus Status { get; set; }

    private Reservation() { }

    public Reservation(Guid userId, Guid bookId, DateTime reservationDate)
    {
        UserId = userId;
        BookId = bookId;
        ReservationDate = reservationDate;
        Status = ReservationStatus.Pending;
    }

    public override string ToString()
    {
        return $"User Id: {UserId}, Book Id: {BookId}, Reservation Date: {ReservationDate}, Status: {Status}";
    }

}
