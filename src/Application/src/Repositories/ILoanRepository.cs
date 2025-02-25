using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.Repositories;

public interface ILoanRepository : IBaseRepository<Loan>
{
    Task<IEnumerable<Loan>> GetLoansByUserAsync(Guid UserId);
    Task<IEnumerable<Loan>> GetOverdueLoansAsync();
    Task<bool> IsBookLoanedAsync(Guid bookId);
}
