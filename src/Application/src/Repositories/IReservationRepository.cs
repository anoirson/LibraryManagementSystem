using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.Repositories;

public interface IReservationRepository : IBaseRepository<Reservation>
{
    Task<IEnumerable<Reservation>> GetReservationsByUserAsync(Guid UserId);
    Task<bool> IsBookReservedAsync(Guid bookId);
}
