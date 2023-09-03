namespace Application;

internal static class DependencyInjectionExtension
{
    internal static void AddAppServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSearchDependencies();
    }
}