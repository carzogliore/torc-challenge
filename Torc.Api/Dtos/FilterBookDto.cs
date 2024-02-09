namespace Torc.Api.Dtos;
public record FilterBookDto (string? Title, string? Publisher, string? Author, string? Type, string? ISBN, string? Category);
public record BookDto(int Id, string Title, string Publisher, string Author, string Type, string ISBN, string Category, int TotalCopies, int CopiesInUse );