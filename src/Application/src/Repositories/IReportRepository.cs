using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.Repositories;

public interface IReportRepository : IBaseRepository<Report>
{
    Task<IEnumerable<Report>> GetReportsByDateRangeAsync(DateTime startDate, DateTime endDate);
}
