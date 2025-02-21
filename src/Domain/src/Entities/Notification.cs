namespace LibraryManagementSystem.Domain;

public class Notification : BaseEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; }
    public string Message { get; set; }
    public bool IsRead { get; set; }
    public DateTime SentAt { get; set; }

    public Notification(Guid userId, string message)
    {
        UserId = userId;
        Message = message;
        IsRead = false;
        SentAt = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Email: {UserId}, Message: {Message}, Is Read: {IsRead}, Sent At: {SentAt}";
    }


}
