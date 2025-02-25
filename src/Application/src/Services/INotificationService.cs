using LibraryManagementSystem.Application.DTOs;

namespace LibraryManagementSystem.Application.Services;

public interface INotificationService
{
    Task<IEnumerable<NotificationReadDto>> GetUnreadNotificationsAsync(Guid UserId);
    Task MarkNotificationAsReadAsync(Guid notificationId);
    Task SendNotificationAsync(Guid UserId, string message);
}
