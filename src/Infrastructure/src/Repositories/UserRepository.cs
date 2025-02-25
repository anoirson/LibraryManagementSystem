using LibraryManagementSystem.Application.Repositories;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Infrastructure.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context) { }

    public async Task<User?> GetByEmailAsync(string email)
    {
        return await _context.Users
            .FirstOrDefaultAsync(u => u.Email.Value == email);
    }

    public async Task<IEnumerable<User>> GetUsersByRoleAsync(RoleType role)
    {
        return await _context.Users
            .Where(u => u.Role == role)
            .ToListAsync();
    }
}
