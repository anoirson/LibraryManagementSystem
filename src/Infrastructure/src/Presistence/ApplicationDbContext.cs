using LibraryManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Infrastructure.Presistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // DbSets for each entity.
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Loan> Loans { get; set; } = null!;
        public DbSet<Reservation> Reservations { get; set; } = null!;
        public DbSet<Notification> Notifications { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Publisher> Publishers { get; set; } = null!;
        public DbSet<Report> Reports { get; set; } = null!;
        public DbSet<Recommendation> Recommendations { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Model configuarations

            // Book → Loan (One-to-Many)
            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Book)
                .WithMany(b => b.Loans)
                .HasForeignKey(l => l.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            // User → Loan (One-to-Many)
            modelBuilder.Entity<Loan>()
                .HasOne(l => l.User)
                .WithMany(u => u.Loans)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Reservation → Book (One-to-Many)
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Book)
                .WithMany(b => b.Reservations)
                .HasForeignKey(r => r.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            // User → Reservation (One-to-Many)
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reservations)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Book → Category (Many-to-One)
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);

            // Book → Publisher (Many-to-One)
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Publisher)
                .WithMany(p => p.Books)
                .HasForeignKey(b => b.PublisherId)
                .OnDelete(DeleteBehavior.SetNull);

            // User → Notification (One-to-Many)
            modelBuilder.Entity<Notification>()
                .HasOne(n => n.User)
                .WithMany(u => u.Notifications)
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Cascade);
                
            // Recommendation → User (Many-to-One)
            modelBuilder.Entity<Recommendation>()
                .HasOne(r => r.User)
                .WithMany(u => u.Recommendations)  // Assuming a User has a collection of Recommendations
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Recommendation → Book (Many-to-One)
            modelBuilder.Entity<Recommendation>()
                .HasOne(r => r.Book)
                .WithMany(b => b.Recommendations)  // Assuming a Book has a collection of Recommendations
                .HasForeignKey(r => r.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            // Registering value objects
            modelBuilder.Entity<User>()
               .OwnsOne(u => u.Email, e =>
               {
                   e.Property(e => e.Value)
                    .HasColumnName("Email") // Stores it as a column in Users table
                    .IsRequired();
               });
            modelBuilder.Entity<Book>()
               .OwnsOne(u => u.ISBN, e =>
               {
                   e.Property(e => e.Value)
                    .HasColumnName("ISBN") // Stores it as a column in Users table
                    .IsRequired();
               });




        }
        /**
        dotnet ef migrations add InitialCreate \
  --project ./src/Infrastructure/LibraryManagementSystem.Infrastructure.csproj \
  --startup-project ./src/WebAPI/LibraryManagementSystem.WebAPI.csproj
         **/


    }
};

