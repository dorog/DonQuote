using Core.Search.Models;

namespace Core.Search.Services;

public sealed class SearchQuoteService
{
    private readonly ISearchQuoteRepository _searchQuoteRepository;

    public SearchQuoteService(ISearchQuoteRepository searchQuoteRepository)
    {
        _searchQuoteRepository = searchQuoteRepository;
    }

    public PagedItems<Quote> Search(QuoteFilter quoteFilter)
    {
        return _searchQuoteRepository.Search(quoteFilter);
    }
}