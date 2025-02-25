using LibraryManagementSystem.Application.DTOs;
using LibraryManagementSystem.Application.Factories;
using LibraryManagementSystem.Application.Repositories;
using LibraryManagementSystem.Application.Services;
using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Infrastructure.Services;


public class UserService
    : BaseService<User, UserReadDto, UserCreateDto, UserUpdateDto>,
      IUserService

{
    protected readonly IUserRepository _userRepository;
    protected readonly IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto> _dtoFactory;
    public UserService(IUserRepository repository, IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto> dtoFactory) : base(repository, dtoFactory)
    {
        _userRepository = repository;
        _dtoFactory = dtoFactory;
    }

    public async Task<UserReadDto?> GetUserByEmailAsync(string email)
    {
        var user = await _userRepository.GetByEmailAsync(email);
        if (user == null)
        {
            throw new KeyNotFoundException($"User with email {email} not found.");
        }
        return _dtoFactory.CreateRead(user);
    }
}