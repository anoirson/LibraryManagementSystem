using LibraryManagementSystem.Application.DTOs;

namespace LibraryManagementSystem.Application.Services;

public interface IRecommendationService
{
    Task<IEnumerable<BookReadDto>> GetRecommendationsForUserAsync(Guid UserId);
}
