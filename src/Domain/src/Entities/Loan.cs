namespace LibraryManagementSystem.Domain;

public class Loan : AuditableEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid BookId { get; set; }
    public Book Book { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public LoanStatus Status { get; set; }

    private Loan() { }

    public Loan(Guid userId, Guid bookId, DateTime loanDate, DateTime dueDate, LoanStatus status)
    {
        UserId = userId;
        BookId = bookId;
        LoanDate = loanDate;
        DueDate = dueDate;
        Status = status;
    }

    public override string ToString()
    {
        return $"User Id: {UserId}, Book Id: {BookId}, Loan Date: {LoanDate}, Due Date: {DueDate}, Return Date: {ReturnDate}, Status: {Status}";
    }

}
