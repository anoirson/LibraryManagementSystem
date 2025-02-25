using LibraryManagementSystem.Application.DTOs;
using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.Factories;

public class LoanDtoFactory : DtoFactoryBase<Loan, LoanReadDto, LoanCreateDto, LoanUpdateDto>
{
    public override Loan CreateEntity(LoanCreateDto dto)
    {
        return new Loan(dto.UserId, dto.BookId, dto.LoanDate, dto.DueDate, dto.LoanStatus);
    }

    public override LoanReadDto CreateRead(Loan entity)
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

    public override Loan UpdateEntity(Loan entity, LoanUpdateDto dto)
    {
        if (dto.ReturnDate.HasValue)
            entity.ReturnDate = dto.ReturnDate.Value;

        if (dto.Status.HasValue)
            entity.Status = dto.Status.Value;

        if (dto.DueDate.HasValue)
            entity.DueDate = dto.DueDate.Value;

        return entity;
    }
}
