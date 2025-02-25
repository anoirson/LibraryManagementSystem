namespace LibraryManagementSystem.Application.DTOs;

public class NotificationReadDto : BaseReadDto
{
    public string Message { get; set; }
    public bool IsRead { get; set; }
    public DateTime SentAt { get; set; }

}
