namespace LibraryManagementSystem.Domain;

public class UserRegisteredEvent : BaseDomainEvent
{
    public Guid UserId {get;}
    public Email Email {get;}

    public UserRegisteredEvent(Guid UserId, string email)
    {
        UserId = UserId;
        Email = new Email(email);
    }

}
