using LibraryManagementSystem.Application.DTOs;
using LibraryManagementSystem.Application.Factories;
using LibraryManagementSystem.Application.Repositories;
using LibraryManagementSystem.Application.Services;
using LibraryManagementSystem.Domain;


namespace LibraryManagementSystem.Infrastructure.Services;

public class LoanService
    : BaseService<Loan, LoanReadDto, LoanCreateDto, LoanUpdateDto>,
      ILoanService
{
    private readonly ILoanRepository _loanRepository;
    private readonly IDtoFactory<Loan, LoanReadDto, LoanCreateDto, LoanUpdateDto> _dtoFactory;

    public LoanService(
        ILoanRepository repository,
        IDtoFactory<Loan, LoanReadDto, LoanCreateDto, LoanUpdateDto> dtoFactory
    ) : base(repository, dtoFactory)
    {
        _loanRepository = repository;
        _dtoFactory = dtoFactory;
    }

    public async Task<bool> ReturnBookAsync(Guid loanId)
    {
        var loan = await _loanRepository.GetByIdAsync(loanId);
        if (loan == null || loan.ReturnDate != null)
        {
            return false;
        }

        loan.ReturnDate = DateTime.UtcNow;
        loan.Status = LoanStatus.Returned;
        await _loanRepository.UpdateAsync(loan);
        return true;
    }

    public async Task<IEnumerable<LoanReadDto>> GetOverdueLoansAsync()
    {
        var overdueLoans = await _loanRepository.GetOverdueLoansAsync();
        return _dtoFactory.CreateRead(overdueLoans);
    }

    // If you need custom creation logic, you can override CreateAsync, otherwise base is enough.
}
