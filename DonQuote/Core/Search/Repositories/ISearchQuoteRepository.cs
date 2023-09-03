using Core.Search.Models;

namespace Core.Search;

public interface ISearchQuoteRepository
{
    public PagedItems<Quote> Search(QuoteFilter qouteFilter);
}