using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.Repositories;

public interface IRecommendationRepository : IBaseRepository<Recommendation>
{
    Task<IEnumerable<Book>> GetRecommendedBooksForUserAsync(Guid UserId);
}
