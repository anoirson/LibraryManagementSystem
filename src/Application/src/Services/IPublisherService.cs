using LibraryManagementSystem.Application.DTOs;


namespace LibraryManagementSystem.Application.Services;

public interface IPublisherService : IBaseService<PublisherReadDto, PublisherCreateDto, PublisherUpdateDto>
{
    Task<PublisherReadDto?> GetPublisherByNameAsync(string name);
}
