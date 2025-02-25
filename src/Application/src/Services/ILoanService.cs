using LibraryManagementSystem.Application.DTOs;

namespace LibraryManagementSystem.Application.Services;

public interface ILoanService : IBaseService<LoanReadDto, LoanCreateDto, LoanUpdateDto>
{
    Task<bool> ReturnBookAsync(Guid loanId);
    Task<IEnumerable<LoanReadDto>> GetOverdueLoansAsync();
}
