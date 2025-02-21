using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application;
public class NotificationDtoFactory : DtoFactoryBase<Notification, NotificationReadDto>
{
    public override NotificationReadDto Create(Notification entity)
    {
        return new NotificationReadDto
        {
            Id = entity.Id,
            Message = entity.Message,
            IsRead = entity.IsRead,
            SentAt = entity.SentAt
        };
    }
}
