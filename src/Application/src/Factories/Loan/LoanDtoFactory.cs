using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application;

public class LoanDtoFactory : DtoFactoryBase<Loan, LoanReadDto>
{
    public override LoanReadDto Create(Loan entity)
    {
        return new LoanReadDto
        {
            Id = entity.Id,
            UserName = $"{entity.User.FirstName} {entity.User.LastName}",
            BookTitle = entity.Book.Title,
            LoanDate = entity.LoanDate,
            DueDate = entity.DueDate,
            ReturnDate = entity.ReturnDate,
            Status = entity.Status
        };
    }
}
