using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application;
public class ReservationDtoFactory : DtoFactoryBase<Reservation, ReservationReadDto>
{
    public override ReservationReadDto Create(Reservation entity)
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
}
