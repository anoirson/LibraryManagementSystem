using LibraryManagementSystem.Application.DTOs;

namespace LibraryManagementSystem.Application.Services;

public interface IReportService
{
    Task<IEnumerable<ReportReadDto>> GetReportsByDateRangeAsync(DateTime startDate, DateTime endDate);
    Task<ReportReadDto?> GenerateReportAsync(string title, string description);
}
