using LibraryManagementSystem.Application.DTOs;
using LibraryManagementSystem.Application.Factories;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Infrastructure.Presistence;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// dotnet ef migrations add InitialCreate --project src/Infrastructure --startup-project src/WebAPI

// Register dependencies
// Register DTO factories. 
builder.Services.AddScoped<IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto>, UserDtoFactory>();
builder.Services.AddScoped<IDtoFactory<Book, BookReadDto, BookCreateDto, BookUpdateDto>, BookDtoFactory>();
builder.Services.AddScoped<IDtoFactory<Loan, LoanReadDto, LoanCreateDto, LoanUpdateDto>, LoanDtoFactory>();
builder.Services.AddScoped<IDtoFactory<Reservation, ReservationReadDto, ReservationCreateDto, ReservationUpdateDto>, ReservationDtoFactory>();
builder.Services.AddScoped<IReadOnlyDtoFactory<Notification, NotificationReadDto>, NotificationDtoFactory>();
builder.Services.AddScoped<IReadOnlyDtoFactory<Report, ReportReadDto>, ReportDtoFactory>();
builder.Services.AddScoped<IDtoFactory<Publisher, PublisherReadDto, PublisherCreateDto, PublisherUpdateDto>, PublisherDtoFactory>();
builder.Services.AddScoped<IDtoFactory<Category, CategoryReadDto, CategoryCreateDto, CategoryUpdateDto>, CategoryDtoFactory>();

// Register DbContext
builder.Services.AddPersistence(builder.Configuration);

// Register Repositories
builder.Services.AddInfrastructure(); 




var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    db.Database.EnsureCreated();
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
