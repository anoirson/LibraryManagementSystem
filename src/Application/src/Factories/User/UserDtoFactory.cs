using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application;
public class UserDtoFactory : DtoFactoryBase<User, UserReadDto>
{
    public override UserReadDto Create(User entity)
    {
        return new UserReadDto
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Email = entity.Email.Value,
            Role = entity.Role
        };
    }
}
