using LibraryManagementSystem.Application.DTOs;
using LibraryManagementSystem.Application.Factories;
using LibraryManagementSystem.Application.Repositories;
using LibraryManagementSystem.Application.Services;
using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Infrastructure.Services;

public class RecommendationService : IRecommendationService
{
    private readonly IRecommendationRepository _recommendationRepository;
    private readonly IDtoFactory<Book, BookReadDto, BookCreateDto, BookUpdateDto> _bookDtoFactory;

    public RecommendationService(
        IRecommendationRepository recommendationRepository,
        IDtoFactory<Book, BookReadDto, BookCreateDto, BookUpdateDto> bookDtoFactory
    )
    {
        _recommendationRepository = recommendationRepository;
        _bookDtoFactory = bookDtoFactory;
    }

    public async Task<IEnumerable<BookReadDto>> GetRecommendationsForUserAsync(Guid userId)
    {
        var books = await _recommendationRepository.GetRecommendedBooksForUserAsync(userId);
        return _bookDtoFactory.CreateRead(books);
    }
}
