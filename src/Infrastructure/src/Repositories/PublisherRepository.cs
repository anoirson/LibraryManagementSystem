using LibraryManagementSystem.Application.Repositories;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Infrastructure.Repositories;

public class PublisherRepository : BaseRepository<Publisher>, IPublisherRepository
{
    public PublisherRepository(ApplicationDbContext context) : base(context) { }

    public async Task<Publisher?> GetByNameAsync(string name)
    {
        return await _context.Publishers
            .FirstOrDefaultAsync(p => p.Name == name);
    }
}
