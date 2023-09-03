namespace Core.Search.Models;

public sealed class QuoteFilter
{
    public required int PageNumber { get; init; }

    public required string Message { get; init; }
    public required string OriginatorName { get; init; }
}