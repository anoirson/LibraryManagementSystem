namespace LibraryManagementSystem.Domain;

public class Recommendation : BaseEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid BookId { get; set; }
    public Book Book { get; set; }
    public double Score { get; set; }

    public Recommendation(Guid userId, Guid bookId, double score)
    {
        UserId = userId;
        BookId = bookId;
        Score = score;
    }

    public override string ToString()
    {
        return $"User Id: {UserId}, Book Id: {BookId}, Score: {Score}";
    }



}
