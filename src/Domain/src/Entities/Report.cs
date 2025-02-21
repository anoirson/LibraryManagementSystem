namespace LibraryManagementSystem.Domain;

public class Report : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime GeneratedAt { get; set; }

    public Report(string title, string description, DateTime generatedAt)
    {
        Title = title;
        Description = description;
        GeneratedAt = generatedAt;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Description: {Description}, GeneratedAt: {GeneratedAt}";
    }

}
