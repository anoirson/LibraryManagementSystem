using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Application.DTOs;

public class PublisherCreateDto
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Address {get; set; }
    [Required]
    public string ContactEmail { get; set; }
}
