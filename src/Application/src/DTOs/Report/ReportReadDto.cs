namespace LibraryManagementSystem.Application.DTOs;

public class ReportReadDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime GeneratedAt { get; set; }

}
