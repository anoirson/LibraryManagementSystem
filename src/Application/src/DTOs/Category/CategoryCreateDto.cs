using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Application.DTOs;

public class CategoryCreateDto : BaseCreateDto
{
    [Required]
    public required string Name { get; set; }
    [Required]
    public required string Description { get; set; }
}
