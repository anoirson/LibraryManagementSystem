using LibraryManagementSystem.Application.DTOs;
using LibraryManagementSystem.Application.Factories;
using LibraryManagementSystem.Application.Repositories;
using LibraryManagementSystem.Application.Services;
using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Infrastructure.Services;

public class PublisherService
    : BaseService<Publisher, PublisherReadDto, PublisherCreateDto, PublisherUpdateDto>,
      IPublisherService
{
    private readonly IPublisherRepository _publisherRepository;
    private readonly IDtoFactory<Publisher, PublisherReadDto, PublisherCreateDto, PublisherUpdateDto> _dtoFactory;

    public PublisherService(
        IPublisherRepository repository,
        IDtoFactory<Publisher, PublisherReadDto, PublisherCreateDto, PublisherUpdateDto> dtoFactory
    ) : base(repository, dtoFactory)
    {
        _publisherRepository = repository;
        _dtoFactory = dtoFactory;
    }

    public async Task<PublisherReadDto?> GetPublisherByNameAsync(string name)
    {
        var publisher = await _publisherRepository.GetByNameAsync(name);
        return publisher == null ? null : _dtoFactory.CreateRead(publisher);
    }
}
