using LibraryManagementSystem.Application.DTOs;
using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application.Factories;
public class ReportDtoFactory : ReadOnlyDtoFactoryBase<Report, ReportReadDto>
{
    public override ReportReadDto CreateRead(Report entity)
    {
        return new ReportReadDto
        {
            Id = entity.Id,
            Title = entity.Title,
            Description = entity.Description,
            GeneratedAt = entity.GeneratedAt
        };
    }
}
