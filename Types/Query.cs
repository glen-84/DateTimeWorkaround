namespace DateTimeWorkaround.Types;

[QueryType]
public static class Query
{
    public static Book GetBook(DateTime dateTime, DateTimeOffset dateTimeOffset)
    {
        Console.WriteLine(dateTime.ToString("o"));
        Console.WriteLine(dateTimeOffset.ToString("o"));

        return new Book("C# in depth.", new Author("Jon Skeet"), DateTimeOffset.Now);
    }

    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public static IQueryable<Book> GetBooks()
    {
        var book = new Book(
            "C# in depth.",
            new Author("Jon Skeet"),
            new DateTimeOffset(2023, 10, 1, 0, 0, 0, TimeSpan.Zero));

        return new List<Book>() { book }.AsQueryable();
    }
}
