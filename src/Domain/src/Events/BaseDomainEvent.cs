using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Domain;

public abstract class BaseDomainEvent : IBaseDomainEvent
{
    public DateTime OccurredOn {get; private set;}

    public Guid EventId {get; private set;}
    protected BaseDomainEvent()
    {
        OccurredOn = DateTime.UtcNow;
        EventId = Guid.NewGuid();
    }
}

