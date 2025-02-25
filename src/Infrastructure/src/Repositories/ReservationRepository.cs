using LibraryManagementSystem.Application.Repositories;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Infrastructure.Repositories;

public class ReservationRepository : BaseRepository<Reservation>, IReservationRepository
{
    public ReservationRepository(ApplicationDbContext context) : base(context) { }

    public async Task<IEnumerable<Reservation>> GetReservationsByUserAsync(Guid userId)
    {
        return await _context.Reservations
            .Where(r => r.UserId == userId)
            .Include(r => r.Book)
            .ToListAsync();
    }

    public async Task<bool> IsBookReservedAsync(Guid bookId)
    {
        return await _context.Reservations
            .AnyAsync(r => r.BookId == bookId);
    }
}
