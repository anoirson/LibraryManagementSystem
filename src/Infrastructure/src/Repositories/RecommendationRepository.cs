using LibraryManagementSystem.Application.Repositories;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Infrastructure.Repositories;

public class RecommendationRepository : BaseRepository<Recommendation>, IRecommendationRepository
{
    public RecommendationRepository(ApplicationDbContext context) : base(context) { }

    public async Task<IEnumerable<Book>> GetRecommendedBooksForUserAsync(Guid userId)
    {
        return await _context.Recommendations
            .Where(r => r.UserId == userId)
            .OrderByDescending(r => r.Score)
            .Include(r => r.Book)
            .Select(r => r.Book)
            .ToListAsync();
    }
}
