using LibraryManagementSystem.Application.DTOs;
using LibraryManagementSystem.Application.Factories;
using LibraryManagementSystem.Application.Repositories;
using LibraryManagementSystem.Application.Services;
using LibraryManagementSystem.Domain;


namespace LibraryManagementSystem.Infrastructure.Services;

public class ReservationService
    : BaseService<Reservation, ReservationReadDto, ReservationCreateDto, ReservationUpdateDto>,
      IReservationService
{
    private readonly IReservationRepository _reservationRepository;
    private readonly IDtoFactory<Reservation, ReservationReadDto, ReservationCreateDto, ReservationUpdateDto> _dtoFactory;

    public ReservationService(
        IReservationRepository repository,
        IDtoFactory<Reservation, ReservationReadDto, ReservationCreateDto, ReservationUpdateDto> dtoFactory
    ) : base(repository, dtoFactory)
    {
        _reservationRepository = repository;
        _dtoFactory = dtoFactory;
    }

    public async Task<bool> CancelReservationAsync(Guid reservationId)
    {
        var reservation = await _reservationRepository.GetByIdAsync(reservationId);
        if (reservation == null) return false;

        reservation.Status = ReservationStatus.Cancelled;
        await _reservationRepository.UpdateAsync(reservation);
        return true;
    }

    public async Task<IEnumerable<ReservationReadDto>> GetReservationsByUserAsync(Guid userId)
    {
        var reservations = await _reservationRepository.GetReservationsByUserAsync(userId);
        return _dtoFactory.CreateRead(reservations);
    }
}
