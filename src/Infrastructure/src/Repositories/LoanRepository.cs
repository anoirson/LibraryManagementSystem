using LibraryManagementSystem.Application.Repositories;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Infrastructure.Repositories;

public class LoanRepository : BaseRepository<Loan>, ILoanRepository
{
    public LoanRepository(ApplicationDbContext context) : base(context) { }

    public async Task<IEnumerable<Loan>> GetLoansByUserAsync(Guid userId)
    {
        return await _context.Loans
            .Where(l => l.UserId == userId)
            .Include(l => l.Book)
            .ToListAsync();
    }

    public async Task<IEnumerable<Loan>> GetOverdueLoansAsync()
    {
        var today = DateTime.UtcNow;
        return await _context.Loans
            .Where(l => l.DueDate < today && l.ReturnDate == null)
            .Include(l => l.Book)
            .Include(l => l.User)
            .ToListAsync();
    }

    public async Task<bool> IsBookLoanedAsync(Guid bookId)
    {
        return await _context.Loans
            .AnyAsync(l => l.BookId == bookId && l.ReturnDate == null);
    }
}
