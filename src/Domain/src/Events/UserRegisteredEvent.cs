namespace LibraryManagementSystem.Domain;

public class UserRegisteredEvent : BaseDomainEvent
{
    public Guid UserId {get;}
    public Email Email {get;}

    public UserRegisteredEvent(Guid userId, string email)
    {
        UserId = userId;
        Email = new Email(email);
    }

}
