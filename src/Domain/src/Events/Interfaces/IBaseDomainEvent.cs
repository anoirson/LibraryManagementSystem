namespace LibraryManagementSystem.Domain;

public interface IBaseDomainEvent
{
    DateTime OccurredOn { get; }
    Guid EventId { get; }

}
