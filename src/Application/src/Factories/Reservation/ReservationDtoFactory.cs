using LibraryManagementSystem.Application.DTOs;
using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.Factories;
public class ReservationDtoFactory : DtoFactoryBase<Reservation, ReservationReadDto, ReservationCreateDto, ReservationUpdateDto>
{
    public override Reservation CreateEntity(ReservationCreateDto dto)
    {
        return new Reservation(dto.UserId, dto.BookId, dto.ReservationDate);
        
    }

    public override ReservationReadDto CreateRead(Reservation entity)
    {
        return new ReservationReadDto
        {
            Id = entity.Id,
            UserName = $"{entity.User.FirstName} {entity.User.LastName}",
            BookTitle = entity.Book.Title,
            ReservationDate = entity.ReservationDate,
            Status = entity.Status
        };
    }

    public override Reservation UpdateEntity(Reservation entity, ReservationUpdateDto dto)
    {
        if (dto.Status.HasValue)
            entity.Status = dto.Status.Value;
        if (dto.ReservationDate.HasValue)
            entity.ReservationDate = dto.ReservationDate.Value;
       
        return entity;
    }
}
