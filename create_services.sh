#!/bin/bash

BASE_DIR="src/Application/src/Services"

# Ensure the Services directory exists
mkdir -p "$BASE_DIR"

# Function to create service interface files
create_service() {
    local file_path="$BASE_DIR/$1"
    cat > "$file_path" <<EOL
using LibraryManagementSystem.Application.DTOs;

namespace LibraryManagementSystem.Application.Services;

$2
EOL
    echo "Created: $file_path"
}

# CreateRead Base Service Interface
create_service "IBaseService.cs" \
"public interface IBaseService<TReadDto, TCreateDto, TUpdateDto>
{
    Task<IEnumerable<TReadDto>> GetAllAsync();
    Task<TReadDto?> GetByIdAsync(Guid id);
    Task<TReadDto> CreateAsync(TCreateDto dto);
    Task UpdateAsync(Guid id, TUpdateDto dto);
    Task DeleteAsync(Guid id);
}"

# CreateRead specific services extending IBaseService
create_service "IUserService.cs" \
"public interface IUserService : IBaseService<UserReadDto, UserCreateDto, UserUpdateDto>
{
    Task<UserReadDto?> GetUserByEmailAsync(string email);
}"

create_service "IBookService.cs" \
"public interface IBookService : IBaseService<BookReadDto, BookCreateDto, BookUpdateDto>
{
    Task<IEnumerable<BookReadDto>> SearchBooksAsync(string query);
}"

create_service "ILoanService.cs" \
"public interface ILoanService : IBaseService<LoanReadDto, LoanCreateDto, LoanUpdateDto>
{
    Task<bool> ReturnBookAsync(Guid loanId);
    Task<IEnumerable<LoanReadDto>> GetOverdueLoansAsync();
}"

create_service "IReservationService.cs" \
"public interface IReservationService : IBaseService<ReservationReadDto, ReservationCreateDto, ReservationUpdateDto>
{
    Task<bool> CancelReservationAsync(Guid reservationId);
}"

create_service "INotificationService.cs" \
"public interface INotificationService
{
    Task<IEnumerable<NotificationReadDto>> GetUnreadNotificationsAsync(Guid UserId);
    Task MarkNotificationAsReadAsync(Guid notificationId);
    Task SendNotificationAsync(Guid UserId, string message);
}"

create_service "IRecommendationService.cs" \
"public interface IRecommendationService
{
    Task<IEnumerable<BookReadDto>> GetRecommendationsForUserAsync(Guid UserId);
}"

create_service "ICategoryService.cs" \
"public interface ICategoryService : IBaseService<CategoryReadDto, CategoryCreateDto, CategoryUpdateDto>
{
    Task<CategoryReadDto?> GetCategoryByNameAsync(string name);
}"

create_service "IPublisherService.cs" \
"public interface IPublisherService : IBaseService<PublisherReadDto, PublisherCreateDto, PublisherUpdateDto>
{
    Task<PublisherReadDto?> GetPublisherByNameAsync(string name);
}"

create_service "IReportService.cs" \
"public interface IReportService
{
    Task<IEnumerable<ReportReadDto>> GetReportsByDateRangeAsync(DateTime startDate, DateTime endDate);
    Task<ReportReadDto?> GenerateReportAsync(string title, string description);
}"

echo "✅ All Service Interfaces have been successfully created!"

