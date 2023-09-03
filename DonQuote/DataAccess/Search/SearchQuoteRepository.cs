using Core.Search;
using Core.Search.Models;

namespace DataAccess.Search
{
    public class SearchQuoteRepository : ISearchQuoteRepository
    {
        private const int _maxQuotesPerPage = 3;

        public PagedItems<Quote> Search(QuoteFilter quoteFilter)
        {
            IQueryable<Quote> quotesQuery = QuotesCollection.Quotes.AsQueryable();

            quotesQuery = AddTextConstraint(quotesQuery, quoteFilter);
            quotesQuery = AddOriginatorConstraint(quotesQuery, quoteFilter);

            return PagedItems<Quote>.Create(quotesQuery, quoteFilter.PageNumber, _maxQuotesPerPage);
        }

        private static IQueryable<Quote> AddTextConstraint(IQueryable<Quote> quotesQuery, QuoteFilter qouteFilter)
        {
            if (!string.IsNullOrWhiteSpace(qouteFilter.Message))
            {
                return quotesQuery.Where(quote => quote.Message.Contains(qouteFilter.Message, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                return quotesQuery;
            }
        }

        private static IQueryable<Quote> AddOriginatorConstraint(IQueryable<Quote> quotesQuery, QuoteFilter quoteFilter)
        {
            if (!string.IsNullOrWhiteSpace(quoteFilter.OriginatorName))
            {
                return quotesQuery.Where(quote => quote.OriginatorName.Contains(quoteFilter.OriginatorName, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                return quotesQuery;
            }
        }
    }
}