namespace LibraryManagementSystem.Domain;

public class ReservationCreatedEvent : BaseDomainEvent
{
    public Guid ReservationId { get; }

    public ReservationCreatedEvent(Guid reservationId)
    {
        ReservationId = reservationId;
    }

}
