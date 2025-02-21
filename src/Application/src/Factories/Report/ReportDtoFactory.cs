using LibraryManagementSystem.Domain;

namespace LibraryManagementSystem.Application;
public class ReportDtoFactory : DtoFactoryBase<Report, ReportReadDto>
{
    public override ReportReadDto Create(Report entity)
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
