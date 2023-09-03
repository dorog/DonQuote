using Core.Search;
using Core.Search.Services;
using DataAccess.Search;

namespace Application
{
    internal static class SearchDependenciesExtension
    {
        internal static void AddSearchDependencies(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ISearchQuoteRepository, SearchQuoteRepository>();
            serviceCollection.AddScoped<SearchQuoteService>();
        }
    }
}