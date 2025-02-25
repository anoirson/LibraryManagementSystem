using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User?> GetByEmailAsync(string email);
    Task<IEnumerable<User>> GetUsersByRoleAsync(RoleType role);
}
