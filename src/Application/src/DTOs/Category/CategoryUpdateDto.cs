namespace LibraryManagementSystem.Application.DTOs;

public class CategoryUpdateDto : BaseUpdateDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
}
