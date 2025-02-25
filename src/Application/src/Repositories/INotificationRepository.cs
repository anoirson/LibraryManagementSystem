using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.Repositories;

public interface INotificationRepository : IBaseRepository<Notification>
{
    Task<IEnumerable<Notification>> GetUnreadNotificationsByUserAsync(Guid UserId);
}
