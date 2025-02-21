namespace LibraryManagementSystem.Application;

public class RecommendationReadDto : BaseReadDto
{
    public string UserName { get; set; }
    public string BookTitle { get; set; }
    public double Score { get; set; }

}
