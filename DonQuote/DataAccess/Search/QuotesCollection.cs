using Core.Search;

namespace DataAccess.Search
{
    internal static class QuotesCollection
    {
        internal static readonly Quote[] Quotes = new[]
        {
            new Quote()
            {
                Message = "A comment is a failure to express yourself in code. If you fail, then write a comment; but try not to fail.",
                OriginatorName = "Robert C. Martin"
            },
            new Quote()
            {
                Message = "Art should comfort the disturbed and disturb the comfortable",
                OriginatorName = "Cesar A. Cruz"
            },
            new Quote()
            {
                Message = "It is never too late to be what you might have been.",
                OriginatorName = "George Eliot"
            },
            new Quote()
            {
                Message = "Amateurs sit and wait for inspiration, the rest of us just get up and go to work.",
                OriginatorName = "Stephen King"
            },
            new Quote()
            {
                Message = "Life is tough my darling, but so are you.",
                OriginatorName = "Stephanie Bennett Henry"
            },
            new Quote()
            {
                Message = "Be kind, for everyone you meet is fighting a hard battle.",
                OriginatorName = "Plato"
            },
            new Quote()
            {
                Message = "Ideas are like rabbits. You get a couple and learn how to handle them, and pretty soon you have a dozen.",
                OriginatorName = "John Steinbeck"
            },
            new Quote()
            {
                Message = "How wonderful it is that nobody need wait a single moment before starting to improve the world.",
                OriginatorName = "Anne Frank"
            }
        };
    }
}