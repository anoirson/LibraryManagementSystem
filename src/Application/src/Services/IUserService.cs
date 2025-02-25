using LibraryManagementSystem.Application.DTOs;

namespace LibraryManagementSystem.Application.Services;

public interface IUserService : IBaseService<UserReadDto, UserCreateDto, UserUpdateDto>
{
    Task<UserReadDto?> GetUserByEmailAsync(string email);
}
