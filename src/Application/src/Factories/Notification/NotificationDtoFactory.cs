using LibraryManagementSystem.Application.DTOs;
using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.Factories;
public class NotificationDtoFactory : ReadOnlyDtoFactoryBase<Notification, NotificationReadDto>
{
    public override NotificationReadDto CreateRead(Notification entity)
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
