using LibraryManagementSystem.Application.Repositories;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Infrastructure.Repositories;

public class ReportRepository : BaseRepository<Report>, IReportRepository
{
    public ReportRepository(ApplicationDbContext context) : base(context) { }

    public async Task<IEnumerable<Report>> GetReportsByDateRangeAsync(DateTime startDate, DateTime endDate)
    {
        return await _context.Reports
            .Where(r => r.GeneratedAt >= startDate && r.GeneratedAt <= endDate)
            .ToListAsync();
    }
}
