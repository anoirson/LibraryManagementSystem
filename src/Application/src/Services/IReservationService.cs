using LibraryManagementSystem.Application.DTOs;

namespace LibraryManagementSystem.Application.Services;

public interface IReservationService : IBaseService<ReservationReadDto, ReservationCreateDto, ReservationUpdateDto>
{
    Task<bool> CancelReservationAsync(Guid reservationId);
}
