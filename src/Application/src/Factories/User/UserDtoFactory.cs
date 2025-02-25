using LibraryManagementSystem.Application.DTOs;
using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.Factories;
public class UserDtoFactory : DtoFactoryBase<User, UserReadDto, UserCreateDto, UserUpdateDto>
{
    public override User CreateEntity(UserCreateDto dto)
    {
        return new User(dto.FirstName, dto.LastName, dto.Email, dto.Password, dto.Role);

    }

    public override UserReadDto CreateRead(User entity)
    {
        return new UserReadDto
        {
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Email = entity.Email.Value,
            Role = entity.Role
        };
    }

    public override User UpdateEntity(User entity, UserUpdateDto dto)
    {
        if (!string.IsNullOrWhiteSpace(dto.FirstName))
            entity.FirstName = dto.FirstName;
        if (!string.IsNullOrWhiteSpace(dto.LastName))
            entity.LastName = dto.LastName;
        if (!string.IsNullOrWhiteSpace(dto.Email))
            entity.Email = new Email(dto.Email);
        if (dto.Role.HasValue)
            entity.Role = (RoleType)dto.Role;

        return entity;
    }
}
