namespace Core.Search;

public sealed class PagedItems<TItem>
{
    public required int CurrentPageNumber { get; set; }
    public required int TotalPages { get; set; }

    public required TItem[] Items { get; set; }

    public static PagedItems<TItem> Create(IQueryable<TItem> itemsQuery, int pageNumber, int maxItemsPerPage)
    {
        return new()
        {
            CurrentPageNumber = pageNumber,
            TotalPages = CalculateTotalPages(itemsQuery, maxItemsPerPage),
            Items = TakeItems(itemsQuery, pageNumber, maxItemsPerPage)
        };
    }

    private static int CalculateTotalPages(IQueryable<TItem> itemsQuery, int maxItemPerPage)
    {
        return (int)Math.Ceiling((double)itemsQuery.Count() / maxItemPerPage);
    }

    private static TItem[] TakeItems(IQueryable<TItem> itemsQuery, int pageNumber, int maxItemPerPage)
    {
        return itemsQuery.Skip((pageNumber - 1) * maxItemPerPage)
            .Take(maxItemPerPage)
            .ToArray();
    }
}